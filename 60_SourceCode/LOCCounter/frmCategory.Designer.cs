namespace MS.IT.LOC.UI
{
	// Token: 0x02000025 RID: 37
	public partial class frmCategory : global::System.Windows.Forms.Form
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0001AA70 File Offset: 0x00019A70
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001AAA8 File Offset: 0x00019AA8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MS.IT.LOC.UI.frmCategory));
			this.txtCategoryName = new global::System.Windows.Forms.TextBox();
			this.cboGroup = new global::System.Windows.Forms.ComboBox();
			this.lblCategoryName = new global::System.Windows.Forms.Label();
			this.lblGroup = new global::System.Windows.Forms.Label();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.lvwCategories = new global::System.Windows.Forms.ListView();
			this.colCategory = new global::System.Windows.Forms.ColumnHeader();
			this.colGroup = new global::System.Windows.Forms.ColumnHeader();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.addToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.conMenuMain = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.conMenuMain.SuspendLayout();
			base.SuspendLayout();
			this.txtCategoryName.Location = new global::System.Drawing.Point(8, 32);
			this.txtCategoryName.MaxLength = 50;
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new global::System.Drawing.Size(176, 20);
			this.txtCategoryName.TabIndex = 0;
			this.txtCategoryName.TextChanged += new global::System.EventHandler(this.txtCategoryName_TextChanged);
			this.cboGroup.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGroup.FormattingEnabled = true;
			this.cboGroup.Location = new global::System.Drawing.Point(192, 32);
			this.cboGroup.Name = "cboGroup";
			this.cboGroup.Size = new global::System.Drawing.Size(160, 21);
			this.cboGroup.TabIndex = 1;
			this.cboGroup.SelectedIndexChanged += new global::System.EventHandler(this.cboGroup_SelectedIndexChanged);
			this.lblCategoryName.AutoSize = true;
			this.lblCategoryName.Location = new global::System.Drawing.Point(8, 8);
			this.lblCategoryName.Name = "lblCategoryName";
			this.lblCategoryName.Size = new global::System.Drawing.Size(80, 13);
			this.lblCategoryName.TabIndex = 2;
			this.lblCategoryName.Text = "Category Name";
			this.lblGroup.AutoSize = true;
			this.lblGroup.Location = new global::System.Drawing.Point(192, 8);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new global::System.Drawing.Size(36, 13);
			this.lblGroup.TabIndex = 3;
			this.lblGroup.Text = "Group";
			this.btnSave.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new global::System.Drawing.Point(192, 56);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lvwCategories.AllowColumnReorder = true;
			this.lvwCategories.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.colCategory,
				this.colGroup
			});
			this.lvwCategories.FullRowSelect = true;
			this.lvwCategories.GridLines = true;
			this.lvwCategories.HideSelection = false;
			this.lvwCategories.Location = new global::System.Drawing.Point(8, 88);
			this.lvwCategories.MultiSelect = false;
			this.lvwCategories.Name = "lvwCategories";
			this.lvwCategories.Size = new global::System.Drawing.Size(352, 168);
			this.lvwCategories.TabIndex = 4;
			this.lvwCategories.UseCompatibleStateImageBehavior = false;
			this.lvwCategories.View = global::System.Windows.Forms.View.Details;
			this.lvwCategories.Enter += new global::System.EventHandler(this.lvwCategories_Enter);
			this.lvwCategories.SelectedIndexChanged += new global::System.EventHandler(this.lvwCategories_SelectedIndexChanged);
			this.lvwCategories.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.lvwCategories_ColumnClick);
			this.colCategory.Text = "Category Name";
			this.colCategory.Width = 195;
			this.colGroup.Text = "Group";
			this.colGroup.Width = 131;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(57, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Categories";
			this.btnAdd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new global::System.Drawing.Point(362, 88);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnDelete.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new global::System.Drawing.Point(362, 120);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnExit.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new global::System.Drawing.Point(362, 232);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Clos&e";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.addToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("addToolStripMenuItem.Image");
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new global::System.Drawing.Size(105, 22);
			this.addToolStripMenuItem.Text = "&Add";
			this.addToolStripMenuItem.Click += new global::System.EventHandler(this.addToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteToolStripMenuItem.Image");
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(105, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			this.conMenuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addToolStripMenuItem,
				this.deleteToolStripMenuItem
			});
			this.conMenuMain.Name = "conMenuMain";
			this.conMenuMain.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.conMenuMain.Size = new global::System.Drawing.Size(106, 48);
			this.btnCancel.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new global::System.Drawing.Point(272, 56);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AcceptButton = this.btnExit;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(441, 266);
			this.ContextMenuStrip = this.conMenuMain;
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.lvwCategories);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.lblGroup);
			base.Controls.Add(this.lblCategoryName);
			base.Controls.Add(this.cboGroup);
			base.Controls.Add(this.txtCategoryName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frmCategory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Categories";
			base.Load += new global::System.EventHandler(this.frmCategory_Load);
			this.conMenuMain.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400017F RID: 383
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.TextBox txtCategoryName;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.ComboBox cboGroup;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.Label lblCategoryName;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Label lblGroup;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.ListView lvwCategories;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.ColumnHeader colCategory;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.ColumnHeader colGroup;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.ContextMenuStrip conMenuMain;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.Button btnCancel;
	}
}
