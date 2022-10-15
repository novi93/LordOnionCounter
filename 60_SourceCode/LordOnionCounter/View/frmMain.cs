using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LOC.Core;
using LOC.Entites;
using LOC.Extension;
using static LOC.Core.JsonHelper;
using LOC.Core.Counter;

namespace LOC.View
{
    public partial class FrmMain : Form
    {
        private readonly ILogger Logger;
        private ICount LocCounter;
        //fields
        private List<GridEntryEntity> grdViewModel;
        private Settings settings;
        private RegisteredProjectCollection[] lstProjectCollection;
        private TfsTeamProjectCollection tfsTPC;

        private string DefaultPath = @"D:\1";
        private string folderBase = @"Base";
        private string folderNew = @"New";
        private string _tfsConfigFile = "tfsConfig.json";
        private string _settingFile = "Settings.json";

        //public static SourceControlManager m_SourceControlManager = new SourceControlManager();
        public static Hashtable m_SCIForms = new Hashtable();

        public FrmMain()
        {
            InitializeComponent();

            InitialControlHandlers();
            AppConfigurationManager.AppMode = ExecutionMode.StandAlone;
            // init logger
            Global.Logger = new Core.UILogger(this.txtLog);
            this.Logger = Global.Logger;

            //JsonSerialization.WriteToJsonFile("Settings.json",new Settings());

            //ReadSetting("Settings.json");
            if (File.Exists(_settingFile))
            {
                this.settings = JsonSerialization.ReadFromJsonFile<Settings>(_settingFile);
                Settings.GtargetExtension = settings.targetExtension;
                Settings.GIgnoreName = settings.IgnoreName;
                Logger.WriteLine("Read end: " + _settingFile);
            }
            else
            {
                this.settings = new Settings();
                Logger.WriteLine(_settingFile + " Not Found");
            }
            if (File.Exists(_tfsConfigFile))
            {

                // read tfs config
                var tfsConfig = JsonSerialization.ReadFromJsonFile<tfsConfigEntity>(_tfsConfigFile);
                if (tfsConfig != null)
                {
                    var projectCollection = new TfsTeamProjectCollection(tfsConfig.Uri, tfsConfig.ClientCredentials);
                    // register
                    RegisteredTfsConnections.RegisterProjectCollection(projectCollection);
                    RefreshConnect(true);
                }
                Logger.WriteLine("Read end: " + _tfsConfigFile);
            }
            else
            {
                Logger.WriteLine(_tfsConfigFile + " Not Found");
            }

            Initbehavior();
        }

        private void Initbehavior()
        {
            LocCounter = new CountByApp(null, null, null, null);
        }

        //Defining all Control handler methods
        private void InitialControlHandlers()
        {
            this.grdViewModel = new List<GridEntryEntity>();

            var bindingList = new BindingList<GridEntryEntity>(this.grdViewModel);
            var source = new BindingSource(bindingList, null);
            dgvMain.DataSource = source;

        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            using (var dialog = new TeamProjectPicker(TeamProjectPickerMode.NoProject, false))
            {
                var result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    var projectCollection = dialog.SelectedTeamProjectCollection;
                    // save-in
                    JsonSerialization.WriteToJsonFile<tfsConfigEntity>(_tfsConfigFile, new tfsConfigEntity
                    {
                        Uri = projectCollection.Uri,
                        ClientCredentials = projectCollection.ClientCredentials
                    }
                    );

                    // register
                    RegisteredTfsConnections.RegisterProjectCollection(projectCollection);

                    RefreshConnect(true);
                }
            }
        }

        private void btnGetListCS_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var watch = System.Diagnostics.Stopwatch.StartNew();
                List<int> lsInputChangesetID = null;
                lsInputChangesetID = new List<int>();
                lsInputChangesetID = txtListCSID.Text.Split2Int();
                lsInputChangesetID.Sort();

                //todo
                Global.nChangesetIDFirst = lsInputChangesetID.First<int>();
                Global.nChangesetIDLast = lsInputChangesetID.Last<int>();

