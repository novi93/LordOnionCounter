namespace MS.IT.LOC.UI
{
	// Token: 0x0200000E RID: 14
	public partial class frmShowCodingStandard : global::System.Windows.Forms.Form
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000B4F8 File Offset: 0x0000A4F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000B530 File Offset: 0x0000A530
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmShowCodingStandard));
			this.pnlInfo = new global::System.Windows.Forms.Panel();
			this.webBrowserStandard = new global::System.Windows.Forms.WebBrowser();
			this.pnlBottom = new global::System.Windows.Forms.Panel();
			this.btnRestore = new global::System.Windows.Forms.Button();
			this.btnBrowse = new global::System.Windows.Forms.Button();
			this.txtLocalPath = new global::System.Windows.Forms.TextBox();
			this.radioLocal = new global::System.Windows.Forms.RadioButton();
			this.radioInternet = new global::System.Windows.Forms.RadioButton();
			this.btnSet = new global::System.Windows.Forms.Button();
			this.txtInternet = new global::System.Windows.Forms.TextBox();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.pnlInfo.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			base.SuspendLayout();
			this.pnlInfo.Controls.Add(this.webBrowserStandard);
			this.pnlInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlInfo.Location = new global::System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new global::System.Drawing.Size(686, 362);
			this.pnlInfo.TabIndex = 0;
			this.webBrowserStandard.AllowWebBrowserDrop = false;
			this.webBrowserStandard.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowserStandard.IsWebBrowserContextMenuEnabled = false;
			this.webBrowserStandard.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowserStandard.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowserStandard.Name = "webBrowserStandard";
			this.webBrowserStandard.Size = new global::System.Drawing.Size(686, 362);
			this.webBrowserStandard.TabIndex = 1;
			this.webBrowserStandard.WebBrowserShortcutsEnabled = false;
			this.pnlBottom.Controls.Add(this.btnRestore);
			this.pnlBottom.Controls.Add(this.btnBrowse);
			this.pnlBottom.Controls.Add(this.txtLocalPath);
			this.pnlBottom.Controls.Add(this.radioLocal);
			this.pnlBottom.Controls.Add(this.radioInternet);
			this.pnlBottom.Controls.Add(this.btnSet);
			this.pnlBottom.Controls.Add(this.txtInternet);
			this.pnlBottom.Controls.Add(this.btnClose);
			this.pnlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new global::System.Drawing.Point(0, 362);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new global::System.Drawing.Size(686, 71);
			this.pnlBottom.TabIndex = 1;
			this.btnRestore.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnRestore.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.Location = new global::System.Drawing.Point(475, 6);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new global::System.Drawing.Size(98, 23);
			this.btnRestore.TabIndex = 8;
			this.btnRestore.Text = "&Restore defaults";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new global::System.EventHandler(this.btnRestore_Click);
			this.btnBrowse.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnBrowse.Location = new global::System.Drawing.Point(394, 6);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new global::System.Drawing.Size(75, 22);
			this.btnBrowse.TabIndex = 7;
			this.btnBrowse.Text = "&Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
			this.txtLocalPath.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.txtLocalPath.Enabled = false;
			this.txtLocalPath.Location = new global::System.Drawing.Point(80, 8);
			this.txtLocalPath.MaxLength = 254;
			this.txtLocalPath.Name = "txtLocalPath";
			this.txtLocalPath.Size = new global::System.Drawing.Size(308, 20);
			this.txtLocalPath.TabIndex = 6;
			this.radioLocal.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.radioLocal.AutoSize = true;
			this.radioLocal.Checked = true;
			this.radioLocal.Location = new global::System.Drawing.Point(12, 9);
			this.radioLocal.Name = "radioLocal";
			this.radioLocal.Size = new global::System.Drawing.Size(41, 17);
			this.radioLocal.TabIndex = 5;
			this.radioLocal.TabStop = true;
			this.radioLocal.Text = "File";
			this.radioLocal.UseVisualStyleBackColor = true;
			this.radioLocal.CheckedChanged += new global::System.EventHandler(this.radioLocal_CheckedChanged);
			this.radioInternet.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.radioInternet.AutoSize = true;
			this.radioInternet.Location = new global::System.Drawing.Point(12, 42);
			this.radioInternet.Name = "radioInternet";
			this.radioInternet.Size = new global::System.Drawing.Size(61, 17);
			this.radioInternet.TabIndex = 4;
			this.radioInternet.Text = "Internet";
			this.radioInternet.UseVisualStyleBackColor = true;
			this.radioInternet.CheckedChanged += new global::System.EventHandler(this.radioInternet_CheckedChanged);
			this.btnSet.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnSet.Location = new global::System.Drawing.Point(599, 7);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new global::System.Drawing.Size(75, 22);
			this.btnSet.TabIndex = 3;
			this.btnSet.Text = "&Apply";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.txtInternet.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.txtInternet.Location = new global::System.Drawing.Point(80, 39);
			this.txtInternet.MaxLength = 254;
			this.txtInternet.Name = "txtInternet";
			this.txtInternet.Size = new global::System.Drawing.Size(493, 20);
			this.txtInternet.TabIndex = 1;
			this.btnClose.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnClose.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new global::System.Drawing.Point(599, 36);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(686, 433);
			base.Controls.Add(this.pnlInfo);
			base.Controls.Add(this.pnlBottom);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmShowCodingStandard";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Counting Standard";
			base.Shown += new global::System.EventHandler(this.frmShowCodingStandard_Shown);
			this.pnlInfo.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000A6 RID: 166
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Panel pnlInfo;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Panel pnlBottom;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.WebBrowser webBrowserStandard;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Button btnSet;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.TextBox txtInternet;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.TextBox txtLocalPath;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.RadioButton radioLocal;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.RadioButton radioInternet;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Button btnBrowse;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Button btnRestore;
	}
}
