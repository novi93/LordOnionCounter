using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MS.IT.LOC.UI
{
	// Token: 0x0200000C RID: 12
	public partial class frmUserLogin : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00009281 File Offset: 0x00008281
		public frmUserLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000092A4 File Offset: 0x000082A4
		private void buttonConnect_Click(object sender, EventArgs e)
		{
			this.UserName = this.txtAccount.Text.Trim();
			this.Password = this.txtPassword.Text.Trim();
			if (this.UserName.Length < 1)
			{
				MessageBox.Show("User Name can't be empty", "LOC Counter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.IsFormOk = true;
				base.Close();
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009317 File Offset: 0x00008317
		private void UserAndPassword_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000931A File Offset: 0x0000831A
		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000931D File Offset: 0x0000831D
		private void Cancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009327 File Offset: 0x00008327
		private void frmUserLogin_Shown(object sender, EventArgs e)
		{
			this.IsFormOk = false;
			this.txtAccount.Focus();
		}

		// Token: 0x04000085 RID: 133
		public string UserName;

		// Token: 0x04000086 RID: 134
		public string Password;

		// Token: 0x04000087 RID: 135
		public bool IsFormOk = false;
	}
}
