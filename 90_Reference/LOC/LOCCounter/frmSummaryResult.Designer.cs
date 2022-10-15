namespace MS.IT.LOC.UI
{
	// Token: 0x0200000D RID: 13
	public partial class frmSummaryResult : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007D RID: 125 RVA: 0x0000983C File Offset: 0x0000883C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009874 File Offset: 0x00008874
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmSummaryResult));
			this.pnlTop = new global::System.Windows.Forms.Panel();
			this.lvWItems = new global::System.Windows.Forms.ListView();
			this.colName = new global::System.Windows.Forms.ColumnHeader();
			this.colBase = new global::System.Windows.Forms.ColumnHeader();
			this.colAdded = new global::System.Windows.Forms.ColumnHeader();
			this.colModified = new global::System.Windows.Forms.ColumnHeader();
			this.colDeleted = new global::System.Windows.Forms.ColumnHeader();
			this.colAddedAndcolModified = new global::System.Windows.Forms.ColumnHeader();
			this.pnlBottom = new global::System.Windows.Forms.Panel();
			this.btnViewReport = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pnlTop.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			base.SuspendLayout();
			this.pnlTop.Controls.Add(this.lvWItems);
			this.pnlTop.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlTop.Location = new global::System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new global::System.Drawing.Size(709, 359);
			this.pnlTop.TabIndex = 3;
			this.lvWItems.AllowColumnReorder = true;
			this.lvWItems.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colName,
				this.colBase,
				this.colAdded,
				this.colModified,
				this.colDeleted,
				this.colAddedAndcolModified
			});
			this.lvWItems.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lvWItems.FullRowSelect = true;
			this.lvWItems.GridLines = true;
			this.lvWItems.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvWItems.Location = new global::System.Drawing.Point(0, 0);
			this.lvWItems.Name = "lvWItems";
			this.lvWItems.Size = new global::System.Drawing.Size(709, 359);
			this.lvWItems.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.lvWItems.TabIndex = 2;
			this.lvWItems.UseCompatibleStateImageBehavior = false;
			this.lvWItems.View = global::System.Windows.Forms.View.Details;
			this.colName.Text = "File Path";
			this.colName.Width = 586;
			this.colBase.Text = "Base";
			this.colBase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAdded.Text = "Added";
			this.colAdded.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colModified.Text = "Modified";
			this.colModified.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colDeleted.Text = "Deleted";
			this.colDeleted.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAddedAndcolModified.Text = "Added+Modified";
			this.colAddedAndcolModified.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.colAddedAndcolModified.Width = 110;
			this.pnlBottom.Controls.Add(this.button1);
			this.pnlBottom.Controls.Add(this.btnViewReport);
			this.pnlBottom.Controls.Add(this.btnCancel);
			this.pnlBottom.Controls.Add(this.btnSave);
			this.pnlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new global::System.Drawing.Point(0, 359);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new global::System.Drawing.Size(709, 39);
			this.pnlBottom.TabIndex = 4;
			this.btnViewReport.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnViewReport.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnViewReport.Location = new global::System.Drawing.Point(371, 8);
			this.btnViewReport.Name = "btnViewReport";
			this.btnViewReport.Size = new global::System.Drawing.Size(87, 23);
			this.btnViewReport.TabIndex = 5;
			this.btnViewReport.Text = "&Language";
			this.btnViewReport.UseVisualStyleBackColor = true;
			this.btnViewReport.Click += new global::System.EventHandler(this.btnViewReport_Click);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(282, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(87, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&LOC Excluded";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(193, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(87, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&By Folder";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(464, 8);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(87, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "&Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(709, 398);
			base.Controls.Add(this.pnlTop);
			base.Controls.Add(this.pnlBottom);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSummaryResult";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Summary Result";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Shown += new global::System.EventHandler(this.OnShow);
			this.pnlTop.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Panel pnlTop;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ListView lvWItems;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.ColumnHeader colName;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.ColumnHeader colBase;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.ColumnHeader colAdded;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.ColumnHeader colModified;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.ColumnHeader colAddedAndcolModified;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.ColumnHeader colDeleted;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Panel pnlBottom;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Button btnViewReport;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button btnSave;
	}
}
