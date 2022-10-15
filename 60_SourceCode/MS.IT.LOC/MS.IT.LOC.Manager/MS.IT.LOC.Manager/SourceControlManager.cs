using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using MS.IT.LOC.Model;
using MS.IT.LOC.SourceControl;

namespace MS.IT.LOC.Manager
{
    // Token: 0x02000005 RID: 5
    public class SourceControlManager
    {
        // Token: 0x14000002 RID: 2
        // (add) Token: 0x0600000E RID: 14 RVA: 0x00002328 File Offset: 0x00001328
        // (remove) Token: 0x0600000F RID: 15 RVA: 0x00002341 File Offset: 0x00001341
        public event SourceControlEventHandler OnConnect;

        // Token: 0x14000003 RID: 3
        // (add) Token: 0x06000010 RID: 16 RVA: 0x0000235A File Offset: 0x0000135A
        // (remove) Token: 0x06000011 RID: 17 RVA: 0x00002373 File Offset: 0x00001373
        public event SourceControlEventHandler OnItemGet;

        // Token: 0x14000004 RID: 4
        // (add) Token: 0x06000012 RID: 18 RVA: 0x0000238C File Offset: 0x0000138C
        // (remove) Token: 0x06000013 RID: 19 RVA: 0x000023A5 File Offset: 0x000013A5
        public event SourceControlEventHandler OnDownload;

        // Token: 0x14000005 RID: 5
        // (add) Token: 0x06000014 RID: 20 RVA: 0x000023BE File Offset: 0x000013BE
        // (remove) Token: 0x06000015 RID: 21 RVA: 0x000023D7 File Offset: 0x000013D7
        public event SourceControlEventHandler OnCompare;

        // Token: 0x06000016 RID: 22 RVA: 0x000023F0 File Offset: 0x000013F0
        private void SourceControlGenEventHandler(object src, SourceControlEventArgs args)
        {
        }

        // Token: 0x06000017 RID: 23 RVA: 0x000023F4 File Offset: 0x000013F4
        public int InitFileTypeFilter()
        {
            this.m_FileExtensionExpression = this.getExtensionExpression();
            int result;
            if (this.m_FileExtensionExpression == null)
            {
                result = -1;
            }
            else
            {
                result = 1;
            }
            return result;
        }

