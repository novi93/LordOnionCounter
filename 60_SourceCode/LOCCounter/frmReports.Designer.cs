namespace MS.IT.LOC.UI
{
	// Token: 0x02000010 RID: 16
	public partial class frmReports : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000CB20 File Offset: 0x0000BB20
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000CB58 File Offset: 0x0000BB58
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmReports));
			this.btnRun = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.lblText = new global::System.Windows.Forms.Label();
			this.cboReportType = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.btnRun.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRun.Location = new global::System.Drawing.Point(53, 112);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new global::System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 0;
			this.btnRun.Text = "&Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new global::System.EventHandler(this.btnRun_Click);
			this.btnExit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new global::System.Drawing.Point(133, 112);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "&Close";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.lblText.AutoSize = true;
			this.lblText.Location = new global::System.Drawing.Point(10, 24);
			this.lblText.Name = "lblText";
			this.lblText.Size = new global::System.Drawing.Size(168, 13);
			this.lblText.TabIndex = 2;
			this.lblText.Text = "Select the Report to be generated";
			this.cboReportType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboReportType.FormattingEnabled = true;
			this.cboReportType.Items.AddRange(new object[]
			{
				"KLOC Report",
				"KLOC by Application",
				"KLOC by Quarter by Application"
			});
			this.cboReportType.Location = new global::System.Drawing.Point(10, 48);
			this.cboReportType.Name = "cboReportType";
			this.cboReportType.Size = new global::System.Drawing.Size(240, 21);
			this.cboReportType.TabIndex = 3;
			base.AcceptButton = this.btnRun;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(261, 146);
			base.Controls.Add(this.cboReportType);
			base.Controls.Add(this.lblText);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnRun);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmReports";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reports";
			base.Load += new global::System.EventHandler(this.frmReports_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C9 RID: 201
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Button btnRun;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label lblText;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ComboBox cboReportType;
	}
}
