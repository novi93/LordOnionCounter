using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000023 RID: 35
	public partial class frmAbout : Form
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00012F36 File Offset: 0x00011F36
		public frmAbout()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00012F4F File Offset: 0x00011F4F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00012F5C File Offset: 0x00011F5C
		private void About_Load(object sender, EventArgs e)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			this.txtVersion.Text = executingAssembly.GetName().Version.ToString();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00012F8C File Offset: 0x00011F8C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start("Loc Counter License.rtf");
			}
			catch
			{
				MessageBox.Show("The file can't be found !");
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00012FCC File Offset: 0x00011FCC
		private void lblVersion_Click(object sender, EventArgs e)
		{
		}
	}
}