        // Token: 0x06000018 RID: 24 RVA: 0x00002428 File Offset: 0x00001428
        public void InitEvent(string eventName)
        {
            if (eventName != null)
            {
                if (eventName == "OnConnect")
                {
                    this.OnConnect = new SourceControlEventHandler(this.SourceControlGenEventHandler);
                }
            }
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002460 File Offset: 0x00001460
        public SourceControlManager()
        {
            this.OnConnect = new SourceControlEventHandler(this.SourceControlGenEventHandler);
            this.OnItemGet = new SourceControlEventHandler(this.SourceControlGenEventHandler);
            this.OnDownload = new SourceControlEventHandler(this.SourceControlGenEventHandler);
            this.OnCompare = new SourceControlEventHandler(this.SourceControlGenEventHandler);
            this.m_SCProvider = null;
            this.m_SCProviderVSTF = new VSTFSourceControlProvider();
            this.m_SCProviderSD = new SDSourceControlProvider();
            this.m_SCProviderVSS = new VSSSourceControlProvider();
            this.m_SCProviderFS = new FSSourceControlProvider();
            this.m_ServerName = "";
            this.m_ServerType = SourceServerType.Base;
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00002518 File Offset: 0x00001518
        public bool Login(string ServerName, string ServerPort, SourceServerType ServerType, string LoginId, string Password)
        {
            this.OnConnect(this, SourceControlEventArgs.Connecting);
            switch (ServerType)
            {
                case SourceServerType.VSTF:
                    this.m_SCProvider = this.m_SCProviderVSTF;
                    break;
                case SourceServerType.VSS:
                    this.m_SCProvider = this.m_SCProviderVSS;
                    break;
                case SourceServerType.SD:
                    this.m_SCProvider = this.m_SCProviderSD;
                    break;
                case SourceServerType.FILESYS:
                    this.m_SCProvider = this.m_SCProviderFS;
                    break;
                default:
                    throw new Exception("The source control type is not known.");
            }
            bool result;
            if (this.m_SCProvider.Login(ServerName, ServerPort, LoginId, Password))
            {
                this.OnConnect(this, SourceControlEventArgs.Connected);
                this.m_ServerName = ServerName;
                this.m_ServerType = ServerType;
                this.m_IsConnected = true;
                result = true;
            }
            else
            {
                this.m_IsConnected = false;
                this.OnConnect(this, SourceControlEventArgs.UnableToConnect);
                result = false;
            }
            return result;
        }

        // Token: 0x0600001B RID: 27 RVA: 0x000025FC File Offset: 0x000015FC
        public bool LoginWithoutEvent(string ServerName, string ServerPort, SourceServerType ServerType, string LoginId, string Password)
        {
            switch (ServerType)
            {
                case SourceServerType.VSTF:
                    this.m_SCProvider = this.m_SCProviderVSTF;
                    break;
                case SourceServerType.VSS:
                    this.m_SCProvider = this.m_SCProviderVSS;
                    break;
                case SourceServerType.SD:
                    this.m_SCProvider = this.m_SCProviderSD;
                    break;
                case SourceServerType.FILESYS:
                    this.m_SCProvider = this.m_SCProviderFS;
                    break;
                default:
                    throw new Exception("The source control type is not known.");
            }
            bool result;
            if (this.m_SCProvider.Login(ServerName, ServerPort, LoginId, Password))
            {
                this.m_ServerName = ServerName;
                this.m_ServerType = ServerType;
                this.m_IsConnected = true;
                result = true;
            }
            else
            {
                this.m_IsConnected = false;
                result = false;
            }
            return result;
        }

        // Token: 0x0600001C RID: 28 RVA: 0x000026A8 File Offset: 0x000016A8
        public SCItemSet GetChildItem(SCItem parent, bool recursive)
        {
            SCItemSet result;
            if (this.m_IsConnected)
            {
                if (this.m_CurrentCountItem == null)
                {
                    throw new Exception("You need to set the current working count item to the source control management!");
                }
                this.OnItemGet(parent, SourceControlEventArgs.Getting);
                SCItemSet scitemSet;
                if (this.m_CurrentCountItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                {
                    string[] versions = new string[]
                    {
                        this.m_CurrentCountItem.BaseVersion,
                        this.m_CurrentCountItem.DiffVersion
                    };
                    scitemSet = this.m_SCProvider.GetChildItemInSet(parent, recursive, 0, versions);
                }
                else if (this.m_CurrentCountItem.Type == CIType.DIFF_PREVIOUS)
                {
                    string[] versions = new string[]
                    {
                        this.m_CurrentCountItem.DiffVersion
                    };
                    scitemSet = this.m_SCProvider.GetChildItemInSet(parent, recursive, 0, versions);
                }
                else if (this.m_CurrentCountItem.Type == CIType.LATEST_SET)
                {
                    string[] versions = new string[]
                    {
                        this.m_CurrentCountItem.BaseVersion
                    };
                    scitemSet = this.m_SCProvider.GetChildItemInSet(parent, recursive, 0, versions);
                }
                else if (this.m_CurrentCountItem.Type == CIType.LATEST_WORKITEM)
                {
                    string[] versions = new string[]
                    {
                        this.m_CurrentCountItem.BaseItem
                    };
                    scitemSet = this.m_SCProvider.GetChildItemInSet(parent, recursive, 1, versions);
                }
                else if (this.m_CurrentCountItem.Type == CIType.ITEM_FOLDER)
                {
                    string[] versions = new string[]
                    {
                        this.m_CurrentCountItem.DiffItem
                    };
                    scitemSet = this.m_SCProvider.GetChildItemInSet(parent, recursive, 0, versions);
                }
                else
                {
                    scitemSet = this.m_SCProvider.GetChildItem(parent, recursive);
                }
                if (scitemSet == null && !this.m_IsConnected)
                {
                    this.OnConnect(this, SourceControlEventArgs.NotConnected);
                }
                this.OnItemGet(parent, SourceControlEventArgs.Got);
                result = scitemSet;
            }
            else
            {
                this.OnConnect(this, SourceControlEventArgs.NotConnected);
                result = null;
            }
            return result;
        }

        // Token: 0x0600001D RID: 29 RVA: 0x000028A4 File Offset: 0x000018A4
        public void Download(CounterItemSet counterItemSet)
        {
            ArrayList arrayList = new ArrayList();
            foreach (object obj in counterItemSet)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    switch (counterItem.ServerType)
                    {
                        case SourceServerType.VSTF:
                            this.m_SCProvider = this.m_SCProviderVSTF;
                            break;
                        case SourceServerType.VSS:
                            this.m_SCProvider = this.m_SCProviderVSS;
                            break;
                        case SourceServerType.SD:
                            this.m_SCProvider = this.m_SCProviderSD;
                            break;
                        case SourceServerType.FILESYS:
                            this.m_SCProvider = this.m_SCProviderFS;
                            this.m_SCProvider.Login(counterItem.ServerName, "", "", "");
                            break;
                        default:
                            throw new Exception("The source control type is not known.");
                    }
                    string text = LOCConstants.TempPath + "\\" + counterItem.Name;
                    string text2 = LOCConstants.TempPath + "\\Diff\\" + counterItem.Name;
                    DirectoryInfo directoryInfo = new DirectoryInfo(text);
                    if (directoryInfo.Exists)
                    {
                        foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                        {
                            fileInfo.Attributes = FileAttributes.Normal;
                        }
                        directoryInfo.Delete(true);
                    }
                    directoryInfo = Directory.CreateDirectory(LOCConstants.TempPath + "\\" + counterItem.Name);
                    if (directoryInfo.Exists)
                    {
                        if (Directory.Exists(text2))
                        {
                            Directory.Delete(text2, true);
                        }
                        Directory.CreateDirectory(text2);
                        int num = 0;
                        ManualResetEvent[] array;
                        if (counterItem.DownLoadItems.Count >= 10)
                        {
                            array = new ManualResetEvent[10];
                        }
                        else
                        {
                            array = new ManualResetEvent[counterItem.DownLoadItems.Count];
                        }
                        for (int j = 0; j < counterItem.DownLoadItems.Count; j++)
                        {
                            SCItem scitem = counterItem.DownLoadItems[j];
                            if (scitem.ScType == SCItemType.FILE)
                            {
                                array[num] = new ManualResetEvent(false);
                                SourceControlManager.DowonloadCounter @object = new SourceControlManager.DowonloadCounter(scitem, counterItem, this.m_SCProvider, text, text2, array[num]);
                                this.OnDownload(scitem.Path, SourceControlEventArgs.Downloading);
                                ThreadPool.QueueUserWorkItem(new WaitCallback(@object.ThreadPoolCallback), num);
                                this.OnDownload(scitem.Path, SourceControlEventArgs.Downloaded);
                                num++;
                                if (num == 10)
                                {
                                    this.WaitAll(array);
                                    num = 0;
                                    if (counterItem.DownLoadItems.Count - j - 1 < 10 && counterItem.DownLoadItems.Count - j - 1 >= 1)
                                    {
                                        array = new ManualResetEvent[counterItem.DownLoadItems.Count - j - 1];
                                    }
                                    else
                                    {
                                        array = new ManualResetEvent[10];
                                    }
                                }
                            }
                        }
                        if (array.Length > 0)
                        {
                            this.WaitAll(array);
                        }
                    }
                    DateTime dateTime = DateTime.MinValue;
                    DateTime d = DateTime.MinValue;
                    int num2 = 0;
                    if (counterItem.MReport)
                    {
                        for (int j = 0; j < counterItem.DownLoadItems.Count; j++)
                        {
                            SCItem scitem = counterItem.DownLoadItems[j];
                            if (scitem.ChurnCount > 0 && scitem.ChurnStartDate != DateTime.MinValue && scitem.ChurnEndDate != DateTime.MinValue)
                            {
                                if (scitem.ChurnEndDate - scitem.ChurnStartDate >= d - dateTime)
                                {
                                    dateTime = scitem.ChurnStartDate;
                                    d = scitem.ChurnEndDate;
                                }
                            }
                            num2 += scitem.ChurnCount;
                        }
                        counterItem.Churncount = (double)num2;
                        if (d != DateTime.MinValue && dateTime != DateTime.MinValue)
                        {
                            counterItem.WeeksofChurn = (d - dateTime).TotalDays / 7.0;
                            if (counterItem.WeeksofChurn == 0.0)
                            {
                                counterItem.WeeksofChurn = 1.0;
                            }
                        }
                        else
                        {
                            counterItem.WeeksofChurn = 0.0;
                        }
                    }
                }
            }
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00002D8C File Offset: 0x00001D8C
        private void WaitAll(ManualResetEvent[] events)
        {
            foreach (ManualResetEvent manualResetEvent in events)
            {
                if (manualResetEvent != null)
                {
                    manualResetEvent.WaitOne();
                }
            }
        }

        // Token: 0x0600001F RID: 31 RVA: 0x00002DC6 File Offset: 0x00001DC6
        public void m_SCProvider_ItemRead(object source, EventArgs e)
        {
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00002DCC File Offset: 0x00001DCC
        public void ConfigureDownloadItems(CounterItem CI)
        {
            CI.DownLoadItems.Clear();
            if (this.m_FileExtensionExpression == null)
            {
                throw new Exception("You need to set the filter expression at first. Call developer.");
            }
            if (CI.ServerType == SourceServerType.FILESYS)
            {
                this.m_SCProvider.Login(CI.ServerName, "", "", "");
            }
            foreach (object obj in CI.IncludeElementSet)
            {
                Element element = (Element)obj;
                if (element.ElementType == SCItemType.FILE)
                {
                    if (!this.IsExcludedItem(element.ServerPath, CI.ExcludeElementSet))
                    {
                        SCItem scitem = new SCItem();
                        scitem.ScType = SCItemType.FILE;
                        scitem.Path = element.ServerPath;
                        scitem.Name = element.Name;
                        ArrayList clsFilesChangesetInWorkItem = VSTFSourceControlProvider.m_clsFilesChangesetInWorkItem;
                        if (this.m_FileExtensionExpression.IsMatch(element.ServerPath))
                        {
                            CI.DownLoadItems.Add(scitem);
                        }
                    }
                }
                else
                {
                    this.ConfigureFolderItem(element.ServerPath, CI);
                }
            }
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00002F24 File Offset: 0x00001F24
        private Regex getExtensionExpression()
        {
            Regex result;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(AppConfigurationManager.CurrentCountStandard.DestineLocation);
                XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("lineCounter");
                StringBuilder stringBuilder = new StringBuilder(25);
                stringBuilder.Append(".+\\.(");
                foreach (object obj in xmlNodeList)
                {
                    XmlNode xmlNode = (XmlNode)obj;
                    XmlNodeList xmlNodeList2 = xmlNode.SelectNodes("fileExtension");
                    foreach (object obj2 in xmlNodeList2)
                    {
                        XmlNode xmlNode2 = (XmlNode)obj2;
                        stringBuilder.AppendFormat("({0})|", xmlNode2.InnerText);
                    }
                }
                stringBuilder.Length--;
                stringBuilder.Append(")$");
                string pattern = stringBuilder.ToString();
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);
                result = regex;
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000022 RID: 34 RVA: 0x000030AC File Offset: 0x000020AC
        private void ConfigureFolderItem(string path, CounterItem CI)
        {
            SCItemSet childItem = this.GetChildItem(new SCItem
            {
                Path = path,
                ScType = SCItemType.FOLDER
            }, false);
            if (childItem != null)
            {
                foreach (object obj in childItem)
                {
                    SCItem scitem = (SCItem)obj;
                    if (!this.IsExcludedItem(scitem.Path, CI.ExcludeElementSet))
                    {
                        if (scitem.ScType == SCItemType.FILE)
                        {
                            if (this.m_FileExtensionExpression.IsMatch(scitem.Path))
                            {
                                CI.DownLoadItems.Add(scitem);
                            }
                        }
                        else
                        {
                            this.ConfigureFolderItem(scitem.Path, CI);
                        }
                    }
                }
            }
        }

        // Token: 0x06000023 RID: 35 RVA: 0x000031A4 File Offset: 0x000021A4
        private bool IsExcludedItem(string path, ElementSet excludedList)
        {
            foreach (object obj in excludedList)
            {
                Element element = (Element)obj;
                if (element.ServerPath == path)
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x0400000D RID: 13
        private const int ThreadPoolValue = 10;

        // Token: 0x0400000E RID: 14
        private ISourceControlProvider m_SCProvider;

        // Token: 0x0400000F RID: 15
        private ISourceControlProvider m_SCProviderVSTF;

        // Token: 0x04000010 RID: 16
        private ISourceControlProvider m_SCProviderSD;

        // Token: 0x04000011 RID: 17
        private ISourceControlProvider m_SCProviderVSS;

        // Token: 0x04000012 RID: 18
        private ISourceControlProvider m_SCProviderFS;

        // Token: 0x04000013 RID: 19
        public bool m_IsConnected = false;

        // Token: 0x04000014 RID: 20
        public static BasedToLabelAndChangeset currentBTLC = new BasedToLabelAndChangeset();

        // Token: 0x04000019 RID: 25
        public static ArrayList errorsOfDownload = new ArrayList();

        // Token: 0x0400001A RID: 26
        public string m_ServerName;

        // Token: 0x0400001B RID: 27
        public SourceServerType m_ServerType;

        // Token: 0x0400001C RID: 28
        public CounterItem m_CurrentCountItem = null;

        // Token: 0x0400001D RID: 29
        private Regex m_FileExtensionExpression = null;

        // Token: 0x02000006 RID: 6
        private class DowonloadCounter
        {
            // Token: 0x06000025 RID: 37 RVA: 0x00003236 File Offset: 0x00002236
            public DowonloadCounter(SCItem item, CounterItem objCI, ISourceControlProvider scProvider, string folderPath, string diffFolderPath, ManualResetEvent doneEvent)
            {
                this._objItem = item;
                this.m_SCProvider = scProvider;
                this._CIFolderPath = folderPath;
                this._CIDiffFolderPath = diffFolderPath;
                this._doneEvent = doneEvent;
                this.counterItem = objCI;
            }

            // Token: 0x06000026 RID: 38 RVA: 0x00003270 File Offset: 0x00002270
            public void ThreadPoolCallback(object threadContext)
            {
                int num = (int)threadContext;
                this.Download();
                this._doneEvent.Set();
            }

            // Token: 0x06000027 RID: 39 RVA: 0x00003298 File Offset: 0x00002298
            public void Download()
            {
                string text = this._objItem.ID + "-" + this._objItem.Name;
                if (this.counterItem.Type == CIType.DATE_RANGE || this.counterItem.Type == CIType.LABEL_CHANGESET || this.counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET || this.counterItem.Type == CIType.DIFF_PREVIOUS || this.counterItem.Type == CIType.LATEST_SET || this.counterItem.Type == CIType.LATEST_WORKITEM)
                {
                    ArrayList firstAndLastVersionSpec;
                    if (this.counterItem.Type == CIType.DATE_RANGE)
                    {
                        firstAndLastVersionSpec = this.m_SCProvider.GetFirstAndLastVersionSpec(this._objItem.Path, this.counterItem.StartDate, this.counterItem.EndDate);
                    }
                    else if (this.counterItem.Type == CIType.DIFF_PREVIOUS)
                    {
                        firstAndLastVersionSpec = this.m_SCProvider.GetFirstAndLastVersionSpec(this._objItem.Path, 0, this.counterItem.DiffVersion.ToString());
                    }
                    else if (this.counterItem.Type == CIType.LATEST_SET)
                    {
                        firstAndLastVersionSpec = this.m_SCProvider.GetFirstAndLastVersionSpec(this._objItem.Path, this.counterItem.BaseVersion.ToString(), "");
                    }
                    else if (this.counterItem.Type == CIType.LATEST_WORKITEM)
                    {
                        firstAndLastVersionSpec = this.m_SCProvider.GetFirstAndLastVersionSpec(this._objItem.Path, 1, this.counterItem.BaseItem);
                    }
                    else
                    {
                        firstAndLastVersionSpec = this.m_SCProvider.GetFirstAndLastVersionSpec(this._objItem.Path, this.counterItem.BaseVersion.ToString(), this.counterItem.DiffVersion.ToString());
                    }
                    if (this.counterItem.MReport)
                    {
                        MRepotItem itemChurnCount = this.m_SCProvider.GetItemChurnCount(this._objItem.Path, firstAndLastVersionSpec[0].ToString(), firstAndLastVersionSpec[1].ToString(), this.counterItem.StartDate, this.counterItem.EndDate);
                        this._objItem.ChurnStartDate = itemChurnCount.ChurnStartDate;
                        this._objItem.ChurnEndDate = itemChurnCount.ChurnEndDate;
                        this._objItem.ChurnCount = itemChurnCount.ChurnCount;
                    }
                    if (!string.IsNullOrEmpty(firstAndLastVersionSpec[0].ToString()) && !string.IsNullOrEmpty(firstAndLastVersionSpec[1].ToString()))
                    {
                        if (this.counterItem.ServerType == SourceServerType.VSTF)
                        {
                            this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[0]);
                            this.m_SCProvider.Download(this._objItem.Path, this._CIDiffFolderPath + "\\" + text, firstAndLastVersionSpec[1]);
                            if (!File.Exists(this._CIFolderPath + "\\" + text) || !File.Exists(this._CIDiffFolderPath + "\\" + text))
                            {
                                SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                            }
                            else
                            {
                                this.m_SCProvider.DownloadDiff(this._CIFolderPath + "\\" + text, this._CIDiffFolderPath + "\\" + text, firstAndLastVersionSpec[0], firstAndLastVersionSpec[1]);
                            }
                            this._objItem.SCDownloadType = DownloadType.Both;
                        }
                        if (this.counterItem.ServerType == SourceServerType.SD)
                        {
                            bool flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[0]);
                            if (!File.Exists(this._CIFolderPath + "\\" + text))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                            flag = this.m_SCProvider.Download(this._objItem.Path, this._CIDiffFolderPath + "\\" + text, firstAndLastVersionSpec[1]);
                            if (!File.Exists(this._CIDiffFolderPath + "\\" + text))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                            this.m_SCProvider.DownloadDiff(this._CIFolderPath + "\\" + text, this._CIDiffFolderPath + "\\" + text, firstAndLastVersionSpec[0], firstAndLastVersionSpec[1]);
                            this._objItem.SCDownloadType = DownloadType.Both;
                        }
                        if (this.counterItem.ServerType == SourceServerType.VSS)
                        {
                            bool flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[1]);
                            if (!File.Exists(string.Concat(new string[]
                            {
                                this._CIFolderPath,
                                "\\",
                                this._objItem.ID,
                                "-",
                                this._objItem.Name
                            })))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                            else
                            {
                                File.Move(string.Concat(new string[]
                                {
                                    this._CIFolderPath,
                                    "\\",
                                    this._objItem.ID,
                                    "-",
                                    this._objItem.Name
                                }), string.Concat(new string[]
                                {
                                    this._CIFolderPath,
                                    "\\",
                                    this._objItem.ID,
                                    "-",
                                    this._objItem.Name,
                                    "1"
                                }));
                            }
                            flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[0]);
                            if (!File.Exists(string.Concat(new string[]
                            {
                                this._CIFolderPath,
                                "\\",
                                this._objItem.ID,
                                "-",
                                this._objItem.Name
                            })))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                            this.m_SCProvider.DownloadDiff(string.Concat(new string[]
                            {
                                this._CIFolderPath,
                                "\\",
                                this._objItem.ID,
                                "-",
                                this._objItem.Name
                            }), string.Concat(new string[]
                            {
                                LOCConstants.TempPath,
                                "\\Diff\\",
                                this.counterItem.Name,
                                "\\",
                                text
                            }), firstAndLastVersionSpec[0], firstAndLastVersionSpec[1]);
                            this._objItem.SCDownloadType = DownloadType.Both;
                        }
                    }
                    else if (!string.IsNullOrEmpty(firstAndLastVersionSpec[0].ToString()) && string.IsNullOrEmpty(firstAndLastVersionSpec[1].ToString()))
                    {
                        if (this.counterItem.ServerType == SourceServerType.VSTF || this.counterItem.ServerType == SourceServerType.VSS)
                        {
                            this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[0]);
                            if (!File.Exists(string.Concat(new string[]
                            {
                                this._CIFolderPath,
                                "\\",
                                this._objItem.ID,
                                "-",
                                this._objItem.Name
                            })))
                            {
                                SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                            }
                        }
                        if (this.counterItem.ServerType == SourceServerType.SD)
                        {
                            bool flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[0]);
                            if (!File.Exists(this._CIFolderPath + "\\" + text))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                        }
                        this._objItem.SCDownloadType = DownloadType.Base;
                    }
                    else if (string.IsNullOrEmpty(firstAndLastVersionSpec[0].ToString()) && !string.IsNullOrEmpty(firstAndLastVersionSpec[1].ToString()))
                    {
                        if (this.counterItem.ServerType == SourceServerType.VSTF || this.counterItem.ServerType == SourceServerType.VSS)
                        {
                            this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[1]);
                            if (!File.Exists(string.Concat(new string[]
                            {
                                this._CIFolderPath,
                                "\\",
                                this._objItem.ID,
                                "-",
                                this._objItem.Name
                            })))
                            {
                                SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                            }
                        }
                        if (this.counterItem.ServerType == SourceServerType.SD)
                        {
                            bool flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text, firstAndLastVersionSpec[1]);
                            if (!File.Exists(this._CIFolderPath + "\\" + text))
                            {
                                if (!flag)
                                {
                                    SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                                }
                            }
                        }
                        this._objItem.SCDownloadType = DownloadType.Latest;
                    }
                }
                else if (this.counterItem.Type == CIType.ITEM_FOLDER)
                {
                    if (this.counterItem.ServerType == SourceServerType.FILESYS)
                    {
                        bool flag = this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text);
                        if (!Directory.Exists(this._CIDiffFolderPath))
                        {
                            Directory.CreateDirectory(this._CIDiffFolderPath);
                        }
                        flag = this.m_SCProvider.Download(this._objItem.Path, this._CIDiffFolderPath + "\\" + text, this.counterItem.DiffItem);
                        if (!File.Exists(this._CIFolderPath + "\\" + text) && !File.Exists(this._CIDiffFolderPath + "\\" + text))
                        {
                            if (!flag)
                            {
                                SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                            }
                        }
                        if (File.Exists(this._CIFolderPath + "\\" + text) && File.Exists(this._CIDiffFolderPath + "\\" + text))
                        {
                            if (this.m_SCProvider.DownloadDiff(this._CIFolderPath + "\\" + text, this._CIDiffFolderPath + "\\" + text, "", ""))
                            {
                                this._objItem.SCDownloadType = DownloadType.Both;
                            }
                            else
                            {
                                this._objItem.SCDownloadType = DownloadType.Base;
                            }
                        }
                        else if (!File.Exists(this._CIFolderPath + "\\" + text) && File.Exists(this._CIDiffFolderPath + "\\" + text))
                        {
                            File.Copy(this._CIDiffFolderPath + "\\" + text, this._CIFolderPath + "\\" + text);
                            this._objItem.SCDownloadType = DownloadType.Latest;
                        }
                        else
                        {
                            this._objItem.SCDownloadType = DownloadType.Base;
                        }
                    }
                }
                else
                {
                    this.m_SCProvider.Download(this._objItem.Path, this._CIFolderPath + "\\" + text);
                    if (!File.Exists(this._CIFolderPath + "\\" + text) && this.counterItem.ServerType != SourceServerType.SD)
                    {
                        SourceControlManager.errorsOfDownload.Add(this._objItem.Path);
                    }
                    this._objItem.SCDownloadType = DownloadType.Latest;
                }
            }

            // Token: 0x0400001E RID: 30
            private string _CIFolderPath;

            // Token: 0x0400001F RID: 31
            private string _CIDiffFolderPath;

            // Token: 0x04000020 RID: 32
            private SCItem _objItem;

            // Token: 0x04000021 RID: 33
            private ISourceControlProvider m_SCProvider;

            // Token: 0x04000022 RID: 34
            private ManualResetEvent _doneEvent;

            // Token: 0x04000023 RID: 35
            private CounterItem counterItem;
        }
    }
}
