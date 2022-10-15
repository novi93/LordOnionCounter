using AutoMapper;
using LOC.Core.Counter;
using LOC.Core.Download;
using LOC.Core.Factory;
using LOC.Core.Helper;
using LOC.Entites;
using LOC.Entites.Count;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using static LOC.Core.Helper.JsonHelper;
using Directory = Pri.LongPath.Directory;

namespace LOC.VM.CountPG
{
    public class CountPgVM : INotifyPropertyChanged
    {
        public CountPgVM(ICount counter, IDownloader<TfsGuildPathDownloadItem> downloader, IMapper mapper)
        {
            _LocCounter = counter;
            _Downloader = downloader;
            _Mapper = mapper;

            this.Gui = Guid.NewGuid().ToString();
        }

        //behavior
        private ICount _LocCounter;
        private IDownloader<TfsGuildPathDownloadItem> _Downloader;
        private IMapper _Mapper;

        public string _gui;
        public string _workItem;
        public string _workItemOld;
        public string _workItemName;

        public bool _IsGodMode;
        public List<GridEntryEntity> grdViewModel;
        public List<GridChangesetEntryEntity> grdChangesetVM;
    
        public string Gui
        {
            get { return _gui; }
            set
            {
                _gui = value;
                OnPropertyChanged("Gui");
            }
        }

        public string WorkItem
        {
            get { return _workItem; }
            set
            {
                _workItem = value;
                OnPropertyChanged("WorkItem");
            }
        }
        public string WorkItemName
        {
            get { return _workItemName; }
            set
            {
                _workItemName = value;
                OnPropertyChanged("WorkItemName");
            }
        }
        public bool IsGodMode
        {
            get { return _IsGodMode; }
            set
            {
                _IsGodMode = value;
                OnPropertyChanged("IsGodMode");
            }
        }
        public bool IsNormalMode
        {
            get { return !_IsGodMode; }
            set
            {
                _IsGodMode = !value;
            }
        }

        public List<GridChangesetEntryEntity> CheckedChangeSet
        {
            get
            {
                return grdChangesetVM.Where(x => x.Check).ToList();
            }
        }
        public List<GridEntryEntity> CheckedChange
        {
            get
            {
                return grdViewModel.Where(x => x.Check && x.IsFile).ToList();
            }
        }
        /// <summary>
        /// Load appsetting then stored in local variable
        /// </summary>
        public void LoadAppSetting()
        {
            CountResquestFactory.LoadAppSetting();
            SettingHelper.LoadSetting();
            //SettingFile = ConfigurationManager.AppSettings["SettingFile"];

            ////ReadSetting("Settings.json");
            //if (File.Exists(SettingFile))
            //{
            //    settings = JsonSerialization.ReadFromJsonFile<Settings>(SettingFile, "utf-8");
            //    SettingHelper.Settings Settings.GtargetExtension = settings.targetExtension;
            //    Settings.GIgnoreName = settings.IgnoreName;
            //    Global.Logger.WriteLine("Read end: " + SettingFile);
            //}
            //else
            //{
            //    settings = new Settings();
            //    Global.Logger.WriteLine(SettingFile + " Not Found");
            //    JsonSerialization.WriteToJsonFile<Settings>("111.json", settings);
            //}
        }

        //Defining all Control handler methods
        public void Initial()
        {
            grdViewModel = new List<GridEntryEntity>();
            grdChangesetVM = new List<GridChangesetEntryEntity>();
        }

        public void CheckAllChange()
        {
            grdViewModel.ForEach(x => x.Check = true);
        }
        public void CheckAllChangeSet()
        {
            grdChangesetVM.ForEach(x => x.Check = true);
        }
        public void InvertCheckChange()
        {
            grdViewModel.ForEach(x => x.Check = !x.Check);
        }
        public void InvertCheckChangeSet()
        {
            grdChangesetVM.ForEach(x => x.Check = !x.Check);
        }

        public void ClearGridChange()
        {
            grdViewModel.Clear();
        }
        public void ClearGridChangeset()
        {
            grdChangesetVM.Clear();
        }

        #region Action

        public void GetCsList()
        {
            Global.Logger.WriteLine("Changesets getting...");
            if (int.TryParse(WorkItem, out int WorkItemId))
            {
                var workInfo = TfsHelper.GetChangesetFromWorkItem(WorkItemId);
                var changesets = workInfo.Item2;
                changesets.Sort((x, y) => x.ChangesetId - y.ChangesetId);
                WorkItemName = workInfo.Item1.Title + "( PRJ:" + workInfo.Item1.AreaPath + ")";

                grdChangesetVM = changesets.Select(x => new GridChangesetEntryEntity
                {
                    Check = true,
                    ChangesetId = x.ChangesetId,
                    Comment = x.Comment,
                    CommitterDisplayName = x.CommitterDisplayName
                }).ToList();
            }
            else
            {
                throw new Exception("Number Plz!");
            }
        }
        public void GetChanges()
        {
            Global.Logger.WriteLine("Changes getting...");
            List<int> lsInputChangesetID = null;
            lsInputChangesetID = new List<int>();
            lsInputChangesetID = grdChangesetVM.Select(x => x.ChangesetId.Value).ToList();

            GetChanges(lsInputChangesetID);
        }

        public void GetChanges(IEnumerable<int> lsInputChangesetID)
        {
            //update grid Model
            var items = TfsHelper.GetInfo(lsInputChangesetID.OrderBy(x => x));
            items.ForEach(x => x.Check = true);
            items.Sort((x, y) => string.CompareOrdinal(x.DiffPath, y.DiffPath));
            grdViewModel = items;
        }
        public void Download(CountResquest Request)
        {
            Global.Logger.WriteLine("Downloading...");
            var downloadList = _Mapper.Map<IEnumerable<TfsGuildPathDownloadItem>>(grdViewModel.Where(x => x.Check));
            _Downloader.DownloadAsync(downloadList, Request.BaseFolder, Request.NewFolder);
        }
        public CountResult Count(CountResquest Request)
        {
            Global.Logger.WriteLine("Counting...");
            // todo : suck the interface
            var counter = (CountByClocCli)_LocCounter;
            var countRs = counter.RunCount(Request);
            return countRs;
        }

        public void GC()
        {
            CountResquest Request = CountResquestFactory.Create(Gui);
            GC(Request);
        }

        public void GC(CountResquest Request)
        {
            IOHelper.DeleteFolderIfExist(Request.BaseFolder);
            IOHelper.DeleteFolderIfExist(Request.NewFolder);
            IOHelper.DeleteFolderIfExist(Directory.GetParent(Request.NewFolder));
        }
        #endregion

        #region Notify
        protected virtual void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public event PropertyChangedEventHandler PropertyChanged;


        #endregion
    }
}
