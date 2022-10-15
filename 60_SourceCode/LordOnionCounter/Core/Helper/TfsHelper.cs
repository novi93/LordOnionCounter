using LOC.Core.Extension;
using LOC.Entites;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.Common;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace LOC.Core.Helper
{
    public static class TfsHelper
    {
        public static VersionControlServer vcServer;
        public static TfsTeamProjectCollection tfsTPC;

        #region Common 
        public static void Connect(Uri TeamProjectUri)
        {
            tfsTPC = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(TeamProjectUri);
            vcServer = tfsTPC.GetService<VersionControlServer>();
        }

        /// <summary>
        /// </summary>
        /// <param name="changesetID">Changeset ID</param>
        /// <returns>all changes in Changeset</returns>
        public static List<Change> GetChanges(int changesetID)
        {
            return vcServer.GetChangeset(changesetID).Changes.ToList();
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="changesets">List ChangeSet to count LOC</param>
        /// <returns></returns>
        public static List<GridEntryEntity> GetInfo(IEnumerable<int> changesets)
        {
            // todo need to speedup
            Global.Logger.WriteLine("GetInfo all Changes");

            var minCs = changesets.Min();
            var maxCs = changesets.Max();

            // ==========================================
            // Gets all Changes
            // ==========================================
            var changes = new List<Change>();
            Global.Logger.WriteLine("GetInfo all Changes in Changeset list... ");
            foreach (var cs in changesets)
            {
                changes.AddRange(GetChanges(cs));
            }

            // *************************************************************
            // remove not count Item
            // *************************************************************
            Global.Logger.WriteLine("remove not count Item");
            // is result include Folder
            var showfolder = bool.Parse(ConfigurationManager.AppSettings.Get("ShowFolder"));

            // ==========================================
            // filter by config in setting.Json
            // ==========================================
            var changesFiltered = changes.Where(x =>
            {
                // get folder
                if (x.Item.ItemType == ItemType.Folder)
                {
                    return showfolder;
                }

                // ignore file
                var IsIgnore = SettingHelper.Settings.IgnoreName.Where(y => Path.GetFileName(x.Item.ServerItem).Contains(y, StringComparison.OrdinalIgnoreCase)).Any();
                if (IsIgnore)
                {
                    return false;
                }

                // get targerFile
                if (SettingHelper.Settings.TargetExtension.Contains(Path.GetExtension(x.Item.ServerItem), StringComparer.OrdinalIgnoreCase))
                {
                    return true;
                }
                return false;

            });

            // ==========================================
            // stored the changes into Dictionary 
            //     Key   : ItemId
            //     Value : MinItem(BaseItem) - MaxItem(Diffitem)
            // ==========================================
            ConcurrentDictionary<int, GridEntryEntity> dicChange = new ConcurrentDictionary<int, GridEntryEntity>();
            Global.Logger.WriteLine("Calculate Changeset in range");
            // iterator on filtered Changes => convert its to dicchanges
            changesFiltered.ToList().ForEach(newItem =>
            {
                dicChange.AddOrUpdate(newItem.Item.ItemId,
                    new GridEntryEntity { MinItem = newItem, MaxItem = newItem },
                    (k, oldItem) =>
                    {
                        if (newItem.Item.ChangesetId < oldItem.MinItem.Item.ChangesetId)
                        {
                            //if (!newItem.ChangeType.HasFlag(ChangeType.Branch))
                            //{
                            oldItem.MinItem = newItem;
                            //}
                        }
                        if (newItem.Item.ChangesetId > oldItem.MaxItem.Item.ChangesetId)
                        {
                            oldItem.MaxItem = newItem;
                        }
                        return oldItem;
                    }
                    );
            });

            // ==========================================
            // remove delete, rollback changes
            // ==========================================
            Global.Logger.WriteLine("remove delete, rollback file changes");
            //remove deleted item 
            var DeletedOrRemoved = Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Delete |
                                    Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Rollback;
            dicChange.Where((x) => (x.Value.MaxItem.ChangeType & DeletedOrRemoved) == x.Value.MaxItem.ChangeType)
                .Select(y => y.Key)
                .ToList()
                .ForEach(x =>
                {
                    dicChange.TryRemove(x, out GridEntryEntity dummy);
                });

            // ==========================================
            // remove delete, rollback changes
            // ==========================================
            Global.Logger.WriteLine("Start calculate base file");
            // find base item
            var rs2 = dicChange.Select((x) =>
            {
                // Branch
                if (x.Value.MinItem.ChangeType.HasFlag(Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Branch))
                {
                    x.Value.BaseItem = x.Value.MinItem;
                    return x.Value;
                }

                //Edit
                if (x.Value.MinItem.ChangeType.HasFlag(Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Edit))
                {
                    var minItem = x.Value.MinItem.Item;
                    Change preChange;
                    var cs = GetChangesetsOfFile(minItem);
                    if (cs != null && cs.Count() > 0)
                    {
                        preChange = cs.First().Changes[0];
                    }
                    else
                    {
                        preChange = null;
                    }

                    if (preChange != null)
                    {
                        x.Value.BaseItem = preChange;
                    }
                }

                return x.Value;
            })
            .ToList()
            ;

            //var rsRename = rs2.Where(x => x.MaxItem.ChangeType.HasFlag(Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Rename));
            //rsRename.OrderBy(x => x.MaxItem.Item.ChangesetId);
            //var oldNameList  = new List<GridEntryEntity>();
            //foreach (var item in rsRename)
            //{
            //    var maxItem = item.MaxItem;
            //    var minItem = item.MinItem;

            //    IEnumerable<Changeset> queryHistory =
            //    vcServer.QueryHistory(
            //        new QueryHistoryParameters(maxItem.Item.ServerItem, RecursionType.None)
            //        {
            //            IncludeChanges = true,
            //            SlotMode = false,
            //            VersionEnd = new ChangesetVersionSpec(maxItem.Item.ChangesetId - 1)
            //        });

            //    var changesIdHistory = queryHistory.SelectMany(changeset => changeset.Changes);
            //    var tempOld = rs2.Where((x)=> x.ChangeType.HasFlag(Microsoft.TeamFoundation.VersionControl.Client.ChangeType.Rename) &&
            //         changesIdHistory.Any(old => old.Item.ServerItem == x.MaxItem.Item.ServerItem ));

            //    oldNameList.Concat(tempOld);

            //}
            //rs2.RemoveAll(x => oldNameList.Contains(x) );
            return rs2;
        }

        public static IEnumerable<Changeset> GetChangesetsOfFile(Item theChangeItem)
        {
            //Query History parameters
            int changeId = (theChangeItem.DeletionId != 0) ?
                          theChangeItem.ChangesetId - 1 :
                           theChangeItem.ChangesetId;

            ChangesetVersionSpec version = new
                                  ChangesetVersionSpec(changeId);
            ChangesetVersionSpec versionFrom = new
                                  ChangesetVersionSpec(1);
            ChangesetVersionSpec versionTo = new
                                  ChangesetVersionSpec(changeId - 1);
            string path = theChangeItem.ServerItem;

            var maxCount = 1000;

            //Query History Command
            return vcServer.QueryHistory(path,
                     version, 0, RecursionType.None, null,
                     versionFrom, versionTo,
                     maxCount, true, false).Cast<Changeset>();

        }


        public static Tuple<WorkItem, List<Changeset>> GetChangesetFromWorkItem(int WorkItemNo)
        {
            var store = new WorkItemStore(tfsTPC);
            var associatedChangesets = new List<Changeset>();
            var workItem = store.GetWorkItem(WorkItemNo);


            foreach (var link in workItem.Links)
            {
                if ((link == null) || !(link is ExternalLink))
                    continue;

                string externalLink = ((ExternalLink)link).LinkedArtifactUri;
                var artifact = LinkingUtilities.DecodeUri(externalLink);

                if (artifact.ArtifactType == "Changeset")
                    associatedChangesets.Add(vcServer.ArtifactProvider.GetChangeset(new Uri(externalLink)));
            }

            return Tuple.Create(workItem, associatedChangesets);
        }

        #region PRJ
        public static Dictionary<string, ProjectInfo> GetPrjDict()
        {
            ICommonStructureService css = (ICommonStructureService)tfsTPC.GetService(typeof(ICommonStructureService));
            return css.ListAllProjects().OrderBy((x) => x.Name).ToDictionary((item) => item.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="changesets">Get All WorkItem in TeamProject</param>
        /// <returns></returns>
        public static WorkItemCollection GetWorkItemList(ProjectInfo projectInfo, string filterText)
        {
            Global.Logger.WriteLine("GetWorkItemList");

            var workItemStore = tfsTPC.GetService<WorkItemStore>();
            var query = string.Empty;
            query += " SELECT [System.Id], [System.WorkItemType],";
            query += " [System.State], [System.AssignedTo], [System.Title] ";
            query += " FROM WorkItems ";
            query += " WHERE [System.TeamProject] = '" + projectInfo.Name + "'";
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                query += " AND [System.Title] Contains '" + filterText + "'";
            }
            query += " ORDER BY [System.WorkItemType], [System.Id]";

            WorkItemCollection WIC = workItemStore.Query(query);

            return WIC;
        }
        #endregion

        private static void GetRenamedItem(Change change)
        {
            //The key here is to be sure Slot Mode is enabled.
            IEnumerable<Changeset> queryHistory =
                vcServer.QueryHistory(
                    new QueryHistoryParameters(change.Item.ServerItem, RecursionType.None)
                    {
                        IncludeChanges = true,
                        SlotMode = false,
                        VersionStart = new ChangesetVersionSpec(change.Item.ChangesetId), // todo
                        VersionEnd = new ChangesetVersionSpec(change.Item.ChangesetId)
                    });

            var changes = queryHistory.SelectMany(changeset => changeset.Changes);

        }
    }
}
