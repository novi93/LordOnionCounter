using LOC.Core.Factory;
using LOC.Core.Helper;
using LOC.Entites;
using LOC.Entites.Count;
using LOC.VM.CountPG;
using Microsoft.TeamFoundation.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LOC.View
{
    public partial class FrmCountPG : Form
    {

        private CountPgVM VM;

        private int SideBarWidth;

        public FrmCountPG(CountPgVM ViewModel)
        {
            InitializeComponent();

            VM = ViewModel;

            Global.Logger = new Core.Logger.UILogger(txtLog);

            VM.LoadAppSetting();

            InitialControlHandlers();

            ConnectTfs(new Uri(ConfigurationManager.AppSettings.Get("ProcessTeamUri")));

            Bind();

            this.TxtWorkItem.Focus();
        }

        private void ConnectTfs(Uri Uri)
        {
            TfsHelper.Connect(Uri);
            this.Text = string.Format("{0} - Connecting to {1} as {2} ", App.AppName, Uri, TfsHelper.tfsTPC.AuthorizedIdentity.DisplayName);
        }

        private void FrmCountPG_Load(object sender, EventArgs e)
        {
            lblCopyRight.Text = $"{App.VersionLabel()}          {App.CopyRight}";

            SideBarWidth = splPanel.Panel2.Width;
#if DEBUG
            splPanel.Panel2Collapsed = false;
#else
            this.Size = new System.Drawing.Size(Size.Width - SideBarWidth, Size.Height);
            splPanel.Panel2Collapsed = true;
#endif
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Button btn;

            switch (keyData)
            {
                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    return base.ProcessCmdKey(ref msg, keyData);
                case Keys.F2:
                    btn = BtnCheckAll;
                    break;
                case Keys.F3:
                    btn = btnInvertcheck;
                    break;
                case Keys.F11:
                    btn = btnExport;
                    break;
                case Keys.F12:
                    btn = btnExit;
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            if (btn.Enabled && btn.Visible)
            {
                btn.PerformClick();
            }
            return true;
        }

        private void FrmCountPG_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var dRs = MessageBox.Show(this, "Exit?", App.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dRs != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            catch
            {
                Dispose();
            }
        }

        #region Loading



        //Defining all Control handler methods
        private void InitialControlHandlers()
        {
            VM.Initial();
            RefreshGrid();
            RefreshChangesetGrid();
        }
        #endregion

        #region Header

        /// <summary>
        /// load file to grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetListCS_Click(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();
                Cursor = Cursors.WaitCursor;
                RefreshGrid();
                var checkedCS = VM.CheckedChangeSet;
                if (!checkedCS.Any())
                {
                    throw new Exception("Select at least one Changeset");
                }

                GetChanges(checkedCS.Select(x => x.ChangesetId));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
            finally
            {
                ResumeLayout(true);
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// load changeset from WorkItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetCss_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                VM.ClearGridChange();
                RefreshGrid();

                VM.GetCsList();

                VM.GetChanges();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private void TxtWorkItem_Validating(object sender, CancelEventArgs e)
        {
            var txtWi = (TextBox)sender;
            var wi = txtWi.Text;

            try
            {

                this.SuspendLayout();
                Cursor = Cursors.WaitCursor;

                // old value
                if (wi.Equals(VM._workItemOld))
                {
                    return;
                }

                // clear title 
                lblWorkItemName.Text = string.Empty;

                // clear
                VM.ClearGridChangeset();
                VM.ClearGridChange();
                RefreshChangesetGrid();
                RefreshGrid();

                // save old value
                VM.WorkItem = wi;
                VM._workItemOld = wi;

                var rs = int.TryParse(wi, out int intWi);
                // emty
                if (rs == false || intWi == 0)
                {
                    wi = string.Empty;
                }

                // emty
                if (string.IsNullOrWhiteSpace(wi))
                {
                    return;
                }

                // getdata
                VM.GetCsList();
                VM.GetChanges();

                RefreshChangesetGrid();
                RefreshGrid();


                if (VM.IsGodMode)
                {

                    var Request = CountResquestFactory.Create(VM.Gui);

                    Download(Request);
                    var countRs = VM.Count(Request);
                    ShowReport(countRs);
                    Global.Logger.WriteLine("Done!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
            finally
            {
                this.ResumeLayout(true);
                Cursor = Cursors.Default;
            }
        }

        private void TxtWorkItem_Enter(object sender, EventArgs e) => VM._workItemOld = TxtWorkItem.Text;

        private void BtnCheckAllCs_Click(object sender, EventArgs e)
        {

            VM.ClearGridChange();
            RefreshGrid();

            VM.CheckAllChangeSet();
            RefreshChangesetGrid();
        }

        private void BtnInvertCheckCs_Click(object sender, EventArgs e)
        {

            VM.ClearGridChange();
            RefreshGrid();

            VM.InvertCheckChangeSet();
            RefreshChangesetGrid();
        }
        #endregion

        #region Grid
        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                VM.CheckAllChange();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

        private void BtnInvertCheck_Click(object sender, EventArgs e)
        {
            try
            {

                VM.InvertCheckChange();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                //TODo So stupid.cant it auto?
                var bindingList = new BindingList<GridEntryEntity>(VM.grdViewModel);
                dgvMain.DataSource = new BindingSource(bindingList, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

        private void RefreshChangesetGrid()
        {
            try
            {
                // TODo So stupid. cant it auto?
                var bindingList = new BindingList<GridChangesetEntryEntity>(VM.grdChangesetVM);
                dgvChangeset.DataSource = new BindingSource(bindingList, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }
        private void DgvChangeset_CellContentClick(object sender,
            DataGridViewCellEventArgs e)
        {
            dgvChangeset.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        /// <summary>
        /// Works with the above.
        /// </summary>
        private void DgvChangeset_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            VM.ClearGridChange();
            RefreshGrid();
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
            try
            {
                Cursor = Cursors.WaitCursor;

                if (VM.IsGodMode)
                {
                    var Request = CountResquestFactory.Create(VM.Gui);

                    VM.GetCsList();

                    VM.GetChanges();
                    RefreshGrid();

                    Download(Request);

                    var countRs = VM.Count(Request);

                    ShowReport(countRs);
                    Global.Logger.WriteLine("DONE ALL! ");
                }
                else
                {
                    if (!VM.CheckedChange.Any())
                    {
                        throw new Exception("Nothing to Count!");
                    }

                    var Request = CountResquestFactory.Create(VM.Gui);

                    Download(Request);
                    var countRs = VM.Count(Request);
                    ShowReport(countRs);
                    Global.Logger.WriteLine("Done!");
                }
            }
            catch (Exception ex)
            {
                Global.Logger.WriteLine("ERR!" + ex.StackTrace);
                MessageBox.Show(ex.Message, App.AppName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
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
        private void BtnCollapse_Click(object sender, EventArgs e)
        {
            try
            {
                if (splPanel.Panel2Collapsed)
                {
                    this.Size = new System.Drawing.Size(Size.Width + SideBarWidth, Size.Height);
                    splPanel.Panel2Collapsed = false;
                }
                else
                {
                    SideBarWidth = splPanel.Panel2.Width;
                    this.Size = new System.Drawing.Size(Size.Width - SideBarWidth, Size.Height);
                    splPanel.Panel2Collapsed = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

        private void BtnNewGui_Click(object sender, EventArgs e) => VM.Gui = Guid.NewGuid().ToString();

        private void BtnClearCache_Click(object sender, EventArgs e)
        {
            try
            {
                VM.GC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                IOHelper.DeleteFolderIfExist(CountResquestFactory.GetDefaultPath());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }

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

        private void BtnClearLog_Click(object sender, EventArgs e) => txtLog.Clear();

        private void BtnAddServer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new TeamProjectPicker(TeamProjectPickerMode.NoProject, false))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var projectCollection = dialog.SelectedTeamProjectCollection;

                        ConnectTfs(projectCollection.Uri);

                        // register
                        RegisteredTfsConnections.RegisterProjectCollection(projectCollection);

                        // save-in
                        ConfigurationManager.AppSettings.Set("ProcessTeamUri", projectCollection.Uri.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }
        #endregion
        #region Action
        private void GetChanges(IEnumerable<int?> lsInputChangesetID)
        {
            //update grid model
            VM.GetChanges();

            //refresh
            RefreshGrid();
        }
        private void Download(CountResquest Request)
        {
            if (!IOHelper.IsEmptyFolder(Request.NewFolder))
            {
                var dRs = MessageBox.Show("Count folder is not Empty. Delete then download again?",
                                         "Download Again?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2);
                if (dRs == DialogResult.Yes)
                {
                    VM.GC(Request);
                    VM.Download(Request);
                }
            }
            else
            {
                VM.Download(Request);
            }
        }
        private void ShowReport(CountResult countRs)
        {
            Global.Logger.WriteLine("Report Showing...");
            var dict = VM.grdViewModel.ToDictionary(
                        keyselector => keyselector.Id.ToString(),
                        elementSelector => elementSelector.MinItem.Item.ServerItem
                    );
            new FrmCountResult { Model = countRs, dictFilename = dict }.ShowDialog();
        }
        #endregion

        #region Notify
        private void Bind()
        {
            LblGuid.DataBindings.Add(new Binding("Text", VM, "Gui"));

            TxtWorkItem.DataBindings.Add(new Binding("Text", VM, "WorkItem"));
            lblWorkItemName.DataBindings.Add(new Binding("Text", VM, "WorkItemName"));


            chkGodMode.DataBindings.Add(new Binding("Checked", VM, "IsGodMode", true, DataSourceUpdateMode.OnPropertyChanged));
            pnlCs.DataBindings.Add(new Binding("Visible", VM, "IsNormalMode"));
            pnlBody.DataBindings.Add(new Binding("Visible", VM, "IsNormalMode"));
            //btnExport.DataBindings.Add(new Binding("Visible", VM, "IsNormalMode"));
            BtnCheckAll.DataBindings.Add(new Binding("Visible", VM, "IsNormalMode"));
            btnInvertcheck.DataBindings.Add(new Binding("Visible", VM, "IsNormalMode"));
            chkCntDesigner.DataBindings.Add(new Binding("Checked", SettingHelper.Settings, "IsCountDesigner", true, DataSourceUpdateMode.OnPropertyChanged));


            txtDesignPercent.DataBindings.Add(new Binding("Enabled",SettingHelper.Settings, "IsCountDesigner"));
            txtDesignPercent.DataBindings.Add(new Binding("Text", SettingHelper.Settings, "PercentCountDesigner", true, DataSourceUpdateMode.OnPropertyChanged));

            var bindingListDgvMain = new BindingList<GridEntryEntity>(VM.grdViewModel);
            dgvMain.DataSource = new BindingSource(bindingListDgvMain, null);

            var bindingListDgvChangeset = new BindingList<GridChangesetEntryEntity>(VM.grdChangesetVM);
            dgvChangeset.DataSource = new BindingSource(bindingListDgvChangeset, null);
        }

        #endregion

        private void txtDesignPercent_Validating(object sender, CancelEventArgs e)
        {
            var Control = (TextBox)sender;
            var ControlValue = Control.Text;

            try
            {
                var rs = decimal.TryParse(ControlValue, out decimal outValue);
                // parse error
                if (rs == false)
                {
                    Control.Focus();
                    e.Cancel = true;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, App.AppName);
            }
        }
    }
}
