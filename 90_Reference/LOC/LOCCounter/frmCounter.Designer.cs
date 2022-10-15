namespace MS.IT.LOC.UI
{
	// Token: 0x02000007 RID: 7
	public partial class frmCounter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000310C File Offset: 0x0000210C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003144 File Offset: 0x00002144
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmCounter));
			this.progressBarStatus = new global::System.Windows.Forms.ProgressBar();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.lvItems = new global::System.Windows.Forms.ListView();
			this.colTask = new global::System.Windows.Forms.ColumnHeader();
			this.imgList = new global::System.Windows.Forms.ImageList(this.components);
			base.SuspendLayout();
			this.progressBarStatus.Location = new global::System.Drawing.Point(10, 112);
			this.progressBarStatus.Name = "progressBarStatus";
			this.progressBarStatus.Size = new global::System.Drawing.Size(371, 23);
			this.progressBarStatus.TabIndex = 1;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(151, 112);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(88, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lvItems.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colTask
			});
			this.lvItems.GridLines = true;
			this.lvItems.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvItems.HideSelection = false;
			this.lvItems.Location = new global::System.Drawing.Point(10, 16);
			this.lvItems.MultiSelect = false;
			this.lvItems.Name = "lvItems";
			this.lvItems.Size = new global::System.Drawing.Size(368, 80);
			this.lvItems.SmallImageList = this.imgList;
			this.lvItems.TabIndex = 2;
			this.lvItems.UseCompatibleStateImageBehavior = false;
			this.lvItems.View = global::System.Windows.Forms.View.Details;
			this.colTask.Text = "Task";
			this.colTask.Width = 360;
			this.imgList.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imgList.ImageStream");
			this.imgList.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "GoLtr.bmp");
			this.imgList.Images.SetKeyName(1, "WorkflowCompletePS.bmp");
			this.imgList.Images.SetKeyName(2, "WorkflowAbortedPS.bmp");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(390, 152);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.progressBarStatus);
			base.Controls.Add(this.lvItems);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmCounter";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Counter Engine";
			base.Shown += new global::System.EventHandler(this.OnShow);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmCounter_FormClosing);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ProgressBar progressBarStatus;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ListView lvItems;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ColumnHeader colTask;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ImageList imgList;
	}
}
