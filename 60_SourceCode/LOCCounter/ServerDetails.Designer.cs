namespace MS.IT.LOC.UI
{
	// Token: 0x02000002 RID: 2
	public partial class ServerDetails : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000022A4 File Offset: 0x000012A4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022DC File Offset: 0x000012DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.ServerDetails));
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxServerName = new global::System.Windows.Forms.TextBox();
			this.buttonConnect = new global::System.Windows.Forms.Button();
			this.buttonExit = new global::System.Windows.Forms.Button();
			this.labelStaus = new global::System.Windows.Forms.Label();
			this.radioBtnVSTF = new global::System.Windows.Forms.RadioButton();
			this.radioBtnVSS = new global::System.Windows.Forms.RadioButton();
			this.radioBtnSD = new global::System.Windows.Forms.RadioButton();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server Name :";
			this.textBoxServerName.Location = new global::System.Drawing.Point(88, 42);
			this.textBoxServerName.Name = "textBoxServerName";
			this.textBoxServerName.Size = new global::System.Drawing.Size(93, 20);
			this.textBoxServerName.TabIndex = 1;
			this.textBoxServerName.Text = "tkbgitvstsat02";
			this.buttonConnect.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonConnect.Location = new global::System.Drawing.Point(25, 83);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new global::System.Drawing.Size(83, 23);
			this.buttonConnect.TabIndex = 2;
			this.buttonConnect.Text = "&Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new global::System.EventHandler(this.buttonConnect_Click);
			this.buttonExit.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonExit.Location = new global::System.Drawing.Point(114, 83);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new global::System.Drawing.Size(83, 23);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "&Close";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new global::System.EventHandler(this.buttonExit_Click);
			this.labelStaus.AutoSize = true;
			this.labelStaus.Location = new global::System.Drawing.Point(12, 104);
			this.labelStaus.Name = "labelStaus";
			this.labelStaus.Size = new global::System.Drawing.Size(10, 13);
			this.labelStaus.TabIndex = 4;
			this.labelStaus.Text = " ";
			this.labelStaus.Visible = false;
			this.radioBtnVSTF.AutoSize = true;
			this.radioBtnVSTF.Checked = true;
			this.radioBtnVSTF.Location = new global::System.Drawing.Point(43, 13);
			this.radioBtnVSTF.Name = "radioBtnVSTF";
			this.radioBtnVSTF.Size = new global::System.Drawing.Size(52, 17);
			this.radioBtnVSTF.TabIndex = 5;
			this.radioBtnVSTF.TabStop = true;
			this.radioBtnVSTF.Text = "VSTF";
			this.radioBtnVSTF.UseVisualStyleBackColor = true;
			this.radioBtnVSS.AutoSize = true;
			this.radioBtnVSS.Enabled = false;
			this.radioBtnVSS.Location = new global::System.Drawing.Point(96, 13);
			this.radioBtnVSS.Name = "radioBtnVSS";
			this.radioBtnVSS.Size = new global::System.Drawing.Size(46, 17);
			this.radioBtnVSS.TabIndex = 6;
			this.radioBtnVSS.Text = "VSS";
			this.radioBtnVSS.UseVisualStyleBackColor = true;
			this.radioBtnSD.AutoSize = true;
			this.radioBtnSD.Enabled = false;
			this.radioBtnSD.Location = new global::System.Drawing.Point(149, 13);
			this.radioBtnSD.Name = "radioBtnSD";
			this.radioBtnSD.Size = new global::System.Drawing.Size(40, 17);
			this.radioBtnSD.TabIndex = 7;
			this.radioBtnSD.Text = "SD";
			this.radioBtnSD.UseVisualStyleBackColor = true;
			base.AcceptButton = this.buttonConnect;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonExit;
			base.ClientSize = new global::System.Drawing.Size(222, 112);
			base.Controls.Add(this.radioBtnSD);
			base.Controls.Add(this.radioBtnVSS);
			base.Controls.Add(this.radioBtnVSTF);
			base.Controls.Add(this.labelStaus);
			base.Controls.Add(this.buttonExit);
			base.Controls.Add(this.buttonConnect);
			base.Controls.Add(this.textBoxServerName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "ServerDetails";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Server Details";
			base.Load += new global::System.EventHandler(this.ServerDetails_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TextBox textBoxServerName;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button buttonConnect;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button buttonExit;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label labelStaus;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.RadioButton radioBtnVSTF;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.RadioButton radioBtnVSS;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.RadioButton radioBtnSD;
	}
}
