using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MS.IT.LOC.CounterEngine;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
    // Token: 0x02000007 RID: 7
    public partial class frmCounter : Form
    {
        // Token: 0x06000023 RID: 35 RVA: 0x000034F4 File Offset: 0x000024F4
        protected void m_SourceControlManager_OnConnect(object source, SourceControlEventArgs args)
        {
            Application.DoEvents();
            if (args == SourceControlEventArgs.Connecting)
            {
                this.Cursor = Cursors.WaitCursor;
            }
            else if (args == SourceControlEventArgs.Connected)
            {
                this.Cursor = Cursors.Default;
                this.Processing = true;
                this.countThread = new Thread(new ThreadStart(this.Count));
                this.countThread.Start();
            }
            else if (args == SourceControlEventArgs.UnableToConnect)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Can't connect to the server", this.Text);
                base.Close();
            }
            else if (args == SourceControlEventArgs.NotConnected)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Can't connect to the server", this.Text);
                base.Close();
            }
        }

        // Token: 0x06000024 RID: 36 RVA: 0x000035E0 File Offset: 0x000025E0
        public frmCounter(CounterItemSet ciSet)
        {
            frmCounterItems.m_SourceControlManager.InitEvent("OnConnect");
            frmCounterItems.m_SourceControlManager.OnConnect += this.m_SourceControlManager_OnConnect;
            this.InitializeComponent();
            this.CISet = ciSet;
            this.lvwItem = new ListViewItem(new string[]
            {
                "Configuring Download Items"
            });
            this.lvItems.Items.Add(this.lvwItem);
            this.lvwItem = new ListViewItem(new string[]
            {
                "Downloading"
            });
            this.lvItems.Items.Add(this.lvwItem);
            this.lvwItem = new ListViewItem(new string[]
            {
                "Executing Counter Engine"
            });
            this.lvItems.Items.Add(this.lvwItem);
            frmCounterItems.m_SourceControlManager.OnDownload += this.m_SourceControlManager_OnDownload;
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00003702 File Offset: 0x00002702
        private void codeCounter_OnCounted(object sender, CounterEventArgs e)
        {
            this.SetProcBarFromThread(0, -1, -1, -1);
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00003710 File Offset: 0x00002710
        private void m_SourceControlManager_OnDownload(object sender, SourceControlEventArgs e)
        {
            this.SetProcBarFromThread(0, -1, -1, -1);
        }

        // Token: 0x06000027 RID: 39 RVA: 0x00003720 File Offset: 0x00002720
        private void OnShow(object sender, EventArgs e)
        {
            if (!this.Processing)
            {
                this.Cursor = Cursors.Default;
                this.Processing = true;
                this.countThread = new Thread(new ThreadStart(this.Count));
                this.countThread.Start();
            }
            Application.DoEvents();
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00003778 File Offset: 0x00002778
        private void ConfigureDownLoadItem()
        {
            if (frmCounterItems.m_SourceControlManager.InitFileTypeFilter() < 0)
            {
                throw new LOCCountStandardErrorFormat();
            }
            int includeElementsCounts = this.CISet.GetIncludeElementsCounts();
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    SourceControlManager.currentBTLC.BaseVersion = counterItem.LabelsBeseVer;
                    SourceControlManager.currentBTLC.DiffVersion = counterItem.LabelsDiffVer;
                    SourceControlManager.currentBTLC.currentCIType = counterItem.Type;
                    frmCounterItems.m_SourceControlManager.m_CurrentCountItem = counterItem;
                    if ((counterItem.ServerName == frmCounterItems.m_SourceControlManager.m_ServerName || counterItem.ServerType == SourceServerType.FILESYS) && counterItem.ServerType == frmCounterItems.m_SourceControlManager.m_ServerType)
                    {
                        frmCounterItems.m_SourceControlManager.ConfigureDownloadItems(counterItem);
                    }
                    else
                    {
                        counterItem.DownLoadItems.Clear();
                    }
                }
                if (includeElementsCounts > 0)
                {
                    this.SetUIFromThread(int.MinValue, int.MinValue, counterItem.IncludeElementSet.Count * 100 / includeElementsCounts);
                }
            }
        }

        // Token: 0x06000029 RID: 41 RVA: 0x000038E0 File Offset: 0x000028E0
        private void DeleteTemporaryFiles()
        {
            try
            {
                foreach (object obj in this.CISet.FilteredItems)
                {
                    CounterItem counterItem = (CounterItem)obj;
                    if (counterItem.ToBeCount)
                    {
                        string path = LOCConstants.TempPath + "\\" + counterItem.Name;
                        string path2 = LOCConstants.TempPath + "\\Diff\\" + counterItem.Name;
                        DirectoryInfo directoryInfo = new DirectoryInfo(path);
                        if (directoryInfo != null && directoryInfo.Exists)
                        {
                            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                            {
                                fileInfo.Attributes = FileAttributes.Normal;
                            }
                            Directory.Delete(path, true);
                        }
                        directoryInfo = new DirectoryInfo(path2);
                        if (directoryInfo != null && directoryInfo.Exists)
                        {
                            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                            {
                                fileInfo.Attributes = FileAttributes.Normal;
                            }
                            Directory.Delete(path2, true);
                        }
                    }
                }
                string tempPath = LOCConstants.TempPath;
                DirectoryInfo directoryInfo2 = new DirectoryInfo(tempPath);
                if (directoryInfo2 != null && directoryInfo2.Exists)
                {
                    Directory.Delete(tempPath, true);
                }
            }
            catch (Exception ex)
            {
            }
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00003AB4 File Offset: 0x00002AB4
        private void Count()
        {
            int num = 0;
            try
            {
                this.SetUIFromThread(num, 0, 1);
                this.ConfigureDownLoadItem();
                this.SetUIFromThread(num, 1, int.MinValue);
                num++;
                this.SetUIFromThread(num, 0, -99);
                this.DownloadCISet();
                this.SetUIFromThread(num, 1, -1 * this.TotalDownloadItem);
                num++;
                this.SetUIFromThread(num, 0, int.MinValue);
                this.RunCounterEngine();
                this.DeleteTemporaryFiles();
                this.SetUIFromThread(num, 1, int.MinValue);
                this.SetUIFromThread(int.MinValue, int.MinValue, int.MinValue);
            }
            catch (LOCCountStandardErrorFormat loccountStandardErrorFormat)
            {
                MessageBox.Show("Some errors exist when loading the counting standard file!");
                for (int i = num; i < this.lvItems.Items.Count; i++)
                {
                    this.SetUIFromThread(i, 2, int.MinValue);
                }
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex2)
            {
                this.SetUIFromThread(ex2.Message + Environment.NewLine + ex2.StackTrace);
                for (int i = num; i < this.lvItems.Items.Count; i++)
                {
                    this.SetUIFromThread(i, 2, int.MinValue);
                }
            }
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00003C1C File Offset: 0x00002C1C
        private void SetListView_Process(int itemNo, int imageIndex, int processInc, string msg)
        {
            if (itemNo == -2147483648 && imageIndex == -2147483648 && processInc == -2147483648 && msg != "")
            {
                MessageBox.Show(msg);
                Application.DoEvents();
            }
            else if (itemNo == -2147483648 && imageIndex == -2147483648 && processInc == -2147483648 && msg == "")
            {
                base.Hide();
                new frmResult(this.CISet.FilteredItems)
                {
                    counterArray = this.counterArray
                }.ShowDialog();
                base.Close();
                Application.DoEvents();
            }
            else
            {
                if (itemNo >= 0)
                {
                    this.lvItems.Items[itemNo].ImageIndex = imageIndex;
                }
                if (processInc != -2147483648)
                {
                    this.progressBarStatus.Increment(processInc);
                }
                Application.DoEvents();
            }
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00003D14 File Offset: 0x00002D14
        private void ProgressBarSet(int mode, int value1, int value2, int value3)
        {
            if (mode != -2147483648)
            {
                switch (mode)
                {
                    case 0:
                        this.progressBarStatus.PerformStep();
                        break;
                    case 1:
                        this.progressBarStatus.Minimum = value1;
                        this.progressBarStatus.Maximum = value2;
                        this.progressBarStatus.Step = value3;
                        break;
                }
            }
            else
            {
                base.Close();
                Application.DoEvents();
            }
            Application.DoEvents();
        }

        // Token: 0x0600002D RID: 45 RVA: 0x00003D8C File Offset: 0x00002D8C
        private void SetProcBarFromThread(int mode, int value1, int value2, int value3)
        {
            if (this.progressBarStatus.InvokeRequired)
            {
                this.progressBarStatus.Invoke(new frmCounter.ProgressBarSetCallback(this.ProgressBarSet), new object[]
                {
                    mode,
                    value1,
                    value2,
                    value3
                });
            }
            else
            {
                this.ProgressBarSet(mode, value1, value2, value3);
            }
        }

        // Token: 0x0600002E RID: 46 RVA: 0x00003E04 File Offset: 0x00002E04
        private void SetUIFromThread(int itemNo, int imageIndex, int processInc)
        {
            if (this.lvItems.InvokeRequired)
            {
                this.lvItems.Invoke(new frmCounter.SetListView_ProcessCallback(this.SetListView_Process), new object[]
                {
                    itemNo,
                    imageIndex,
                    processInc,
                    ""
                });
            }
            else
            {
                this.SetListView_Process(itemNo, imageIndex, processInc, "");
            }
        }

        // Token: 0x0600002F RID: 47 RVA: 0x00003E7C File Offset: 0x00002E7C
        private void SetUIFromThread(string msg)
        {
            if (this.lvItems.InvokeRequired)
            {
                this.lvItems.Invoke(new frmCounter.SetListView_ProcessCallback(this.SetListView_Process), new object[]
                {
                    int.MinValue,
                    int.MinValue,
                    int.MinValue,
                    msg
                });
            }
            else
            {
                this.SetListView_Process(int.MinValue, int.MinValue, int.MinValue, msg);
            }
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00003F04 File Offset: 0x00002F04
        private void RunCounterEngine()
        {
            int num = 0;
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    num++;
                }
            }
            this.counterArray = new CodeCounter[num];
            int num2 = 0;
            foreach (object obj2 in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj2;
                if (counterItem.ToBeCount)
                {
                    this.counter = new CodeCounter(AppConfigurationManager.CurrentCountStandard.DestineLocation);
                    this.counter.OnCounted += this.codeCounter_OnCounted;
                    this.counter.RootDirectory = LOCConstants.TempPath + "\\" + counterItem.Name;
                    this.counter.DiffRootDirectory = LOCConstants.TempPath + "\\Diff\\" + counterItem.Name;
                    this.counter.ProcessSourceTree();
                    counterItem.PspMetricHash.Clear();
                    counterItem.PspMetricHash.Add("PspMetric", this.counter);
                    this.counterArray[num2] = this.counter;
                    num2++;
                    LineCounter[] lineCounters = this.counter.LineCounters;
                    Hashtable hashtable = new Hashtable();
                    counterItem.CounterDataSet.Clear();
                    foreach (LineCounter lineCounter in lineCounters)
                    {
                        this.UpdateFileCount(lineCounter.Name, lineCounter.AddedLines, hashtable, counterItem, frmCounter.UpdateType.Added);
                        this.UpdateFileCount(lineCounter.Name, lineCounter.DeletedLines, hashtable, counterItem, frmCounter.UpdateType.Deleted);
                        this.UpdateFileCount(lineCounter.Name, lineCounter.ModifiedLines, hashtable, counterItem, frmCounter.UpdateType.Modified);
                        this.UpdateFileCount(lineCounter.Name, lineCounter.LogicalLines, hashtable, counterItem, frmCounter.UpdateType.Base);
                    }
                    counterItem.CounterDataSet.Add(hashtable.Values);
                }
                Application.DoEvents();
            }
        }

        // Token: 0x06000031 RID: 49 RVA: 0x0000419C File Offset: 0x0000319C
        private void UpdateFileCount(string language, CounterData objData, Hashtable objFinalFileCount, CounterItem cItem, frmCounter.UpdateType uType)
        {
            Hashtable fileCounts = objData.GetFileCounts();
            foreach (object obj in fileCounts.Keys)
            {
                string text = (string)obj;
                string id = text.Substring(text.LastIndexOf("\\") + 1, 36);
                SCItem scitem = cItem.DownLoadItems[id];
                if (scitem != null)
                {
                    LineCounterData lineCounterData;
                    if (objFinalFileCount.ContainsKey(text))
                    {
                        lineCounterData = (LineCounterData)objFinalFileCount[text];
                    }
                    else
                    {
                        lineCounterData = new LineCounterData();
                        lineCounterData.Name = scitem.Path;
                        objFinalFileCount[text] = lineCounterData;
                        lineCounterData.Language = language;
                    }
                    if (cItem.Type == CIType.DATE_RANGE || cItem.Type == CIType.LABEL_CHANGESET || cItem.Type == CIType.ITEM_FOLDER || cItem.Type == CIType.BASEDTO_LABEL_CHANGESET || cItem.Type == CIType.DIFF_PREVIOUS || cItem.Type == CIType.LATEST_SET || cItem.Type == CIType.LATEST_WORKITEM)
                    {
                        if (uType == frmCounter.UpdateType.Added)
                        {
                            lineCounterData.AddedLine += (long)((CountInfo)fileCounts[text]).count;
                        }
                        else if (uType == frmCounter.UpdateType.Modified)
                        {
                            lineCounterData.ModifiedLine += (long)((CountInfo)fileCounts[text]).count;
                        }
                        else if (uType == frmCounter.UpdateType.Deleted)
                        {
                            lineCounterData.DeletedLine += (long)((CountInfo)fileCounts[text]).count;
                        }
                        else if (uType == frmCounter.UpdateType.Base)
                        {
                            if (scitem.SCDownloadType == DownloadType.Base || scitem.SCDownloadType == DownloadType.Both)
                            {
                                lineCounterData.Base += (long)((CountInfo)fileCounts[text]).count;
                            }
                            else if (scitem.SCDownloadType == DownloadType.Latest)
                            {
                                lineCounterData.AddedLine += (long)((CountInfo)fileCounts[text]).count;
                            }
                        }
                    }
                    else
                    {
                        lineCounterData.Base += (long)((CountInfo)fileCounts[text]).count;
                    }
                }
            }
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00004448 File Offset: 0x00003448
        private void DownloadCISet()
        {
            this.TotalDownloadItem = this.CISet.GetDownLoadItemCounts();
            this.SetProcBarFromThread(1, 1, this.TotalDownloadItem, 1);
            SourceControlManager.errorsOfDownload.Clear();
            frmCounterItems.m_SourceControlManager.Download(this.CISet.FilteredItems);

            if (SourceControlManager.errorsOfDownload.Count != 0)
            {
                string text = "Can not download the following files from server:\r\n";
                for (int i = 0; i < SourceControlManager.errorsOfDownload.Count; i++)
                {
                    text = text + SourceControlManager.errorsOfDownload[i] + "\r\n";
                }
                SourceControlManager.errorsOfDownload.Clear();
                frmMessage frmMessage = new frmMessage(text);
                frmMessage.ShowDialog();
                frmMessage.Dispose();
            }
        }

        // Token: 0x06000033 RID: 51 RVA: 0x00004503 File Offset: 0x00003503
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00004510 File Offset: 0x00003510
        private void ClosingThread()
        {
            while (this.countThread.IsAlive)
            {
                Thread.Sleep(500);
            }
            this.closedAllThread = true;
            this.SetProcBarFromThread(int.MinValue, -1, -1, -1);
        }

        // Token: 0x06000035 RID: 53 RVA: 0x00004554 File Offset: 0x00003554
        private void frmCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.countThread != null)
            {
                if (this.countThread.IsAlive)
                {
                    this.countThread.Abort();
                    if (this.closingThread == null)
                    {
                        this.closingThread = new Thread(new ThreadStart(this.ClosingThread));
                        this.closingThread.Start();
                    }
                    if (!this.closedAllThread)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        // Token: 0x04000022 RID: 34
        private CounterItemSet CISet;

        // Token: 0x04000023 RID: 35
        private bool Processing = false;

        // Token: 0x04000024 RID: 36
        private int TotalDownloadItem = 1;

        // Token: 0x04000025 RID: 37
        private ListViewItem lvwItem;

        // Token: 0x04000026 RID: 38
        private CodeCounter counter;

        // Token: 0x04000027 RID: 39
        public Thread countThread = null;

        // Token: 0x04000028 RID: 40
        public Thread closingThread = null;

        // Token: 0x04000029 RID: 41
        public bool closedAllThread = false;

        // Token: 0x0400002A RID: 42
        public CodeCounter[] counterArray;

        // Token: 0x02000008 RID: 8
        private enum UpdateType
        {
            // Token: 0x0400002C RID: 44
            Base,
            // Token: 0x0400002D RID: 45
            Added,
            // Token: 0x0400002E RID: 46
            Modified,
            // Token: 0x0400002F RID: 47
            Deleted
        }

        // Token: 0x02000009 RID: 9
        // (Invoke) Token: 0x06000037 RID: 55
        public delegate void SetListView_ProcessCallback(int itemNo, int imageIndex, int processInc, string msg);

        // Token: 0x0200000A RID: 10
        // (Invoke) Token: 0x0600003B RID: 59
        public delegate void ProgressBarSetCallback(int mode, int value1, int value2, int value3);
    }
}
