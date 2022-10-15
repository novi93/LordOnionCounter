namespace MS.IT.LOC.UI
{
	// Token: 0x0200000C RID: 12
	public partial class frmUserLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00009340 File Offset: 0x00008340
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009378 File Offset: 0x00008378
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmUserLogin));
			this.Account = new global::System.Windows.Forms.Label();
			this.txtAccount = new global::System.Windows.Forms.TextBox();
			this.buttonConnect = new global::System.Windows.Forms.Button();
			this.labelStaus = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.Cancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Account.AutoSize = true;
			this.Account.Location = new global::System.Drawing.Point(30, 26);
			this.Account.Name = "Account";
			this.Account.Size = new global::System.Drawing.Size(50, 13);
			this.Account.TabIndex = 0;
			this.Account.Text = "Account:";
			this.txtAccount.Location = new global::System.Drawing.Point(98, 26);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new global::System.Drawing.Size(149, 20);
			this.txtAccount.TabIndex = 1;
			this.buttonConnect.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonConnect.Location = new global::System.Drawing.Point(33, 99);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new global::System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 3;
			this.buttonConnect.Text = "&Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new global::System.EventHandler(this.buttonConnect_Click);
			this.labelStaus.AutoSize = true;
			this.labelStaus.Location = new global::System.Drawing.Point(12, 104);
			this.labelStaus.Name = "labelStaus";
			this.labelStaus.Size = new global::System.Drawing.Size(10, 13);
			this.labelStaus.TabIndex = 4;
			this.labelStaus.Text = " ";
			this.labelStaus.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(30, 59);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Password:";
			this.txtPassword.Location = new global::System.Drawing.Point(98, 56);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(149, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new global::System.EventHandler(this.txtPassword_TextChanged);
			this.Cancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancel.Location = new global::System.Drawing.Point(163, 99);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new global::System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 4;
			this.Cancel.Text = "&Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new global::System.EventHandler(this.Cancel_Click);
			base.AcceptButton = this.buttonConnect;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(283, 137);
			base.Controls.Add(this.Cancel);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.labelStaus);
			base.Controls.Add(this.buttonConnect);
			base.Controls.Add(this.txtAccount);
			base.Controls.Add(this.Account);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmUserLogin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login to the Server";
			base.Shown += new global::System.EventHandler(this.frmUserLogin_Shown);
			base.Load += new global::System.EventHandler(this.UserAndPassword_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000088 RID: 136
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label Account;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.TextBox txtAccount;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Button buttonConnect;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label labelStaus;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button Cancel;
	}
}
