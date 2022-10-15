using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MS.IT.LOC.UI.Properties;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000004 RID: 4
	public partial class frmMessage : Form
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002E40 File Offset: 0x00001E40
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002E58 File Offset: 0x00001E58
		public string inputMess
		{
			get
			{
				return this.sInputMess;
			}
			set
			{
				this.sInputMess = value;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E62 File Offset: 0x00001E62
		public frmMessage(string strMsg)
		{
			this.InitializeComponent();
			this.BindMessage(strMsg);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E8E File Offset: 0x00001E8E
		private void BindMessage(string strMsg)
		{
			this.txtShowMsg.Text = strMsg;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002E9E File Offset: 0x00001E9E
		private void admit_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002EB0 File Offset: 0x00001EB0
		private void cancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002EBC File Offset: 0x00001EBC
		private void detail_Click(object sender, EventArgs e)
		{
			this.txtShowMsg.Visible = !this.txtShowMsg.Visible;
			if (this.txtShowMsg.Visible)
			{
				base.Height = 300;
			}
			else
			{
				base.Height = 145;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F14 File Offset: 0x00001F14
		private void frmMessage_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000017 RID: 23
		private string sInputMess = "";
	}
}
