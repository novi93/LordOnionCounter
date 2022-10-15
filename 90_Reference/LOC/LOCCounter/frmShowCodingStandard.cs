using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x0200000E RID: 14
	public partial class frmShowCodingStandard : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000B028 File Offset: 0x0000A028
		public frmShowCodingStandard()
		{
			this.InitializeComponent();
			if (AppConfigurationManager.LocalCountStandard != null)
			{
				this.txtLocalPath.Text = AppConfigurationManager.LocalCountStandard.SourceLocation;
			}
			if (AppConfigurationManager.RemoteCountStandard != null)
			{
				this.txtInternet.Text = AppConfigurationManager.RemoteCountStandard.SourceLocation;
				if (AppConfigurationManager.RemoteCountStandard.IsUsing)
				{
					this.radioInternet.Checked = true;
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000B0B4 File Offset: 0x0000A0B4
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000B0CC File Offset: 0x0000A0CC
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
				if (File.Exists(this._fileName))
				{
					this.webBrowserStandard.Url = new Uri("file://" + this._fileName);
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000B116 File Offset: 0x0000A116
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000B120 File Offset: 0x0000A120
		private void btnLoad_Click(object sender, EventArgs e)
		{
			string text = "";
			if (this.radioLocal.Checked)
			{
				this.StandardModeChange(true);
				string text2 = this.txtLocalPath.Text.Trim();
				FileInfo fileInfo = new FileInfo(text2);
				if (!fileInfo.Exists)
				{
					MessageBox.Show("The file does not exist", this.Text);
					return;
				}
				text = AppConfigurationManager.UserDbPath + "\\filestandard.xml";
				FileInfo fileInfo2 = new FileInfo(text);
				if (!Directory.Exists(AppConfigurationManager.UserDbPath))
				{
					Directory.CreateDirectory(AppConfigurationManager.UserDbPath);
				}
				if (fileInfo2.Exists)
				{
					fileInfo2.Attributes = FileAttributes.Normal;
				}
				if (text != text2)
				{
					fileInfo2 = fileInfo.CopyTo(text, true);
				}
				else
				{
					fileInfo2 = new FileInfo(text2);
				}
				if (!fileInfo2.Exists)
				{
					MessageBox.Show("Can't copy the file to user directory!", this.Text);
					return;
				}
				fileInfo2.Attributes = FileAttributes.Normal;
				if (AppConfigurationManager.LocalCountStandard == null)
				{
					AppConfigurationManager.LocalCountStandard = new CountStandardItem();
				}
				if (AppConfigurationManager.RemoteCountStandard != null)
				{
					AppConfigurationManager.RemoteCountStandard.IsUsing = false;
				}
				AppConfigurationManager.LocalCountStandard.SourceLocation = this.txtLocalPath.Text.Trim();
				AppConfigurationManager.LocalCountStandard.DestineLocation = text;
				AppConfigurationManager.LocalCountStandard.IsLocal = true;
				AppConfigurationManager.LocalCountStandard.IsUsing = true;
				if (!AppConfigurationManager.SaveStandardConfig(true, ExecutionMode.StandAlone))
				{
					MessageBox.Show("Can't save to database!", this.Text);
					return;
				}
			}
			else
			{
				this.StandardModeChange(false);
				WebClient webClient = new WebClient();
				text = AppConfigurationManager.UserDbPath + "\\internetstandard.xml";
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Exists)
				{
					fileInfo.Attributes = FileAttributes.Normal;
				}
				try
				{
					webClient.UseDefaultCredentials = true;
					webClient.DownloadFile(this.txtInternet.Text, text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Can't download the standard file from internet to user directory!", this.Text);
					return;
				}
				if (AppConfigurationManager.RemoteCountStandard == null)
				{
					AppConfigurationManager.RemoteCountStandard = new CountStandardItem();
				}
				if (AppConfigurationManager.LocalCountStandard != null)
				{
					AppConfigurationManager.LocalCountStandard.IsUsing = false;
				}
				AppConfigurationManager.RemoteCountStandard.SourceLocation = this.txtInternet.Text;
				AppConfigurationManager.RemoteCountStandard.DestineLocation = text;
				AppConfigurationManager.RemoteCountStandard.IsLocal = false;
				AppConfigurationManager.RemoteCountStandard.IsUsing = true;
				if (!AppConfigurationManager.SaveStandardConfig(false, ExecutionMode.StandAlone))
				{
					MessageBox.Show("Can't save to database!", this.Text);
					return;
				}
			}
			this.webBrowserStandard.Navigate("file://" + text, false);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000B404 File Offset: 0x0000A404
		private void btnRestore_Click(object sender, EventArgs e)
		{
			this.radioLocal.Checked = true;
			this.txtLocalPath.Text = AppConfigurationManager.AppDbPath + "\\LineCounters.xml";
			Application.DoEvents();
			this.btnLoad_Click(sender, e);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000B440 File Offset: 0x0000A440
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML files (*.xml)|*.xml";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtLocalPath.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000B484 File Offset: 0x0000A484
		private void radioLocal_CheckedChanged(object sender, EventArgs e)
		{
			this.StandardModeChange(true);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000B48F File Offset: 0x0000A48F
		private void radioInternet_CheckedChanged(object sender, EventArgs e)
		{
			this.StandardModeChange(false);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000B49C File Offset: 0x0000A49C
		private void StandardModeChange(bool isLocal)
		{
			if (isLocal)
			{
				this.btnBrowse.Enabled = true;
				this.txtInternet.Enabled = false;
			}
			else
			{
				this.btnBrowse.Enabled = false;
				this.txtInternet.Enabled = true;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000B4EC File Offset: 0x0000A4EC
		private void frmShowCodingStandard_Shown(object sender, EventArgs e)
		{
			this.btnLoad_Click(sender, e);
		}

		// Token: 0x040000A5 RID: 165
		private string _fileName;
	}
}
