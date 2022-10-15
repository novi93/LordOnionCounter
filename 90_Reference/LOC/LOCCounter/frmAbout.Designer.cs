namespace MS.IT.LOC.UI
{
	// Token: 0x02000023 RID: 35
	public partial class frmAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x000129C4 File Offset: 0x000119C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000129FC File Offset: 0x000119FC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmAbout));
			this.btnClose = new global::System.Windows.Forms.Button();
			this.txtVersion = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Liclink = new global::System.Windows.Forms.LinkLabel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lblVersion = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btnClose.Location = new global::System.Drawing.Point(396, 288);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "OK";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.button1_Click);
			this.txtVersion.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtVersion.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtVersion.Location = new global::System.Drawing.Point(166, 86);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.Size = new global::System.Drawing.Size(216, 16);
			this.txtVersion.TabIndex = 2;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(65, 23);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(238, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Microsoft Line Of Code Counter";
			this.Liclink.AutoSize = true;
			this.Liclink.LinkVisited = true;
			this.Liclink.Location = new global::System.Drawing.Point(65, 173);
			this.Liclink.Name = "Liclink";
			this.Liclink.Size = new global::System.Drawing.Size(189, 13);
			this.Liclink.TabIndex = 4;
			this.Liclink.TabStop = true;
			this.Liclink.Text = "View the End-User Licecse Agreement";
			this.Liclink.VisitedLinkColor = global::System.Drawing.Color.Blue;
			this.Liclink.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(65, 222);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(393, 52);
			this.label2.TabIndex = 5;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(65, 129);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(232, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "© 2007 Microsoft Corporation All rights reserved";
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblVersion.Location = new global::System.Drawing.Point(65, 85);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new global::System.Drawing.Size(64, 17);
			this.lblVersion.TabIndex = 1;
			this.lblVersion.Text = "Version :";
			this.lblVersion.Click += new global::System.EventHandler(this.lblVersion_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(516, 365);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Liclink);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtVersion);
			base.Controls.Add(this.lblVersion);
			base.Controls.Add(this.btnClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmAbout";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Microsoft Line Of Code Counter";
			base.Load += new global::System.EventHandler(this.About_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000127 RID: 295
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.TextBox txtVersion;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.LinkLabel Liclink;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.Label lblVersion;
	}
}