                //update grid
                var items = TfsHelper.GetInfo(lsInputChangesetID);
                items.ForEach(x => x.Check = true);
                items.Sort((x, y) => string.CompareOrdinal(x.DiffPath, y.DiffPath));
                this.grdViewModel = items;
                //todo binding
                var bindingList = new BindingList<GridEntryEntity>(items);
                var source = new BindingSource(bindingList, null);
                dgvMain.DataSource = source;
                watch.Stop();
                Logger.WriteLine("DONE! " + watch.ElapsedMilliseconds / 60000.0 + " min");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnGetCss_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lblWorkItemName.Text = string.Empty;
                Global.Logger.WriteLine("get changesets by WorkItem");
                int WorkItemId;
                if (int.TryParse(txtWorkItem.Text, out WorkItemId))
                {
                    var workInfo = TfsHelper.GetChangesets(WorkItemId);
                    var changesets = workInfo.Item2;
                    changesets.Sort((x, y) => x.ChangesetId - y.ChangesetId);
                    lblWorkItemName.Text = workInfo.Item1.Title + "( PRJ:" + workInfo.Item1.AreaPath + ")";
                    //workInfo.Item1.DisplayForm
                    txtListCSID.Text = string.Join<int>(", ", changesets.Select(x => x.ChangesetId));
                }
                else
                {
                    throw new Exception("Number Plz!!!!!!!!!!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var folder = Guid.NewGuid().ToString();
                 DownloadContent(this.grdViewModel.Where(x => x.Check), folder);

                var newFolderPath = Path.Combine(this.DefaultPath, folder, this.folderNew);

                var baseFolderPath = Path.Combine(this.DefaultPath, folder, this.folderBase);
                Global.Logger.WriteLine("Config Preparing....");

                string clean = Regex.Replace(lblWorkItemName.Text, "[^A-Za-z0-9]", "");
                var CounterItemName = (string.IsNullOrWhiteSpace(clean)) ? folder : clean;
                LocCounter = new CountByApp(Path.Combine(this.DefaultPath, folder), newFolderPath, baseFolderPath, CounterItemName);
                LocCounter.Config();
                LocCounter.RunCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void DownloadContent(IEnumerable<GridEntryEntity> lst, string folder)
        {
            var lstOuput = lst.Where(x => x.Check && x.IsFile);
            var cntTotal = lstOuput.Count();
            int cntCurrent = 1;
            foreach (var item in lstOuput)
            {
                var filename = string.Concat(item.ItemId, Path.GetExtension(item.DiffPath));
                Debug.WriteLine(string.Format("({0}\\{1})Downloading... {2}", cntCurrent, cntTotal, filename));
                item.NewItem.Item.DownloadFile(Path.Combine(this.DefaultPath, folder, this.folderNew, filename));
                if (!item.IsNew && item.BaseItem != null)
                {
                    item.BaseItem.DownloadFile(Path.Combine(this.DefaultPath, folder, this.folderBase, filename));
                }
                cntCurrent++;
            }

        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

         private void RefreshConnect(bool _bIsNew)
        {
            lstProjectCollection = RegisteredTfsConnections.GetProjectCollections();

            if (_bIsNew)
            {
                SetTeamProjectCollection(lstProjectCollection, lstProjectCollection[0]);
            }
            else
            {
                if (lstProjectCollection.Length > 0)
                {
                    SetTeamProjectCollection(lstProjectCollection, lstProjectCollection[0]);
                }
            }
        }

        private void SetTeamProjectCollection(RegisteredProjectCollection[] lstProjectCollection, RegisteredProjectCollection indexRPC)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (RegisteredProjectCollection rpc in lstProjectCollection)
            {
                TfsTeamProjectCollection tfs = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(rpc);
                comboSource.Add(tfs.Name, tfs.Name);
            }

            cmbTeamProjectCollection.DataSource = new BindingSource(comboSource, null);
            cmbTeamProjectCollection.DisplayMember = "Key";
            cmbTeamProjectCollection.ValueMember = "Value";

            cmbTeamProjectCollection.SelectedValue = indexRPC.Name;
            tfsTPC = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(indexRPC.Uri);
            RefreshlsvTeamProject();
        }

        private void SetDisplayNameCMBTeamProjectCollection(TfsTeamProjectCollection projectCollection)
        {
            tfsTPC = projectCollection;
        }

        private void RefreshlsvTeamProject()
        {
            //lsvTeamProject.Clear();
            if (tfsTPC != null)
            {
                Global.vcServer = tfsTPC.GetService<VersionControlServer>();
                Global.tfsTPC = tfsTPC;
                ItemSet itemSet = Global.vcServer.GetItems("$/", RecursionType.OneLevel);
                foreach (Item item in itemSet.Items)
                {
                    if (item.ServerItem != "$/")
                    {
                        string text = item.ServerItem.Substring(2, item.ServerItem.Length - 2);
                        string tag = item.ServerItem;
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = text;
                        listViewItem.Tag = tag;
                        //lsvTeamProject.Items.Add(listViewItem);
                    }
                }
                this.Text = Global.vcServer.AuthorizedUser + " aka " + Global.vcServer.AuthorizedIdentity.DisplayName;
            }
        }
    }
}