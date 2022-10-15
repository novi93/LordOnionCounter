namespace MS.IT.LOC.UI
{
	// Token: 0x02000012 RID: 18
	public partial class frmConfigure : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000E208 File Offset: 0x0000D208
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E240 File Offset: 0x0000D240
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmConfigure));
			this.panelTop = new global::System.Windows.Forms.Panel();
			this.labelMessage = new global::System.Windows.Forms.Label();
			this.panelMiddle = new global::System.Windows.Forms.Panel();
			this.treeViewSourceControl = new global::System.Windows.Forms.TreeView();
			this.panelBottom = new global::System.Windows.Forms.Panel();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.btnReset = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnApply = new global::System.Windows.Forms.Button();
			this.panelTop.SuspendLayout();
			this.panelMiddle.SuspendLayout();
			this.panelBottom.SuspendLayout();
			base.SuspendLayout();
			this.panelTop.Controls.Add(this.labelMessage);
			this.panelTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new global::System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new global::System.Drawing.Size(437, 24);
			this.panelTop.TabIndex = 0;
			this.labelMessage.AutoSize = true;
			this.labelMessage.Location = new global::System.Drawing.Point(4, 5);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new global::System.Drawing.Size(171, 13);
			this.labelMessage.TabIndex = 10;
			this.labelMessage.Text = "Select Elements for Counter Task :";
			this.panelMiddle.Controls.Add(this.treeViewSourceControl);
			this.panelMiddle.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelMiddle.Location = new global::System.Drawing.Point(0, 24);
			this.panelMiddle.Name = "panelMiddle";
			this.panelMiddle.Padding = new global::System.Windows.Forms.Padding(3);
			this.panelMiddle.Size = new global::System.Drawing.Size(437, 438);
			this.panelMiddle.TabIndex = 1;
			this.treeViewSourceControl.CheckBoxes = true;
			this.treeViewSourceControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeViewSourceControl.Location = new global::System.Drawing.Point(3, 3);
			this.treeViewSourceControl.Name = "treeViewSourceControl";
			this.treeViewSourceControl.Size = new global::System.Drawing.Size(431, 432);
			this.treeViewSourceControl.TabIndex = 6;
			this.treeViewSourceControl.AfterCheck += new global::System.Windows.Forms.TreeViewEventHandler(this.AfterCheck);
			this.treeViewSourceControl.BeforeExpand += new global::System.Windows.Forms.TreeViewCancelEventHandler(this.Before_Expand);
			this.panelBottom.Controls.Add(this.lblStatus);
			this.panelBottom.Controls.Add(this.btnReset);
			this.panelBottom.Controls.Add(this.btnCancel);
			this.panelBottom.Controls.Add(this.btnApply);
			this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 462);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(437, 46);
			this.panelBottom.TabIndex = 2;
			this.btnReset.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.btnReset.Enabled = false;
			this.btnReset.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new global::System.Drawing.Point(178, 12);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new global::System.Drawing.Size(80, 23);
			this.btnReset.TabIndex = 13;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new global::System.EventHandler(this.btnReset_Click);
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(259, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lblStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(374, 17);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(0, 13);
			this.lblStatus.TabIndex = 14;
			this.btnApply.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.btnApply.Enabled = false;
			this.btnApply.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnApply.Location = new global::System.Drawing.Point(97, 12);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new global::System.Drawing.Size(80, 23);
			this.btnApply.TabIndex = 11;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new global::System.EventHandler(this.btnApply_Click);
			base.AcceptButton = this.btnCancel;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(437, 508);
			base.Controls.Add(this.panelMiddle);
			base.Controls.Add(this.panelTop);
			base.Controls.Add(this.panelBottom);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmConfigure";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Elements For Counter Task :";
			base.Shown += new global::System.EventHandler(this.OnShow);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.panelMiddle.ResumeLayout(false);
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000E2 RID: 226
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Panel panelTop;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label labelMessage;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Panel panelMiddle;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.TreeView treeViewSourceControl;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Panel panelBottom;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btnReset;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Button btnApply;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Label lblStatus;
	}
}
