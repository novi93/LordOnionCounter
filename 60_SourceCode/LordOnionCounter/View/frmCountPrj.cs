using LOC.Core.Counter;
using LOC.Core.Downloader;
using LOC.Core.Helper;
using LOC.Core.Logger;
using LOC.Entites;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using static LOC.Core.Helper.JsonHelper;

namespace LOC.View
{
    public partial class FrmCountPrj : Form
    {
        //behavior
        private ICount LocCounter;
        private IDownloader Downloader;

        //fields
        private List<GridWI> grdViewModel;

        private Settings settings;
        private string SettingFile = @"Settings.json";

        public FrmCountPrj()
        {
            InitializeComponent();

            Initbehavior();

            LoadAppSetting();

            InitialControlHandlers();

            TfsHelper.Connect(new Uri(ConfigurationManager.AppSettings.Get("ProcessTeamUri")));

            LoadPrjDatasouce();

#if DEBUG
            splPanel.Panel2Collapsed = false;
#endif
        }

        #region Loading
        /// <summary>
        /// Load appsetting then stored in local variable
        /// </summary>
        private void LoadAppSetting()
        {
            SettingFile = ConfigurationManager.AppSettings["SettingFile"];

            //ReadSetting("Settings.json");
            if (File.Exists(SettingFile))
            {
                settings = JsonSerialization.ReadFromJsonFile<Settings>(SettingFile);
                Settings.GtargetExtension = settings.targetExtension;
                Settings.GIgnoreName = settings.IgnoreName;
                Global.Logger.WriteLine("Read end: " + SettingFile);
            }
            else
            {
                settings = new Settings();
                Global.Logger.WriteLine(SettingFile + " Not Found");
            }
        }

        private void Initbehavior()
        {
            Global.Logger = new UILogger(txtLog);

            LocCounter = new CountByClocCli();
            //LocCounter = new CountByInSource(null, null, null, null);
            Downloader = new TfsDownloader();
        }

        //Defining all Control handler methods
        private void InitialControlHandlers()
        {
            grdViewModel = new List<GridWI>();
            RefreshGrid();
        }

        private void LoadPrjDatasouce()
        {
            var comboSource = TfsHelper.GetPrjDict();
            cbbPrj.DataSource = new BindingSource(comboSource, null);
            cbbPrj.DisplayMember = "Key";
            cbbPrj.ValueMember = "Value";

            //cbbPrj.SelectedValue = indexRPC.Name;
        }
        #endregion

        #region Header

        #endregion

        #region Grid
        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            grdViewModel.ForEach(x => x.Check = true);
            RefreshGrid();

        }

        private void BtnUncheckAll_Click(object sender, EventArgs e)
        {
            grdViewModel.ForEach(x => x.Check = false);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            //var bindingList = new BindingList<GridWI>(grdViewModel);
            //var source = new BindingSource(bindingList, null);
            //dgvMain.DataSource = source;
        }

        #endregion

        #region Footer

        /// <summary>
        /// download content from tfs server then setting LOC counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    Cursor = Cursors.WaitCursor;

            //    var FolderGUI = Guid.NewGuid().ToString();
            //    var newFolderPath = Path.Combine(DefaultPath, FolderGUI, FolderNewName);
            //    var baseFolderPath = Path.Combine(DefaultPath, FolderGUI, FolderBaseName);
            //    var clean = Regex.Replace(lblWorkItemName.Text, "[^A-Za-z0-9]", "");

            //    Global.Logger.WriteLine("Download Preparing...");
            //    Downloader.Download(grdViewModel.Where(x => x.Check), baseFolderPath, newFolderPath);
            //    Global.Logger.WriteLine("Download Done!");

            //    //var CounterItemName = (string.IsNullOrWhiteSpace(clean)) ? FolderGUI : clean;
            //    LocCounter.removeAllCI();
            //    var date = DateTime.Now.ToString("yyyyMMdd_HHMM");

            //    var CounterItemName = string.Concat(date, "_", clean, "_", FolderGUI);
            //    Global.Logger.WriteLine("Config Preparing : " + CounterItemName);
            //    LocCounter.Config(Path.Combine(this.DefaultPath, FolderGUI), newFolderPath, baseFolderPath, CounterItemName);
            //    //LocCounter.Config();
            //    Global.Logger.WriteLine("Count Preparing : " + CounterItemName);
            //    LocCounter.RunCount();
            //    Global.Logger.WriteLine("Count Done!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //}
        }

        /// <summary>
        /// Exit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) => Close();

        #endregion

        #region Sidebar

        /// <summary>
        /// collapse right side bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCollapse_Click(object sender, EventArgs e) => splPanel.Panel2Collapsed = !splPanel.Panel2Collapsed;

        /// <summary>
        /// scroll to bottom of logger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        /// <summary>
        /// clear log content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearLog_Click(object sender, EventArgs e) => txtLog.Clear();

        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                Microsoft.TeamFoundation.Server.ProjectInfo prj = (Microsoft.TeamFoundation.Server.ProjectInfo)cbbPrj.SelectedValue;

                //update grid
                var Wis = TfsHelper.GetWorkItemList(prj, txtSearch.Text);
                var items = new List<GridWI>();
                foreach (WorkItem wi in Wis)
                {
                    items.Add(new GridWI
                    {
                        Id = wi.Id,
                        Title = wi.Title,
                        CreatedBy = wi.CreatedBy,
                        BaseLOC = 0,
                        ChurchLOC = 0
                    });
                }

                grdViewModel = items;

                //todo find way to auto binding 
                //binding
                RefreshGrid();

                // log
                Global.Logger.WriteLine("Load WorkItem : DONE! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}