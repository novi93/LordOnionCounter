namespace MS.IT.LOC.UI
{
	// Token: 0x0200000F RID: 15
	public partial class frmReportViewer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000C410 File Offset: 0x0000B410
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000C448 File Offset: 0x0000B448
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmReportViewer));
			this.TotalLOCBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CounterDataDataSet = new global::MS.IT.LOC.UI.CounterDataDataSet();
			this.ReportQuery1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ByQtrByApplicationBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CounterResultDataBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CounterResult = new global::MS.IT.LOC.UI.CounterResult();
			this.rptViewer = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.ReportQuery1TableAdapter = new global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ReportQuery1TableAdapter();
			this.TotalLOCTableAdapter = new global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.TotalLOCTableAdapter();
			this.byQtrByApplicationTableAdapter = new global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ByQtrByApplicationTableAdapter();
			this.CountStandardBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CountResultFolderbindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CountResultExcludebindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CountResultLanguagebindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CounterResultMReportbindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.M_Report_BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CountResultPspSummaryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.CountResultPspDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.TotalLOCBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterDataDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportQuery1BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ByQtrByApplicationBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResultDataBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResult).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountStandardBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultFolderbindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultExcludebindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultLanguagebindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResultMReportbindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.M_Report_BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultPspSummaryBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultPspDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.TotalLOCBindingSource.DataMember = "TotalLOC";
			this.TotalLOCBindingSource.DataSource = this.CounterDataDataSet;
			this.CounterDataDataSet.DataSetName = "CounterDataDataSet";
			this.CounterDataDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ReportQuery1BindingSource.DataMember = "ReportQuery1";
			this.ReportQuery1BindingSource.DataSource = this.CounterDataDataSet;
			this.ByQtrByApplicationBindingSource.DataMember = "ByQtrByApplication";
			this.ByQtrByApplicationBindingSource.DataSource = this.CounterDataDataSet;
			this.CounterResultDataBindingSource.DataMember = "CounterResultData";
			this.CounterResultDataBindingSource.DataSource = this.CounterResult;
			this.CounterResult.DataSetName = "CounterResult";
			this.CounterResult.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.rptViewer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CounterDataDataSet_TotalLOC";
			reportDataSource.Value = this.TotalLOCBindingSource;
			reportDataSource2.Name = "CounterDataDataSet_ReportQuery1";
			reportDataSource2.Value = this.ReportQuery1BindingSource;
			reportDataSource3.Name = "CounterDataDataSet_ByQtrByApplication";
			reportDataSource3.Value = this.ByQtrByApplicationBindingSource;
			this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
			this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
			this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
			this.rptViewer.LocalReport.ReportEmbeddedResource = "MS.IT.LOC.UI.rptByQtrByApp.rdlc";
			this.rptViewer.Location = new global::System.Drawing.Point(0, 0);
			this.rptViewer.Name = "rptViewer";
			this.rptViewer.Size = new global::System.Drawing.Size(597, 311);
			this.rptViewer.TabIndex = 0;
			this.ReportQuery1TableAdapter.ClearBeforeFill = true;
			this.TotalLOCTableAdapter.ClearBeforeFill = true;
			this.byQtrByApplicationTableAdapter.ClearBeforeFill = true;
			this.CountStandardBindingSource.DataMember = "CountStandardData";
			this.CountStandardBindingSource.DataSource = this.CounterResult;
			this.CountResultFolderbindingSource.DataMember = "CounterResultFolderData";
			this.CountResultFolderbindingSource.DataSource = this.CounterResult;
			this.CountResultExcludebindingSource.DataMember = "CounterResultExcludeData";
			this.CountResultExcludebindingSource.DataSource = this.CounterResult;
			this.CountResultLanguagebindingSource.DataMember = "CounterResultLanguageData";
			this.CountResultLanguagebindingSource.DataSource = this.CounterResult;
			this.CounterResultMReportbindingSource.DataMember = "CounterResultMReportData";
			this.CounterResultMReportbindingSource.DataSource = this.CounterResult;
			this.M_Report_BindingSource.DataMember = "CounterResultMReportData";
			this.M_Report_BindingSource.DataSource = this.CounterResult;
			this.CountResultPspSummaryBindingSource.DataMember = "CountResultPspSummary";
			this.CountResultPspSummaryBindingSource.DataSource = this.CounterResult;
			this.CountResultPspDetailsBindingSource.DataMember = "CountResultPspDetails";
			this.CountResultPspDetailsBindingSource.DataSource = this.CounterResult;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(597, 311);
			base.Controls.Add(this.rptViewer);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmReportViewer";
			this.Text = "Report Viewer";
			base.Load += new global::System.EventHandler(this.frmReportViewer_Load);
			((global::System.ComponentModel.ISupportInitialize)this.TotalLOCBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterDataDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportQuery1BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ByQtrByApplicationBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResultDataBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResult).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountStandardBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultFolderbindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultExcludebindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultLanguagebindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CounterResultMReportbindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.M_Report_BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultPspSummaryBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CountResultPspDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B5 RID: 181
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.BindingSource ReportQuery1BindingSource;

		// Token: 0x040000B7 RID: 183
		private global::MS.IT.LOC.UI.CounterDataDataSet CounterDataDataSet;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.BindingSource TotalLOCBindingSource;

		// Token: 0x040000B9 RID: 185
		private global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ReportQuery1TableAdapter ReportQuery1TableAdapter;

		// Token: 0x040000BA RID: 186
		private global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.TotalLOCTableAdapter TotalLOCTableAdapter;

		// Token: 0x040000BB RID: 187
		private global::MS.IT.LOC.UI.CounterDataDataSetTableAdapters.ByQtrByApplicationTableAdapter byQtrByApplicationTableAdapter;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.BindingSource ByQtrByApplicationBindingSource;

		// Token: 0x040000BD RID: 189
		private global::Microsoft.Reporting.WinForms.ReportViewer rptViewer;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.BindingSource CounterResultDataBindingSource;

		// Token: 0x040000BF RID: 191
		private global::MS.IT.LOC.UI.CounterResult CounterResult;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.BindingSource CountStandardBindingSource;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.BindingSource CountResultFolderbindingSource;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.BindingSource CountResultExcludebindingSource;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.BindingSource CountResultLanguagebindingSource;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.BindingSource CounterResultMReportbindingSource;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.BindingSource M_Report_BindingSource;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.BindingSource CountResultPspSummaryBindingSource;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.BindingSource CountResultPspDetailsBindingSource;
	}
}
