using LOC.Core.Helper;
using LOC.Entites;
using LOC.Entites.Count;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LOC.View
{
    public partial class FrmCountResult : Form
    {
        public CountResult Model { get; set; }
        public Dictionary<string, string> dictFilename;

        public FrmCountResult()
        {
            InitializeComponent();
            //dgvdetail.SummaryColumns = new string[] { "Add_Mod_Del" };
        }

        protected void RefreshGrid()
        {
            var files = Model.Added.Concat(Model.Same)
                .Concat(Model.Modified)
                .Concat(Model.Removed)
                .Select(x => x.name)
                .Distinct();

            var Same = Model.Same.Select(x => new CountDetailGrdEntity
            {
                File = dictFilename[x.Id],
                Same_Code = x.code,
                Added_Code = 0,
                Modified_Code = 0,
                Removed_Code = 0,
            });
            var Added = Model.Added.Select(x => new CountDetailGrdEntity
            {
                File = dictFilename[x.Id],
                Same_Code = 0,
                Added_Code = x.code,
                Modified_Code = 0,
                Removed_Code = 0,
            });
            var Modified = Model.Modified.Select(x => new CountDetailGrdEntity
            {
                File = dictFilename[x.Id],
                Same_Code = 0,
                Added_Code = 0,
                Modified_Code = x.code,
                Removed_Code = 0,
            });
            var Removed = Model.Removed.Select(x => new CountDetailGrdEntity
            {
                File = dictFilename[x.Id],
                Same_Code = 0,
                Added_Code = 0,
                Modified_Code = 0,
                Removed_Code = x.code,
            });

            var detail = Same.Concat(Added)
                            .Concat(Modified)
                            .Concat(Removed)
                            .GroupBy(t => t.File)
                            .Select(a => new CountDetailGrdEntity
                            {
                                File = Path.GetFileName(a.Key),
                                FullPath = a.Key,
                                Same_Code = a.Sum(x => x.Same_Code),
                                Added_Code = a.Sum(x => x.Added_Code),
                                Modified_Code = a.Sum(x => x.Modified_Code),
                                Removed_Code = a.Sum(x => x.Removed_Code),
                                PercentSame = SettingHelper.GetSamePercent(a.Key),
                                PercentChurch = SettingHelper.GetCountPercent(a.Key)
                            }
                            )
                            .ToList();

            detail.Sort((x, y) => string.CompareOrdinal(x.File, y.File));

            var bindingDetail = new BindingList<CountDetailGrdEntity>(detail);
            dgvdetail.DataSource = new BindingSource(bindingDetail, null); ;

            //var bindingHeader = new BindingList<KeyValuePair<string, object>>(Model.Header.PropertiesOfType().ToList());
            //dgvHeader.DataSource = new BindingSource(bindingHeader, null);

            //var sumary = detail
            //                .GroupBy(t => "")
            //                .Select(a =>  new {
            //                    File = "★★★　SUMARY　★★★",
            //                    FullPath = "",
            //                    Same_Code = a.Sum(x => x.Same_Code),
            //                    Added_Code = a.Sum(x => x.Added_Code),
            //                    Modified_Code = a.Sum(x => x.Modified_Code),
            //                    Removed_Code = a.Sum(x => x.Removed_Code),
            //                    LOC = a.Sum(x => x.Add_Mod_Del)
            //                }
            //                );

            ////var bindingSumary = new BindingList<KeyValuePair<string, int>>(Model.Sumary.Select(x => new KeyValuePair<string, int>(x.name, x.code)).ToList());
            //var bindingSumary = new BindingList<object>(sumary);
            //dgvSumary.DataSource = new BindingSource(bindingSumary, null);
            //dgvdetail.RefreshSummary();
        }

        private void FrmCountResult_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            lblCopyRight.Text = string.Concat(App.VersionLabel(), "      ", "　®Created by Sói đi dép lào");
        }

        /// <summary>
        /// Exit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) => Close();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Button btn;
            switch (keyData)
            {
                case Keys.F12:
                    btn = BtnExit;
                    if (btn.Enabled && btn.Visible)
                    {
                        btn.PerformClick();
                    }
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void dgvdetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvdetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                var grd = (DataGridView)sender;
                var column = grd.Columns[e.ColumnIndex];
                var row = grd.Rows[e.RowIndex];
                if (column.ReadOnly)
                {
                    return;
                }
                if (grd.SelectedCells.Count <= 0)
                {
                    return;
                }

                var cell = grd.SelectedCells[0];

                if (column.ValueType == typeof(int))
                {
                    if (!int.TryParse(cell.Value.ToString(), out int rs))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                if (column.ValueType == typeof(decimal))
                {
                    if (!decimal.TryParse(cell.Value.ToString(), out decimal rs))
                    {
                        e.Cancel = true;
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, App.AppName);

            }
        }

        private void dgvdetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            dgvdetail.RefreshSummary();
        }

        private void FrmCountResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    var dRs = MessageBox.Show(this, "Exit?", App.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //    if (dRs != DialogResult.Yes)
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //catch
            //{
            //    Dispose();
            //}
        }

        private void dgvdetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            var SumCol  = new List<string>() ;
            foreach (DataGridViewColumn column in dgvdetail.Columns)
            {
                if (column.ValueType == typeof(int))
                {
                   SumCol.Add(column.Name);
                }
             
            }
            if (SumCol.Count >0)
            {
                dgvdetail.SummaryColumns = SumCol.ToArray();
            }
        }
    }
}