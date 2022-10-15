using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MS.IT.LOC.UI.CounterDataDataSetTableAdapters;

namespace MS.IT.LOC.UI
{
	// Token: 0x0200000F RID: 15
	public partial class frmReportViewer : Form
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000BD46 File Offset: 0x0000AD46
		public frmReportViewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000BD78 File Offset: 0x0000AD78
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000BD90 File Offset: 0x0000AD90
		public object DataSource
		{
			get
			{
				return this._dataSource;
			}
			set
			{
				this._dataSource = value;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000BD9C File Offset: 0x0000AD9C
		private void frmReportViewer_Load(object sender, EventArgs e)
		{
			if (this.ReportType == "Counter Result")
			{
				this.ReportResource = "MS.IT.LOC.UI.rptCounterResult.rdlc";
				this.CounterResult = (CounterResult)this._dataSource;
				this.CounterResultDataBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Name = "CounterResult_CounterResultData";
				reportDataSource.Value = this.CounterResultDataBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
				this.CountStandardBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource2 = new ReportDataSource();
				reportDataSource2.Name = "CounterResult_CountStandardData";
				reportDataSource2.Value = this.CountStandardBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
				this.CountResultFolderbindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource3 = new ReportDataSource();
				reportDataSource3.Name = "CounterResult_CounterResultFolderData";
				reportDataSource3.Value = this.CountResultFolderbindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
				this.CountResultExcludebindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource4 = new ReportDataSource();
				reportDataSource4.Name = "CounterResult_CounterResultExcludeData";
				reportDataSource4.Value = this.CountResultExcludebindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
				this.CountResultLanguagebindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource5 = new ReportDataSource();
				reportDataSource5.Name = "CounterResult_CounterResultLanguageData";
				reportDataSource5.Value = this.CountResultLanguagebindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource5);
				this.CounterResultMReportbindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource6 = new ReportDataSource();
				reportDataSource6.Name = "CounterResult_CounterResultMReportData";
				reportDataSource6.Value = this.CounterResultMReportbindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource6);
				this.rptViewer.LocalReport.ReportEmbeddedResource = this.ReportResource;
			}
			else if (this.ReportType == "PSP Count Result")
			{
				this.ReportResource = "MS.IT.LOC.UI.rptPSPCounterResult.rdlc";
				this.CounterResult = (CounterResult)this._dataSource;
				this.CounterResultDataBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Name = "CounterResult_CounterResultData";
				reportDataSource.Value = this.CounterResultDataBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
				this.CountStandardBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource2 = new ReportDataSource();
				reportDataSource2.Name = "CounterResult_CountStandardData";
				reportDataSource2.Value = this.CountStandardBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
				this.CountResultFolderbindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource3 = new ReportDataSource();
				reportDataSource3.Name = "CounterResult_CounterResultFolderData";
				reportDataSource3.Value = this.CountResultFolderbindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
				this.CountResultExcludebindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource4 = new ReportDataSource();
				reportDataSource4.Name = "CounterResult_CounterResultExcludeData";
				reportDataSource4.Value = this.CountResultExcludebindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
				this.CountResultLanguagebindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource5 = new ReportDataSource();
				reportDataSource5.Name = "CounterResult_CounterResultLanguageData";
				reportDataSource5.Value = this.CountResultLanguagebindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource5);
				this.CounterResultMReportbindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource6 = new ReportDataSource();
				reportDataSource6.Name = "CounterResult_CounterResultMReportData";
				reportDataSource6.Value = this.CounterResultMReportbindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource6);
				this.CountResultPspSummaryBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource7 = new ReportDataSource();
				reportDataSource7.Name = "CounterResult_CountResultPspSummary";
				reportDataSource7.Value = this.CountResultPspSummaryBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource7);
				this.CountResultPspDetailsBindingSource.DataSource = this.CounterResult;
				ReportDataSource reportDataSource8 = new ReportDataSource();
				reportDataSource8.Name = "CounterResult_CountResultPspDetails";
				reportDataSource8.Value = this.CountResultPspDetailsBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource8);
				this.rptViewer.LocalReport.ReportEmbeddedResource = this.ReportResource;
			}
			else
			{
				string reportType = this.ReportType;
				if (reportType != null)
				{
					if (!(reportType == "KLOC Report"))
					{
						if (!(reportType == "KLOC by Quarter by Application"))
						{
							if (reportType == "KLOC by Application")
							{
								this.ReportResource = "MS.IT.LOC.UI.rptKLOCbyApplication.rdlc";
							}
						}
						else
						{
							this.ReportResource = "MS.IT.LOC.UI.rptByQtrByApp.rdlc";
						}
					}
					else
					{
						this.ReportResource = "MS.IT.LOC.UI.rptKLOC.rdlc";
					}
				}
				this.CounterDataDataSet = (CounterDataDataSet)this._dataSource;
				this.TotalLOCBindingSource.DataSource = this.CounterDataDataSet;
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Value = this.TotalLOCBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
				this.ReportQuery1BindingSource.DataSource = this.CounterDataDataSet;
				reportDataSource = new ReportDataSource();
				reportDataSource.Value = this.ReportQuery1BindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
				this.ByQtrByApplicationBindingSource.DataSource = this.CounterDataDataSet;
				reportDataSource = new ReportDataSource();
				reportDataSource.Value = this.ByQtrByApplicationBindingSource;
				this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
				this.rptViewer.LocalReport.ReportEmbeddedResource = this.ReportResource;
				this.rptViewer.LocalReport.ReportEmbeddedResource = this.ReportResource;
				this.ReportQuery1TableAdapter.Fill(this.CounterDataDataSet.ReportQuery1);
				this.TotalLOCTableAdapter.Fill(this.CounterDataDataSet.TotalLOC);
				this.byQtrByApplicationTableAdapter.Fill(this.CounterDataDataSet.ByQtrByApplication);
			}
			this.Text = this.ReportType;
			this.rptViewer.RefreshReport();
		}

		// Token: 0x040000B2 RID: 178
		public string ReportType = "";

		// Token: 0x040000B3 RID: 179
		private string ReportResource = "";

		// Token: 0x040000B4 RID: 180
		private object _dataSource;
	}
}
