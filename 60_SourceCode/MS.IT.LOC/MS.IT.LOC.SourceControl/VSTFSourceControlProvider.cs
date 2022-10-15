using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.VersionControl.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.Common;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.SourceControl
{
    // Token: 0x02000007 RID: 7
    public class VSTFSourceControlProvider : ISourceControlProvider
    {
        // Token: 0x0600003A RID: 58 RVA: 0x000066DC File Offset: 0x000056DC
        public bool Login(string ServerName, string serverPort, string LoginId, string Password)
        {
            string userName = string.Empty;
            string domain = string.Empty;
            NetworkCredential networkCredential;
            if (LoginId.IndexOf('\\') != -1)
            {
                domain = LoginId.Substring(0, LoginId.IndexOf('\\'));
                userName = LoginId.Substring(LoginId.IndexOf('\\') + 1);
                networkCredential = new NetworkCredential(userName, Password, domain);
            }
            else if (LoginId.Length > 0)
            {
                networkCredential = new NetworkCredential(LoginId, Password);
            }
            else
            {
                networkCredential = CredentialCache.DefaultNetworkCredentials;
            }
            if (serverPort != "")
            {
                VSTFSourceControlProvider.SERVER_NAME = "http://" + ServerName + ":" + serverPort;
            }
            else
            {
                VSTFSourceControlProvider.SERVER_NAME = "http://" + ServerName + ":8080";
            }
            bool result;
            try
            {
                VSTFSourceControlProvider.m_tfs = new TfsTeamProjectCollection(new Uri(SERVER_NAME), networkCredential);
                VSTFSourceControlProvider.m_vss = (VersionControlServer)VSTFSourceControlProvider.m_tfs.GetService(typeof(VersionControlServer));
                VSTFSourceControlProvider.m_vss.GetLatestChangesetId();
                VSTFSourceControlProvider.m_IsConnected = true;
                VSTFSourceControlProvider.m_serverName = ServerName;
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        // Token: 0x0600003B RID: 59 RVA: 0x00006800 File Offset: 0x00005800
        public SCItemSet GetChildItem(SCItem parent, bool recursive)
        {
            SCItemSet result;
            if (VSTFSourceControlProvider.m_IsConnected)
            {
                if (parent == null)
                {
                    result = this.GetTeamProjects();
                }
                else
                {
                    result = this.GetChildItems(parent, recursive);
                }
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x0600003C RID: 60 RVA: 0x00006844 File Offset: 0x00005844
        public bool InitFilesInChangesets(ArrayList aryChangeset)
        {
            if (VSTFSourceControlProvider.m_FilesInWorkItem.Count > 0 || VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem.Count > 0)
            {
                VSTFSourceControlProvider.m_FilesInWorkItem.Clear();
                VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem.Clear();
            }
            bool result;
            if (aryChangeset == null)
            {
                result = false;
            }
            else
            {
                for (int i = 0; i < aryChangeset.Count; i++)
                {
                    try
                    {
                        if (aryChangeset[i] != null)
                        {
                            Changeset changeset = VSTFSourceControlProvider.m_vss.GetChangeset(Convert.ToInt32(aryChangeset[i]));
                            foreach (Change change in changeset.Changes)
                            {
                                Item item = change.Item;
                                // TODO NOVI . implecit
                                //if (item.ItemType == 2)
                                if (item.ItemType == ItemType.File)
                                {
                                    if (!VSTFSourceControlProvider.m_FilesInWorkItem.Contains(item.ServerItem))
                                    {
                                        VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = new VSTFSourceControlProvider.FileWithChangesets();
                                        fileWithChangesets.BaseChangset = aryChangeset[i].ToString();
                                        fileWithChangesets.FilePath = item.ServerItem;
                                        VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem.Add(fileWithChangesets);
                                        VSTFSourceControlProvider.m_FilesInWorkItem.Add(item.ServerItem);
                                    }
                                    else
                                    {
                                        for (int k = 0; k < VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem.Count; k++)
                                        {
                                            VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem[k];
                                            if (fileWithChangesets.FilePath == item.ServerItem && Convert.ToInt32(fileWithChangesets.BaseChangset) < item.ChangesetId)
                                            {
                                                fileWithChangesets.BaseChangset = item.ChangesetId.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                VSTFSourceControlProvider.m_FilesInWorkItem.Sort();
                VSTFSourceControlProvider.m_CurrentInitTag = VSTFSourceControlProvider.SERVER_NAME + "$WorkItemInit$" + VSTFSourceControlProvider.m_WorkItem;
                result = true;
            }
            return result;
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00006A78 File Offset: 0x00005A78
        private bool IsChangesetDiff(string baseVersion, string diffVersion)
        {
            return (!(baseVersion != string.Empty) || this.regNumber.IsMatch(baseVersion)) && (!(diffVersion != string.Empty) || this.regNumber.IsMatch(diffVersion));
        }

        // Token: 0x0600003E RID: 62 RVA: 0x00006AD8 File Offset: 0x00005AD8
        public bool InitFilesInLabels()
        {
            if (VSTFSourceControlProvider.m_FilesInLabels.Count > 0 || VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Count > 0)
            {
                VSTFSourceControlProvider.m_FilesInLabels.Clear();
                VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Clear();
            }
            try
            {
                if (VSTFSourceControlProvider.m_BaseLabel.Length > 0)
                {
                    VersionControlLabel[] array = VSTFSourceControlProvider.m_vss.QueryLabels(VSTFSourceControlProvider.m_BaseLabel, "$/", null, true);
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Items.Length; j++)
                        {
                            if (array[i].Items[j].ItemType == ItemType.File)
                            {
                                if (VSTFSourceControlProvider.m_FilesInLabels.Contains(array[i].Items[j].ServerItem))
                                {
                                    for (int k = 0; k < VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Count; k++)
                                    {
                                        VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)VSTFSourceControlProvider.m_clsFilesChangesetInLabels[k];
                                        if (fileWithChangesets.FilePath == array[i].Items[j].ServerItem)
                                        {
                                            if (Convert.ToInt64(array[i].Items[j].ChangesetId) > Convert.ToInt64(fileWithChangesets.BaseChangset))
                                            {
                                                fileWithChangesets.BaseChangset = array[i].Items[j].ChangesetId.ToString();
                                            }
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    VSTFSourceControlProvider.m_FilesInLabels.Add(array[i].Items[j].ServerItem);
                                    VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = new VSTFSourceControlProvider.FileWithChangesets();
                                    fileWithChangesets.FilePath = array[i].Items[j].ServerItem;
                                    fileWithChangesets.BaseChangset = array[i].Items[j].ChangesetId.ToString();
                                    VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Add(fileWithChangesets);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                if (VSTFSourceControlProvider.m_DiffLabel.Length > 0)
                {
                    VersionControlLabel[] array = VSTFSourceControlProvider.m_vss.QueryLabels(VSTFSourceControlProvider.m_DiffLabel, "$/", null, true);
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Items.Length; j++)
                        {
                            if (array[i].Items[j].ItemType == ItemType.File)
                            {
                                if (VSTFSourceControlProvider.m_FilesInLabels.Contains(array[i].Items[j].ServerItem))
                                {
                                    for (int k = 0; k < VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Count; k++)
                                    {
                                        VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)VSTFSourceControlProvider.m_clsFilesChangesetInLabels[k];
                                        if (fileWithChangesets.FilePath == array[i].Items[j].ServerItem)
                                        {
                                            if (fileWithChangesets.DiffChangeset == string.Empty || Convert.ToInt64(array[i].Items[j].ChangesetId) > Convert.ToInt64(fileWithChangesets.DiffChangeset))
                                            {
                                                fileWithChangesets.DiffChangeset = array[i].Items[j].ChangesetId.ToString();
                                            }
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    VSTFSourceControlProvider.m_FilesInLabels.Add(array[i].Items[j].ServerItem);
                                    VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = new VSTFSourceControlProvider.FileWithChangesets();
                                    fileWithChangesets.FilePath = array[i].Items[j].ServerItem;
                                    fileWithChangesets.DiffChangeset = array[i].Items[j].ChangesetId.ToString();
                                    VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Add(fileWithChangesets);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            VSTFSourceControlProvider.m_FilesInLabels.Sort();
            VSTFSourceControlProvider.m_CurrentInitTag = string.Concat(new string[]
            {
                VSTFSourceControlProvider.SERVER_NAME,
                "$LabelsInit$",
                VSTFSourceControlProvider.m_BaseLabel,
                "$",
                VSTFSourceControlProvider.m_DiffLabel
            });
            return true;
        }

        // Token: 0x0600003F RID: 63 RVA: 0x00006F64 File Offset: 0x00005F64
        public bool InitFilesInChangeset()
        {
            if (VSTFSourceControlProvider.m_FilesInChangeset.Count > 0)
            {
                VSTFSourceControlProvider.m_FilesInChangeset.Clear();
            }
            try
            {
                if (VSTFSourceControlProvider.m_BaseChangeset.Length > 0)
                {
                    Changeset changeset = VSTFSourceControlProvider.m_vss.GetChangeset(int.Parse(VSTFSourceControlProvider.m_BaseChangeset));
                    foreach (Change change in changeset.Changes)
                    {
                        Item item = change.Item;
                        if (item.ItemType == ItemType.File)
                        {
                            if (!VSTFSourceControlProvider.m_FilesInChangeset.Contains(item.ServerItem))
                            {
                                VSTFSourceControlProvider.m_FilesInChangeset.Add(item.ServerItem);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                if (VSTFSourceControlProvider.m_DiffChangeset.Length > 0)
                {
                    Changeset changeset = VSTFSourceControlProvider.m_vss.GetChangeset(int.Parse(VSTFSourceControlProvider.m_DiffChangeset));
                    foreach (Change change in changeset.Changes)
                    {
                        Item item = change.Item;
                        if (item.ItemType == ItemType.File)
                        {
                            if (!VSTFSourceControlProvider.m_FilesInChangeset.Contains(item.ServerItem))
                            {
                                VSTFSourceControlProvider.m_FilesInChangeset.Add(item.ServerItem);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            VSTFSourceControlProvider.m_FilesInChangeset.Sort();
            VSTFSourceControlProvider.m_CurrentInitTag = string.Concat(new string[]
            {
                VSTFSourceControlProvider.SERVER_NAME,
                "$ChangeSetInit$",
                VSTFSourceControlProvider.m_BaseChangeset,
                "$",
                VSTFSourceControlProvider.m_DiffChangeset
            });
            return true;
        }

        // Token: 0x06000040 RID: 64 RVA: 0x0000714C File Offset: 0x0000614C
        public SCItemSet GetItemsInPath(int setType, string parentPath)
        {
            SCItemSet scitemSet = new SCItemSet();
            string a = "";
            SCItemSet result;
            if (parentPath.Length < 1)
            {
                result = scitemSet;
            }
            else
            {
                if (parentPath.LastIndexOf('/') != parentPath.Length - 1)
                {
                    parentPath += "/";
                }
                int length = parentPath.Length;
                ArrayList arrayList;
                if (this.m_FileTypeInSet == VSTFSourceControlProvider.SetType.ChangeSet)
                {
                    arrayList = VSTFSourceControlProvider.m_FilesInChangeset;
                }
                else if (this.m_FileTypeInSet == VSTFSourceControlProvider.SetType.WorkItem)
                {
                    arrayList = VSTFSourceControlProvider.m_FilesInWorkItem;
                }
                else if (this.m_FileTypeInSet == VSTFSourceControlProvider.SetType.Label)
                {
                    arrayList = VSTFSourceControlProvider.m_FilesInLabels;
                }
                else
                {
                    arrayList = new ArrayList();
                }
                for (int i = 0; i < arrayList.Count; i++)
                {
                    string text = arrayList[i].ToString();
                    if (text.Length > parentPath.Length)
                    {
                        if (!(text.Substring(0, parentPath.Length) != parentPath))
                        {
                            int num = 0;
                            int num2;
                            do
                            {
                                num2 = text.IndexOf('/', length + num);
                                if (num2 == -1)
                                {
                                    break;
                                }
                                num++;
                            }
                            while (num2 - length <= num);
                        IL_147:
                            if (num2 == -1)
                            {
                                if (a != text)
                                {
                                    scitemSet.Add(new SCItem
                                    {
                                        Path = text,
                                        Name = Helper.GetName(text),
                                        ScType = SCItemType.FILE
                                    });
                                    a = text;
                                }
                            }
                            else if (a != text.Substring(0, num2))
                            {
                                scitemSet.Add(new SCItem
                                {
                                    Path = text.Substring(0, num2),
                                    Name = Helper.GetName(text.Substring(0, num2)),
                                    ScType = SCItemType.FOLDER
                                });
                                a = text.Substring(0, num2);
                            }
                            goto IL_203;
                            goto IL_147;
                        }
                    }
                IL_203:;
                }
                result = scitemSet;
            }
            return result;
        }

        // Token: 0x06000041 RID: 65 RVA: 0x00007380 File Offset: 0x00006380
        public SCItemSet GetAllFilesInPath(string parentPath)
        {
            SCItemSet scitemSet = new SCItemSet();
            ArrayList arrayList;
            switch (this.m_FileTypeInSet)
            {
                case VSTFSourceControlProvider.SetType.ChangeSet:
                    arrayList = VSTFSourceControlProvider.m_FilesInChangeset;
                    break;
                case VSTFSourceControlProvider.SetType.WorkItem:
                    arrayList = VSTFSourceControlProvider.m_FilesInWorkItem;
                    break;
                case VSTFSourceControlProvider.SetType.Label:
                    arrayList = VSTFSourceControlProvider.m_FilesInLabels;
                    break;
                default:
                    throw new Exception("Error, in GetAllFilesInPath");
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                string text = arrayList[i].ToString();
                if (!(text.Substring(0, parentPath.Length) != parentPath))
                {
                    scitemSet.Add(new SCItem
                    {
                        Path = text,
                        Name = Helper.GetName(text),
                        ScType = SCItemType.FILE
                    });
                }
            }
            return scitemSet;
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00007458 File Offset: 0x00006458
        public SCItemSet GetTeamProjectsInSet(int setType, ArrayList aryChangset)
        {
            switch (this.m_FileTypeInSet)
            {
                case VSTFSourceControlProvider.SetType.ChangeSet:
                    if (VSTFSourceControlProvider.m_FilesInChangeset.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.WorkItem:
                    if (VSTFSourceControlProvider.m_FilesInWorkItem.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.Label:
                    if (VSTFSourceControlProvider.m_FilesInLabels.Count < 1)
                    {
                        return null;
                    }
                    break;
            }
            return this.GetItemsInPath(setType, "$");
        }

        // Token: 0x06000043 RID: 67 RVA: 0x000074E4 File Offset: 0x000064E4
        public SCItemSet GetTeamProjectsInSet(int setType, string baseChangeset, string diffChangeset)
        {
            switch (this.m_FileTypeInSet)
            {
                case VSTFSourceControlProvider.SetType.ChangeSet:
                    if (VSTFSourceControlProvider.m_FilesInChangeset.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.WorkItem:
                    if (VSTFSourceControlProvider.m_FilesInWorkItem.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.Label:
                    if (VSTFSourceControlProvider.m_FilesInLabels.Count < 1)
                    {
                        return null;
                    }
                    break;
                default:
                    throw new Exception("Error, in GetTeamProjectsInSet");
            }
            return this.GetItemsInPath(0, "$");
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00007578 File Offset: 0x00006578
        public SCItemSet GetChildItemsInSet(SCItem parent, bool recursive, ArrayList aryChangset)
        {
            SCItemSet result;
            try
            {
                if (recursive)
                {
                    result = this.GetAllFilesInPath(parent.Path);
                }
                else
                {
                    result = this.GetItemsInPath(1, parent.Path);
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000045 RID: 69 RVA: 0x000075C8 File Offset: 0x000065C8
        public SCItemSet GetChildItemsInSet(SCItem parent, bool recursive, string baseChangeset, string diffChangeset)
        {
            switch (this.m_FileTypeInSet)
            {
                case VSTFSourceControlProvider.SetType.ChangeSet:
                    if (VSTFSourceControlProvider.m_FilesInChangeset.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.WorkItem:
                    if (VSTFSourceControlProvider.m_FilesInWorkItem.Count < 1)
                    {
                        return null;
                    }
                    break;
                case VSTFSourceControlProvider.SetType.Label:
                    if (VSTFSourceControlProvider.m_FilesInLabels.Count < 1)
                    {
                        return null;
                    }
                    break;
                default:
                    throw new Exception("Error, in GetTeamProjectsInSet");
            }
            SCItemSet result;
            try
            {
                if (recursive)
                {
                    result = this.GetAllFilesInPath(parent.Path);
                }
                else
                {
                    result = this.GetItemsInPath(0, parent.Path);
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000046 RID: 70 RVA: 0x0000768C File Offset: 0x0000668C
        public SCItemSet GetChildItemInSet(SCItem parent, bool recursive, int setType, string[] versions)
        {
            SCItemSet result;
            if (setType == 0)
            {
                string text = "";
                string text2 = "";
                if (versions.Length > 0)
                {
                    text = versions[0];
                }
                if (versions.Length > 1)
                {
                    text2 = versions[1];
                }
                bool flag = this.IsChangesetDiff(text, text2);
                if (flag)
                {
                    this.m_FileTypeInSet = VSTFSourceControlProvider.SetType.ChangeSet;
                    if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                    {
                        VSTFSourceControlProvider.SERVER_NAME,
                        "$ChangeSetInit$",
                        text,
                        "$",
                        text2
                    }))
                    {
                        VSTFSourceControlProvider.m_BaseChangeset = text;
                        VSTFSourceControlProvider.m_DiffChangeset = text2;
                        this.InitFilesInChangeset();
                    }
                }
                else
                {
                    this.m_FileTypeInSet = VSTFSourceControlProvider.SetType.Label;
                    if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                    {
                        VSTFSourceControlProvider.SERVER_NAME,
                        "$LabelsInit$",
                        text,
                        "$",
                        text2
                    }))
                    {
                        VSTFSourceControlProvider.m_BaseLabel = text;
                        VSTFSourceControlProvider.m_DiffLabel = text2;
                        this.InitFilesInLabels();
                    }
                }
                if (flag)
                {
                    if (parent == null)
                    {
                        result = this.GetTeamProjectsInSet(setType, text, text2);
                    }
                    else
                    {
                        result = this.GetChildItemsInSet(parent, recursive, text, text2);
                    }
                }
                else if (parent == null)
                {
                    result = this.GetTeamProjectsInSet(setType, text, text2);
                }
                else
                {
                    result = this.GetChildItemsInSet(parent, recursive, text, text2);
                }
            }
            else
            {
                this.m_FileTypeInSet = VSTFSourceControlProvider.SetType.WorkItem;
                string text3 = versions[0];
                if (VSTFSourceControlProvider.m_CurrentInitTag != VSTFSourceControlProvider.SERVER_NAME + "$WorkItemInit$" + text3)
                {
                    VSTFSourceControlProvider.m_WorkItem = text3;
                    ArrayList changesetsFromWorkItem = this.getChangesetsFromWorkItem(VSTFSourceControlProvider.m_WorkItem);
                    this.InitFilesInChangesets(changesetsFromWorkItem);
                }
                if (parent == null)
                {
                    result = this.GetTeamProjectsInSet(setType, null);
                }
                else
                {
                    result = this.GetChildItemsInSet(parent, recursive, null);
                }
            }
            return result;
        }

        // Token: 0x06000047 RID: 71 RVA: 0x000078A0 File Offset: 0x000068A0
        public bool Download(string serverPath, string localFile)
        {
            bool result;
            try
            {
                VSTFSourceControlProvider.m_vss.DownloadFile(serverPath, localFile);
                Helper.CreateUnicodeFile(serverPath);
                if (File.Exists(localFile))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000048 RID: 72 RVA: 0x000078F4 File Offset: 0x000068F4
        public bool DownloadDiff(string serverPath, string localFile, object startVersionSpec, object endVersionSpec)
        {
            DiffOptions diffOptions = new DiffOptions();
            diffOptions.UseThirdPartyTool = false;
            diffOptions.OutputType = DiffOutputType.UnixNormal;
            diffOptions.SourceEncoding = new UnicodeEncoding();
            diffOptions.TargetEncoding = new UnicodeEncoding();
            lock (this.m_objSingleThread)
            {
                try
                {
                    DiffSegment diffSegment = Difference.DiffFiles(serverPath, Encoding.Unicode.CodePage, localFile, Encoding.Unicode.CodePage, diffOptions);
                    DiffSegment diffSegment2 = diffSegment;
                    DiffSegment diffSegment3 = null;
                    DiffSegment diffSegment4 = null;
                    int num = 0;
                    int num2 = 0;
                    while (diffSegment2 != null)
                    {
                        DiffSegment next = diffSegment2.Next;
                        if (next != null)
                        {
                            DiffSegment diffSegment5 = new DiffSegment();
                            diffSegment5.Type = DiffSegmentType.Modified;
                            diffSegment5.OriginalStart = diffSegment2.OriginalStart + diffSegment2.OriginalLength;
                            diffSegment5.ModifiedStart = diffSegment2.ModifiedStart + diffSegment2.ModifiedLength;
                            diffSegment5.OriginalLength = next.OriginalStart - diffSegment5.OriginalStart;
                            diffSegment5.ModifiedLength = next.ModifiedStart - diffSegment5.ModifiedStart;
                            diffSegment5.OriginalStartOffset = diffSegment2.OriginalStartOffset + diffSegment2.OriginalByteLength;
                            diffSegment5.ModifiedStartOffset = diffSegment2.ModifiedStartOffset + diffSegment2.ModifiedByteLength;
                            diffSegment5.OriginalByteLength = next.OriginalStartOffset - diffSegment5.OriginalStartOffset;
                            diffSegment5.ModifiedByteLength = next.ModifiedStartOffset - diffSegment5.ModifiedStartOffset;
                            if (diffSegment5.OriginalByteLength == 0L && diffSegment5.ModifiedByteLength == 0L)
                            {
                                diffSegment2 = next;
                                continue;
                            }
                            if (diffSegment3 == null)
                            {
                                diffSegment3 = diffSegment5;
                                diffSegment4 = diffSegment5;
                            }
                            else
                            {
                                diffSegment4.Next = diffSegment5;
                                diffSegment4 = diffSegment5;
                            }
                        }
                        diffSegment2 = next;
                    }
                    DiffSegment diffSegment6 = diffSegment3;
                    StreamWriter streamWriter = new StreamWriter(localFile + ".diff", false, Encoding.Unicode);
                    streamWriter.WriteLine("Compare Result");
                    streamWriter.WriteLine("===================================================================");
                    int num3 = -1;
                    DiffSegment diffSegment7 = null;
                    DiffSegment diffSegment8 = diffSegment6;
                    while (diffSegment6 != null)
                    {
                        if (diffSegment6.OriginalStart == num3)
                        {
                            diffSegment7.OriginalLength += diffSegment6.OriginalLength;
                            diffSegment7.OriginalByteLength += diffSegment6.OriginalByteLength;
                            diffSegment7.ModifiedLength += diffSegment6.ModifiedLength;
                            diffSegment7.ModifiedByteLength += diffSegment6.ModifiedByteLength;
                            diffSegment7.LatestLength += diffSegment6.LatestLength;
                            diffSegment7.LatestByteLength += diffSegment6.LatestByteLength;
                            diffSegment6 = diffSegment6.Next;
                            diffSegment7.Next = diffSegment6;
                        }
                        else
                        {
                            num3 = diffSegment6.OriginalStart;
                            diffSegment7 = diffSegment6;
                            diffSegment6 = diffSegment6.Next;
                        }
                    }
                    for (diffSegment6 = diffSegment8; diffSegment6 != null; diffSegment6 = diffSegment6.Next)
                    {
                        if (diffSegment6.OriginalLength > 0)
                        {
                            streamWriter.Write((diffSegment6.OriginalStart + 1).ToString());
                        }
                        else
                        {
                            streamWriter.Write(diffSegment6.OriginalStart.ToString());
                        }
                        if (diffSegment6.OriginalLength > 1)
                        {
                            streamWriter.Write(",");
                            streamWriter.Write((diffSegment6.OriginalStart + diffSegment6.OriginalLength).ToString());
                        }
                        if (diffSegment6.OriginalLength == 0)
                        {
                            streamWriter.Write("a");
                            num += diffSegment6.ModifiedLength;
                        }
                        else if (diffSegment6.ModifiedLength == 0)
                        {
                            streamWriter.Write("d");
                            num2 += diffSegment6.OriginalLength;
                        }
                        else
                        {
                            streamWriter.Write("c");
                        }
                        if (diffSegment6.ModifiedLength > 0)
                        {
                            streamWriter.Write((diffSegment6.ModifiedStart + 1).ToString());
                        }
                        else
                        {
                            streamWriter.Write(diffSegment6.ModifiedStart.ToString());
                        }
                        if (diffSegment6.ModifiedLength > 1)
                        {
                            streamWriter.Write(",");
                            streamWriter.Write((diffSegment6.ModifiedStart + diffSegment6.ModifiedLength).ToString());
                        }
                        streamWriter.WriteLine();
                        StreamReader streamReader = new StreamReader(serverPath, Encoding.Unicode);
                        streamReader.BaseStream.Seek(diffSegment6.OriginalStartOffset, SeekOrigin.Begin);
                        for (int i = 0; i < diffSegment6.OriginalLength; i++)
                        {
                            streamWriter.WriteLine("< " + streamReader.ReadLine());
                        }
                        if (streamReader.ReadLine() == null)
                        {
                            streamWriter.WriteLine("\\ No newline at end of file");
                        }
                        streamReader.Close();
                        streamReader.Dispose();
                        if (diffSegment6.ModifiedLength > 0 && diffSegment6.OriginalLength > 0)
                        {
                            streamWriter.WriteLine("---");
                        }
                        StreamReader streamReader2 = new StreamReader(localFile, Encoding.Unicode);
                        streamReader2.BaseStream.Seek(diffSegment6.ModifiedStartOffset, SeekOrigin.Begin);
                        for (int i = 0; i < diffSegment6.ModifiedLength; i++)
                        {
                            streamWriter.WriteLine("> " + streamReader2.ReadLine());
                        }
                        if (streamReader2.ReadLine() == null)
                        {
                            streamWriter.WriteLine("\\ No newline at end of file");
                        }
                        streamReader2.Close();
                        streamReader2.Dispose();
                    }
                    if (diffSegment3 != null && diffSegment3.Next == null)
                    {
                        int num4 = diffSegment3.ModifiedLength;
                    }
                    else if (diffSegment3 != null)
                    {
                        int num4 = diffSegment3.ModifiedStart;
                    }
                    streamWriter.WriteLine("===================================================================");
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00007F84 File Offset: 0x00006F84
        public bool Download(string serverPath, string localFile, object versionSpec)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(versionSpec.ToString()))
            {
                try
                {
                    VersionSpec versionSpec2 = VersionSpec.ParseSingleSpec(versionSpec.ToString(), VSTFSourceControlProvider.m_vss.AuthorizedUser);
                    int itemId = VSTFSourceControlProvider.m_vss.GetItem(serverPath, versionSpec2).ItemId;
                    Item item = VSTFSourceControlProvider.m_vss.GetItem(itemId, int.Parse(versionSpec.ToString().Substring(1)), true);
                    item.DownloadFile(localFile);
                    Helper.CreateUnicodeFile(localFile);
                }
                catch (Exception)
                {
                    try
                    {
                        VersionSpec versionSpec2 = VersionSpec.ParseSingleSpec(versionSpec.ToString(), VSTFSourceControlProvider.m_vss.AuthorizedUser);
                        int itemId = VSTFSourceControlProvider.m_vss.GetItem(serverPath, VersionSpec.Latest).ItemId;
                        Item item = VSTFSourceControlProvider.m_vss.GetItem(itemId, int.Parse(versionSpec.ToString().Substring(1)), true);
                        item.DownloadFile(localFile);
                        Helper.CreateUnicodeFile(localFile);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                result = true;
            }
            return result;
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00008094 File Offset: 0x00007094
        public ArrayList GetFirstAndLastVersionSpec(string serverPath, string baseSet, string lastSet)
        {
            ArrayList arrayList = new ArrayList();
            ArrayList result;
            if (!this.IsChangesetDiff(baseSet, lastSet))
            {
                this.m_FileTypeInSet = VSTFSourceControlProvider.SetType.Label;
                if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                {
                    VSTFSourceControlProvider.SERVER_NAME,
                    "$LabelsInit$",
                    baseSet,
                    "$",
                    lastSet
                }))
                {
                    lock (this.m_objSingleThread)
                    {
                        if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                        {
                            VSTFSourceControlProvider.SERVER_NAME,
                            "$LabelsInit$",
                            baseSet,
                            "$",
                            lastSet
                        }))
                        {
                            VSTFSourceControlProvider.m_BaseLabel = baseSet;
                            VSTFSourceControlProvider.m_DiffLabel = lastSet;
                            this.InitFilesInLabels();
                        }
                    }
                }
                for (int i = 0; i < VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Count; i++)
                {
                    VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)VSTFSourceControlProvider.m_clsFilesChangesetInLabels[i];
                    if (fileWithChangesets.FilePath == serverPath)
                    {
                        if (fileWithChangesets.BaseChangset != string.Empty)
                        {
                            arrayList.Add("C" + fileWithChangesets.BaseChangset);
                        }
                        else
                        {
                            arrayList.Add("");
                        }
                        if (fileWithChangesets.DiffChangeset != string.Empty)
                        {
                            arrayList.Add("C" + fileWithChangesets.DiffChangeset);
                        }
                        else
                        {
                            arrayList.Add("");
                        }
                        break;
                    }
                }
                result = arrayList;
            }
            else
            {
                VersionSpec latest = VersionSpec.Latest;
                VersionSpec versionSpec = VersionSpec.Parse("C1", null)[0];
                string text = "";
                string text2 = "";
                try
                {
                    IEnumerable enumerable = VSTFSourceControlProvider.m_vss.QueryHistory(serverPath, VersionSpec.Latest, 0, 0, null, versionSpec, latest, int.MaxValue, true, false, true);
                    foreach (object obj in enumerable)
                    {
                        Changeset changeset = (Changeset)obj;
                        if (changeset.ChangesetId.ToString().Trim() == baseSet)
                        {
                            text = baseSet;
                        }
                        if (changeset.ChangesetId.ToString().Trim() == lastSet)
                        {
                            text2 = lastSet;
                        }
                    }
                }
                catch (Exception)
                {
                }
                if (text != "")
                {
                    arrayList.Add("C" + text);
                }
                else
                {
                    arrayList.Add("");
                }
                if (text2 != "")
                {
                    arrayList.Add("C" + text2);
                }
                else
                {
                    arrayList.Add("");
                }
                result = arrayList;
            }
            return result;
        }

        // Token: 0x0600004B RID: 75 RVA: 0x000083DC File Offset: 0x000073DC
        public ArrayList GetFirstAndLastVersionSpec(string serverPath, DateTime startDate, DateTime endDate)
        {
            ArrayList arrayList = new ArrayList();
            VersionSpec versionSpec = VersionSpec.Parse("D" + endDate.ToShortDateString() + " 11:59:59 PM", null)[0];
            VersionSpec versionSpec2 = VersionSpec.Parse("D01/01/1754 12:00:00 AM", null)[0];
            bool flag = true;
            string text = "C";
            string text2 = "C";
            try
            {
                IEnumerable enumerable = VSTFSourceControlProvider.m_vss.QueryHistory(serverPath, VersionSpec.Latest, 0, 0, null, versionSpec2, versionSpec, int.MaxValue, true, false, true);
                startDate = DateTime.Parse(startDate.ToShortDateString());
                foreach (object obj in enumerable)
                {
                    Changeset changeset = (Changeset)obj;
                    if (flag)
                    {
                        if (changeset.CreationDate >= startDate)
                        {
                            text2 = "C" + changeset.ChangesetId.ToString().Trim();
                        }
                        flag = false;
                    }
                    if (changeset.CreationDate < startDate)
                    {
                        text = "C" + changeset.ChangesetId.ToString().Trim();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            if (text == "C")
            {
                arrayList.Add("");
            }
            else
            {
                arrayList.Add(text);
            }
            if (text2 == "C")
            {
                arrayList.Add("");
            }
            else
            {
                arrayList.Add(text2);
            }
            return arrayList;
        }

        // Token: 0x0600004C RID: 76 RVA: 0x000085D0 File Offset: 0x000075D0
        public ArrayList GetFirstAndLastVersionSpec(string serverPath, int setType, string versionSetParam)
        {
            string text = versionSetParam;
            ArrayList arrayList = new ArrayList();
            VersionSpec latest = VersionSpec.Latest;
            VersionSpec versionSpec = VersionSpec.Parse("C1", null)[0];
            bool flag = true;
            string text2 = "C";
            string text3 = "C";
            if (setType == 1)
            {
                if (VSTFSourceControlProvider.m_CurrentInitTag != VSTFSourceControlProvider.SERVER_NAME + "$WorkItemInit$" + text)
                {
                    lock (this.m_objSingleThread)
                    {
                        if (VSTFSourceControlProvider.m_CurrentInitTag != VSTFSourceControlProvider.SERVER_NAME + "$WorkItemInit$" + text)
                        {
                            VSTFSourceControlProvider.m_WorkItem = text;
                            ArrayList changesetsFromWorkItem = this.getChangesetsFromWorkItem(VSTFSourceControlProvider.m_WorkItem);
                            this.InitFilesInChangesets(changesetsFromWorkItem);
                        }
                    }
                }
                try
                {
                    text2 = "C" + this.getChangesetIDFromPath(serverPath);
                    if (text2 == "C")
                    {
                        arrayList.Add("");
                    }
                    else
                    {
                        arrayList.Add(text2);
                    }
                    if (text3 == "C")
                    {
                        arrayList.Add("");
                    }
                    else
                    {
                        arrayList.Add(text3);
                    }
                    return arrayList;
                }
                catch (Exception)
                {
                    return arrayList;
                }
            }
            string empty = string.Empty;
            string text4 = text;
            if (!this.IsChangesetDiff(empty, text4))
            {
                this.m_FileTypeInSet = VSTFSourceControlProvider.SetType.Label;
                if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                {
                    VSTFSourceControlProvider.SERVER_NAME,
                    "$LabelsInit$",
                    empty,
                    "$",
                    text4
                }))
                {
                    lock (this.m_objSingleThread)
                    {
                        if (VSTFSourceControlProvider.m_CurrentInitTag != string.Concat(new string[]
                        {
                            VSTFSourceControlProvider.SERVER_NAME,
                            "$LabelsInit$",
                            empty,
                            "$",
                            text4
                        }))
                        {
                            VSTFSourceControlProvider.m_BaseLabel = empty;
                            VSTFSourceControlProvider.m_DiffLabel = text4;
                            this.InitFilesInLabels();
                        }
                    }
                }
                for (int i = 0; i < VSTFSourceControlProvider.m_clsFilesChangesetInLabels.Count; i++)
                {
                    VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)VSTFSourceControlProvider.m_clsFilesChangesetInLabels[i];
                    if (fileWithChangesets.FilePath == serverPath)
                    {
                        if (fileWithChangesets.BaseChangset != "")
                        {
                            text = fileWithChangesets.BaseChangset;
                        }
                        if (fileWithChangesets.DiffChangeset != "")
                        {
                            text = fileWithChangesets.DiffChangeset;
                        }
                        break;
                    }
                }
            }
            try
            {
                IEnumerable enumerable = VSTFSourceControlProvider.m_vss.QueryHistory(serverPath, VersionSpec.Latest, 0, 0, null, versionSpec, latest, int.MaxValue, true, false, true);
                foreach (object obj in enumerable)
                {
                    Changeset changeset = (Changeset)obj;
                    if (flag && changeset.ChangesetId.ToString() == text)
                    {
                        text3 = "C" + text;
                        flag = false;
                    }
                    else if (!flag)
                    {
                        text2 = "C" + changeset.ChangesetId.ToString().Trim();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            if (text2 == "C")
            {
                arrayList.Add("");
            }
            else
            {
                arrayList.Add(text2);
            }
            if (text3 == "C")
            {
                arrayList.Add("");
            }
            else
            {
                arrayList.Add(text3);
            }
            return arrayList;
        }

        // Token: 0x0600004D RID: 77 RVA: 0x00008A3C File Offset: 0x00007A3C
        public object GetVersionSpec(DateTime date, bool latest)
        {
            VersionSpec[] array;
            if (latest)
            {
                array = VersionSpec.Parse("D" + date.ToShortDateString() + " 11:59:59 PM", null);
            }
            else
            {
                array = VersionSpec.Parse("D" + date.AddDays(-1.0).ToShortDateString() + " 11:59:59 PM", null);
            }
            object result;
            if (array.Length > 0)
            {
                result = array[array.Length - 1];
            }
            else
            {
                result = null;
            }
            return result;
        }

        // Token: 0x0600004E RID: 78 RVA: 0x00008AC4 File Offset: 0x00007AC4
        private SCItemSet GetTeamProjects()
        {
            SCItemSet result;
            try
            {
                TeamProject[] allTeamProjects = VSTFSourceControlProvider.m_vss.GetAllTeamProjects(true);
                SCItemSet scitemSet = new SCItemSet();
                for (int i = 0; i < allTeamProjects.Length; i++)
                {
                    scitemSet.Add(new SCItem
                    {
                        Path = allTeamProjects[i].ServerItem,
                        Name = Helper.GetName(allTeamProjects[i].ServerItem),
                        ScType = SCItemType.FOLDER
                    });
                }
                result = scitemSet;
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        // Token: 0x0600004F RID: 79 RVA: 0x00008B54 File Offset: 0x00007B54
        private SCItemSet GetChildItems(SCItem parent, bool recursive)
        {
            SCItemSet result;
            try
            {
                ItemSet items = VSTFSourceControlProvider.m_vss.GetItems(parent.Path, recursive ? RecursionType.Full  : RecursionType.OneLevel );
                SCItemSet scitemSet = new SCItemSet();
                foreach (Item item in items.Items)
                {
                    SCItem scitem = new SCItem();
                    if (item.ItemType == ItemType.Folder)
                    {
                        scitem.ScType = SCItemType.FOLDER;
                    }
                    else
                    {
                        scitem.ScType = SCItemType.FILE;
                    }
                    scitem.Name = Helper.GetName(item.ServerItem);
                    scitem.Path = item.ServerItem;
                    scitemSet.Add(scitem);
                }
                scitemSet.Remove(scitemSet[0]);
                result = scitemSet;
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000050 RID: 80 RVA: 0x00008C30 File Offset: 0x00007C30
        public ArrayList getChangesetsFromWorkItem(string BaseItem)
        {
            ArrayList arrayList = new ArrayList();
            int num = Convert.ToInt32(BaseItem);
            WorkItemStore workItemStore = (WorkItemStore)VSTFSourceControlProvider.m_tfs.GetService(typeof(WorkItemStore));
            WorkItem workItem;
            try
            {
                workItem = workItemStore.GetWorkItem(num);
            }
            catch
            {
                return null;
            }
            LinkCollection links = workItem.Links;
            foreach (object obj in links)
            {
                Link link = (Link)obj;
                if (link.BaseType == BaseLinkType.ExternalLink)
                {
                    ExternalLink externalLink = link as ExternalLink;
                    if (externalLink != null)
                    {
                        ArtifactId artifactId = LinkingUtilities.DecodeUri(externalLink.LinkedArtifactUri);
                        if (string.Equals(artifactId.ArtifactType, "Changeset", StringComparison.Ordinal))
                        {
                            string toolSpecificId = artifactId.ToolSpecificId;
                            arrayList.Add(toolSpecificId);
                        }
                    }
                }
            }
            return arrayList;
        }

        // Token: 0x06000051 RID: 81 RVA: 0x00008D5C File Offset: 0x00007D5C
        private string getChangesetIDFromPath(string filePath)
        {
            ArrayList arrayList = new ArrayList();
            arrayList = VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem;
            for (int i = 0; i < arrayList.Count; i++)
            {
                VSTFSourceControlProvider.FileWithChangesets fileWithChangesets = (VSTFSourceControlProvider.FileWithChangesets)arrayList[i];
                if (fileWithChangesets.FilePath == filePath)
                {
                    return fileWithChangesets.BaseChangset;
                }
            }
            return "";
        }

        // Token: 0x06000052 RID: 82 RVA: 0x00008DC4 File Offset: 0x00007DC4
        public MRepotItem GetItemChurnCount(string serverPath, string baseVersion, string diffVersion, DateTime startDate, DateTime endDate)
        {
            MRepotItem mrepotItem = new MRepotItem();
            if (baseVersion.IndexOf('C') == 0)
            {
                baseVersion = baseVersion.Substring(1);
            }
            if (diffVersion.IndexOf('C') == 0)
            {
                diffVersion = diffVersion.Substring(1);
            }
            MRepotItem result;
            if (baseVersion == string.Empty && diffVersion == string.Empty)
            {
                result = mrepotItem;
            }
            else
            {
                VersionSpec latest = VersionSpec.Latest;
                VersionSpec versionSpec = VersionSpec.Parse("C1", null)[0];
                Changeset changeset = null;
                Changeset changeset2 = null;
                int num = 0;
                string text = "";
                string text2 = "";
                try
                {
                    if (long.Parse(baseVersion) > long.Parse(diffVersion))
                    {
                        text = diffVersion;
                        text2 = baseVersion;
                    }
                    else
                    {
                        text = baseVersion;
                        text2 = diffVersion;
                    }
                }
                catch
                {
                    text = baseVersion;
                    text2 = diffVersion;
                }
                if (text != string.Empty && text2 == string.Empty)
                {
                    result = mrepotItem;
                }
                else
                {
                    bool flag = false;
                    bool flag2 = false;
                    Changeset changeset3 = null;
                    try
                    {
                        IEnumerable enumerable = VSTFSourceControlProvider.m_vss.QueryHistory(serverPath, VersionSpec.Latest, 0, 0, null, versionSpec, latest, int.MaxValue, true, false, true);
                        foreach (object obj in enumerable)
                        {
                            Changeset changeset4 = (Changeset)obj;
                            if (flag)
                            {
                                num++;
                            }
                            if (changeset4.ChangesetId.ToString().Trim() == text2)
                            {
                                flag = true;
                                changeset2 = changeset4;
                                changeset3 = changeset4;
                            }
                            else
                            {
                                if (changeset4.ChangesetId.ToString().Trim() == text)
                                {
                                    flag2 = true;
                                    changeset = changeset4;
                                    break;
                                }
                                if (flag)
                                {
                                    changeset3 = changeset4;
                                }
                            }
                        }
                        if (flag2)
                        {
                            mrepotItem.ChurnCount = num;
                            mrepotItem.ChurnStartDate = changeset.CreationDate;
                            mrepotItem.ChurnEndDate = changeset2.CreationDate;
                            if (mrepotItem.ChurnStartDate < startDate)
                            {
                                mrepotItem.ChurnStartDate = changeset3.CreationDate;
                            }
                        }
                        else if (flag)
                        {
                            if (changeset3 != null && startDate != DateTime.MinValue)
                            {
                                mrepotItem.ChurnCount = num + 1;
                                mrepotItem.ChurnStartDate = changeset3.CreationDate;
                                if (mrepotItem.ChurnStartDate < startDate)
                                {
                                    mrepotItem.ChurnCount = 1;
                                    mrepotItem.ChurnStartDate = changeset2.CreationDate;
                                }
                            }
                            else
                            {
                                mrepotItem.ChurnCount = 1;
                                mrepotItem.ChurnStartDate = changeset2.CreationDate;
                            }
                            mrepotItem.ChurnEndDate = changeset2.CreationDate;
                        }
                    }
                    catch
                    {
                    }
                    result = mrepotItem;
                }
            }
            return result;
        }

        // Token: 0x04000011 RID: 17
        public static string SERVER_NAME = "tkbgitvstsat02";

        // Token: 0x04000012 RID: 18
        private static TfsTeamProjectCollection m_tfs;

        // Token: 0x04000013 RID: 19
        private static VersionControlServer m_vss;

        // Token: 0x04000014 RID: 20
        private static bool m_IsConnected = false;

        // Token: 0x04000015 RID: 21
        private static string m_serverName = string.Empty;

        // Token: 0x04000016 RID: 22
        private static string m_BaseChangeset = "";

        // Token: 0x04000017 RID: 23
        private static string m_DiffChangeset = "";

        // Token: 0x04000018 RID: 24
        private static string m_WorkItem = "";

        // Token: 0x04000019 RID: 25
        private static ArrayList m_FilesInChangeset = new ArrayList();

        // Token: 0x0400001A RID: 26
        public static ArrayList m_clsFilesChangesetInWorkItem = new ArrayList();

        // Token: 0x0400001B RID: 27
        private static ArrayList m_FilesInWorkItem = new ArrayList();

        // Token: 0x0400001C RID: 28
        private object m_objSingleThread = new object();

        // Token: 0x0400001D RID: 29
        private static string m_CurrentInitTag = string.Empty;

        // Token: 0x0400001E RID: 30
        private static string m_BaseLabel = "";

        // Token: 0x0400001F RID: 31
        private static string m_DiffLabel = "";

        // Token: 0x04000020 RID: 32
        private static ArrayList m_FilesInLabels = new ArrayList();

        // Token: 0x04000021 RID: 33
        private static ArrayList m_clsFilesChangesetInLabels = new ArrayList();

        // Token: 0x04000022 RID: 34
        private VSTFSourceControlProvider.SetType m_FileTypeInSet = VSTFSourceControlProvider.SetType.ChangeSet;

        // Token: 0x04000023 RID: 35
        private Regex regNumber = new Regex("^[0-9]+$");

        // Token: 0x02000008 RID: 8
        public enum SetType
        {
            // Token: 0x04000025 RID: 37
            ChangeSet,
            // Token: 0x04000026 RID: 38
            WorkItem,
            // Token: 0x04000027 RID: 39
            Label
        }

        // Token: 0x02000009 RID: 9
        private class FileWithChangesets
        {
            // Token: 0x17000004 RID: 4
            // (get) Token: 0x06000055 RID: 85 RVA: 0x000091E0 File Offset: 0x000081E0
            // (set) Token: 0x06000056 RID: 86 RVA: 0x000091F8 File Offset: 0x000081F8
            public string BaseChangset
            {
                get
                {
                    return this._BaseChangset;
                }
                set
                {
                    this._BaseChangset = value;
                }
            }

            // Token: 0x17000005 RID: 5
            // (get) Token: 0x06000057 RID: 87 RVA: 0x00009204 File Offset: 0x00008204
            // (set) Token: 0x06000058 RID: 88 RVA: 0x0000921C File Offset: 0x0000821C
            public string DiffChangeset
            {
                get
                {
                    return this._DiffChangeset;
                }
                set
                {
                    this._DiffChangeset = value;
                }
            }

            // Token: 0x17000006 RID: 6
            // (get) Token: 0x06000059 RID: 89 RVA: 0x00009228 File Offset: 0x00008228
            // (set) Token: 0x0600005A RID: 90 RVA: 0x00009240 File Offset: 0x00008240
            public string FilePath
            {
                get
                {
                    return this._FilePath;
                }
                set
                {
                    this._FilePath = value;
                }
            }

            // Token: 0x04000028 RID: 40
            private string _BaseChangset = string.Empty;

            // Token: 0x04000029 RID: 41
            private string _DiffChangeset = string.Empty;

            // Token: 0x0400002A RID: 42
            private string _FilePath = string.Empty;
        }
    }
}
