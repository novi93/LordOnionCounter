using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000010 RID: 16
	public partial class frmReports : Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000CA7E File Offset: 0x0000BA7E
		public frmReports()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000CA98 File Offset: 0x0000BA98
		private void btnRun_Click(object sender, EventArgs e)
		{
			if (this.cboReportType.SelectedItem != null)
			{
				this.objReportViewer = new frmReportViewer();
				this.objReportViewer.WindowState = FormWindowState.Maximized;
				this.objReportViewer.ReportType = this.cboReportType.SelectedItem.ToString();
				this.objReportViewer.ShowDialog();
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000CAF9 File Offset: 0x0000BAF9
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000CB03 File Offset: 0x0000BB03
		private void frmReports_Load(object sender, EventArgs e)
		{
			this.cboReportType.SelectedIndex = 0;
			this.cboReportType.Select();
		}

		// Token: 0x040000C8 RID: 200
		private frmReportViewer objReportViewer;
	}
}
