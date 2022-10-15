using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000002 RID: 2
	public partial class ServerDetails : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public ServerDetails()
		{
			this.InitializeComponent();
			frmCounterItems.m_SourceControlManager.OnConnect += this.m_SourceControlManager_OnConnect;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002090 File Offset: 0x00001090
		public ServerDetails(string serverName, SourceServerType serverType)
		{
			this.InitializeComponent();
			frmCounterItems.m_SourceControlManager.OnConnect += this.m_SourceControlManager_OnConnect;
			if (serverName != "")
			{
				this.textBoxServerName.Text = serverName;
				switch (serverType)
				{
				case SourceServerType.VSTF:
					this.radioBtnVSTF.Checked = true;
					break;
				case SourceServerType.VSS:
					this.radioBtnVSS.Checked = true;
					break;
				case SourceServerType.SD:
					this.radioBtnSD.Checked = true;
					break;
				default:
					this.radioBtnVSTF.Checked = true;
					break;
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002150 File Offset: 0x00001150
		protected void m_SourceControlManager_OnConnect(object source, SourceControlEventArgs args)
		{
			Application.DoEvents();
			this.labelStaus.Text = args.ToString();
			if (args == SourceControlEventArgs.Connecting)
			{
				this.Cursor = Cursors.WaitCursor;
			}
			else if (args == SourceControlEventArgs.Connected)
			{
				this.Cursor = Cursors.Default;
				base.Close();
			}
			else if (args == SourceControlEventArgs.UnableToConnect)
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show("Unable To Connect", this.Text);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021EC File Offset: 0x000011EC
		private void buttonConnect_Click(object sender, EventArgs e)
		{
			SourceServerType serverType = this.radioBtnVSTF.Checked ? SourceServerType.VSTF : (this.radioBtnVSS.Checked ? SourceServerType.VSS : (this.radioBtnSD.Checked ? SourceServerType.SD : SourceServerType.Base));
			if (frmCounterItems.m_SourceControlManager.Login(this.textBoxServerName.Text, "8080", serverType, "", ""))
			{
				this.bConnection = true;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000225F File Offset: 0x0000125F
		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.bClosed = true;
			base.Close();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002270 File Offset: 0x00001270
		public bool IsClosed
		{
			get
			{
				return this.bClosed;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002288 File Offset: 0x00001288
		public bool IsConnected
		{
			get
			{
				return this.bConnection;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022A0 File Offset: 0x000012A0
		private void ServerDetails_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private bool bClosed = false;

		// Token: 0x04000002 RID: 2
		private bool bConnection = false;

		// Token: 0x04000003 RID: 3
		private Thread LoginThread;
	}
}
