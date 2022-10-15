using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MS.IT.LOC.Manager;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000011 RID: 17
	public partial class frmMode : Form
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0000CEC0 File Offset: 0x0000BEC0
		public frmMode()
		{
			this.InitializeComponent();
			this.Server = AppConfigurationManager.Server;
			this.Database = AppConfigurationManager.Database;
			this.Mode = AppConfigurationManager.Mode;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000CF26 File Offset: 0x0000BF26
		private void rdModeShared_CheckedChanged(object sender, EventArgs e)
		{
			this.panelSqlConfig.Enabled = this.rdModeShared.Checked;
			this.CheckMode();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000CF48 File Offset: 0x0000BF48
		private void frmMode_Load(object sender, EventArgs e)
		{
			this.txtServer.Text = this.Server;
			this.txtDb.Text = this.Database;
			if (this.Mode.ToUpper().Trim() == "LOCAL")
			{
				this.rdModeLocal.Checked = true;
			}
			else
			{
				this.rdModeShared.Checked = true;
			}
			this.btnApply.Enabled = false;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000CFC8 File Offset: 0x0000BFC8
		private void Save()
		{
			AppConfigurationManager.SaveConfigValues(this.rdModeLocal.Checked ? "LOCAL" : "SHARED", this.txtServer.Text.Trim(), this.txtDb.Text.Trim());
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000D018 File Offset: 0x0000C018
		private bool TestConnection()
		{
			bool result = false;
			try
			{
				string connectionString = string.Concat(new string[]
				{
					"Server=",
					this.txtServer.Text.Trim(),
					";Database=",
					this.txtDb.Text.Trim(),
					";Integrated Security= true;"
				});
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					sqlConnection.Open();
					result = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				result = false;
			}
			return result;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000D0E8 File Offset: 0x0000C0E8
		private void btnApply_Click(object sender, EventArgs e)
		{
			if (this.TestConnection())
			{
				if (MessageBox.Show("Application will shut down for changes to take effect " + Environment.NewLine + "Do you want to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					this.Save();
					Application.Exit();
				}
				else
				{
					base.Close();
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000D14B File Offset: 0x0000C14B
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000D155 File Offset: 0x0000C155
		private void rdModeLocal_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckMode();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000D160 File Offset: 0x0000C160
		private void CheckMode()
		{
			if (this.txtServer.Text == this.Server && this.txtDb.Text == this.Database)
			{
				if (this.rdModeLocal.Checked && this.Mode.ToUpper().Trim() == "LOCAL")
				{
					this.btnApply.Enabled = false;
				}
				else if (this.rdModeShared.Checked && this.Mode.ToUpper().Trim() == "SHARED")
				{
					this.btnApply.Enabled = false;
				}
				else
				{
					this.btnApply.Enabled = true;
				}
			}
			else
			{
				this.btnApply.Enabled = true;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000D24F File Offset: 0x0000C24F
		private void txtServer_TextChanged(object sender, EventArgs e)
		{
			this.CheckMode();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000D259 File Offset: 0x0000C259
		private void txtDb_TextChanged(object sender, EventArgs e)
		{
			this.CheckMode();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000D264 File Offset: 0x0000C264
		private void btnTest_Click(object sender, EventArgs e)
		{
			if (this.TestConnection())
			{
				MessageBox.Show("Connection succeded..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x040000CE RID: 206
		private string Server = "";

		// Token: 0x040000CF RID: 207
		private string Database = "";

		// Token: 0x040000D0 RID: 208
		private string Mode = "";
	}
}
