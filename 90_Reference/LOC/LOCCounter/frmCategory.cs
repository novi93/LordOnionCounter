using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000025 RID: 37
	public partial class frmCategory : Form
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00019D4C File Offset: 0x00018D4C
		internal bool CategoryUpdated
		{
			get
			{
				return this._categoryUpdated;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00019D64 File Offset: 0x00018D64
		public frmCategory()
		{
			this.InitializeComponent();
			this.lvwColumnSorter = new ListViewColumnSorter();
			this.lvwColumnSorter.SortColumn = 0;
			this.lvwColumnSorter.Order = SortOrder.Ascending;
			this.lvwCategories.ListViewItemSorter = this.lvwColumnSorter;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00019DDC File Offset: 0x00018DDC
		private void frmCategory_Load(object sender, EventArgs e)
		{
			this.objGroupSet = frmCategory.m_ConfigManager.GetAllGroups(ExecutionMode.StandAlone);
			this.objCategories = frmCategory.m_ConfigManager.GetAllCategory(ExecutionMode.StandAlone);
			this.cboGroup.DataSource = this.objGroupSet;
			this.cboGroup.SelectedIndex = -1;
			this.btnDelete.Enabled = false;
			this.btnSave.Enabled = false;
			this.btnDelete.Enabled = false;
			this.btnCancel.Enabled = false;
			this.addToolStripMenuItem.Enabled = false;
			this.deleteToolStripMenuItem.Enabled = false;
			this.txtCategoryName.Enabled = false;
			this.cboGroup.Enabled = false;
			this._tobeSave = false;
			this.loadCategories();
			this.lvwCategories.Sort();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00019EB0 File Offset: 0x00018EB0
		private void loadCategories()
		{
			foreach (object obj in this.objCategories)
			{
				Category category = (Category)obj;
				ListViewItem listViewItem = new ListViewItem(new string[]
				{
					category.CategoryName,
					category.Group.GroupName
				});
				listViewItem.Tag = category;
				this.lvwCategories.Items.Add(listViewItem);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00019F58 File Offset: 0x00018F58
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00019F64 File Offset: 0x00018F64
		private void lvwCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lvwCategories.SelectedItems.Count > 0 && !this._tobeSave)
			{
				this.txtCategoryName.Enabled = true;
				this.cboGroup.Enabled = true;
				this.objSelectedCategory = this.lvwCategories.SelectedItems[0];
				this._changeFromListView = true;
				this.txtCategoryName.Text = ((Category)this.lvwCategories.SelectedItems[0].Tag).CategoryName;
				this.cboGroup.SelectedItem = this.objGroupSet.FindByID(((Category)this.lvwCategories.SelectedItems[0].Tag).Group.GroupID);
				this._tobeSave = false;
				this.btnSave.Enabled = false;
				this.btnCancel.Enabled = false;
				this.cboGroup.Refresh();
				this.btnDelete.Enabled = true;
				this.addToolStripMenuItem.Enabled = true;
				this.deleteToolStripMenuItem.Enabled = true;
				this._changeFromListView = false;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001A094 File Offset: 0x00019094
		private bool CheckTaskNameDuplicated()
		{
			bool result = false;
			foreach (object obj in this.lvwCategories.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.SubItems[0].Text.Trim() == this.txtCategoryName.Text.Trim() && this.cboGroup.SelectedItem.ToString().Trim() == listViewItem.SubItems[1].Text.Trim())
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001A178 File Offset: 0x00019178
		private bool CheckCategoryNameCharacter()
		{
			Regex regex = new Regex("^[a-zA-Z_]+[ \\w-_\\/]*$");
			return regex.IsMatch(this.txtCategoryName.Text.Trim());
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001A1B8 File Offset: 0x000191B8
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtCategoryName.Text.Trim()))
			{
				this.txtCategoryName.Focus();
				MessageBox.Show("Category Name can not be empty!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (this.cboGroup.SelectedItem == null)
			{
				this.cboGroup.Focus();
				MessageBox.Show("Please select one group!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (this.CheckTaskNameDuplicated())
			{
				this.txtCategoryName.Focus();
				MessageBox.Show("Category Name can not be duplicate!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (!this.CheckCategoryNameCharacter())
			{
				this.txtCategoryName.Focus();
				MessageBox.Show("Category name should only contain a-z A-Z 0-9 / - _ or blank.\r\n Please start the word with letter!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (this.cboGroup.SelectedIndex < 0)
			{
				this.cboGroup.Focus();
				MessageBox.Show("Select any Group", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Category category = new Category();
				ListViewItem listViewItem = new ListViewItem(new string[]
				{
					category.CategoryName,
					""
				});
				listViewItem.Tag = category;
				this.lvwCategories.Items.Add(listViewItem);
				listViewItem.Selected = true;
				this.objSelectedCategory = this.lvwCategories.SelectedItems[0];
				this.objCategories = new CategorySet();
				if (this.objSelectedCategory != null)
				{
					this.lvwCategories.Items[this.lvwCategories.Items.IndexOf(this.objSelectedCategory)].Selected = true;
				}
				((Category)this.lvwCategories.SelectedItems[0].Tag).CategoryName = this.txtCategoryName.Text.Trim();
				((Category)this.lvwCategories.SelectedItems[0].Tag).Group = (GroupItem)this.cboGroup.SelectedItem;
				this.objCategories.Add((Category)this.lvwCategories.SelectedItems[0].Tag);
				if (frmCategory.m_ConfigManager.SaveCategories(this.objCategories, ExecutionMode.StandAlone))
				{
					this._addMode = false;
					this._tobeSave = false;
					this.btnSave.Enabled = false;
					this.btnCancel.Enabled = false;
					this.btnDelete.Enabled = true;
					this.btnAdd.Enabled = true;
					this.addToolStripMenuItem.Enabled = true;
					this.deleteToolStripMenuItem.Enabled = true;
					this.btnDelete.Enabled = true;
					this.lvwCategories.SelectedItems[0].SubItems[0].Text = this.txtCategoryName.Text.Trim();
					this.lvwCategories.SelectedItems[0].SubItems[1].Text = ((GroupItem)this.cboGroup.SelectedItem).GroupName;
					this._categoryUpdated = true;
					this._changeFromListView = false;
					this.lvwCategories.Sort();
					this.lvwCategories.SelectedItems[0].EnsureVisible();
				}
				else
				{
					MessageBox.Show("Unable to save", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001A548 File Offset: 0x00019548
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this._addMode = true;
			this._tobeSave = true;
			this.txtCategoryName.Enabled = true;
			this.cboGroup.Enabled = true;
			this.txtCategoryName.Text = "";
			this.cboGroup.SelectedIndex = -1;
			this.txtCategoryName.Focus();
			this.btnSave.Enabled = true;
			this.btnCancel.Enabled = true;
			this.btnAdd.Enabled = false;
			this.addToolStripMenuItem.Enabled = false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001A5DC File Offset: 0x000195DC
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.lvwCategories.SelectedItems.Count > 0)
			{
				if (MessageBox.Show("Do you really want to delete selected category?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					string text;
					if (frmCategory.m_ConfigManager.RemoveCategory((Category)this.lvwCategories.SelectedItems[0].Tag, out text, ExecutionMode.StandAlone))
					{
						this.lvwCategories.SelectedItems[0].Remove();
						if (this.lvwCategories.Items.Count > 0)
						{
							this.lvwCategories.Items[this.lvwCategories.Items.Count - 1].Selected = true;
							this.lvwCategories.Items[this.lvwCategories.Items.Count - 1].EnsureVisible();
						}
						else
						{
							this.txtCategoryName.Text = "";
							this.cboGroup.SelectedIndex = -1;
						}
						this._categoryUpdated = true;
					}
					else
					{
						MessageBox.Show(text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001A720 File Offset: 0x00019720
		private void txtCategoryName_TextChanged(object sender, EventArgs e)
		{
			if (!this._changeFromListView)
			{
				this._tobeSave = true;
				this.btnSave.Enabled = true;
				this.btnCancel.Enabled = true;
				this.btnDelete.Enabled = false;
				this.btnAdd.Enabled = false;
				this.addToolStripMenuItem.Enabled = false;
				this.deleteToolStripMenuItem.Enabled = false;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001A790 File Offset: 0x00019790
		private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this._changeFromListView)
			{
				this._tobeSave = true;
				this.btnSave.Enabled = true;
				this.btnCancel.Enabled = true;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001A7CC File Offset: 0x000197CC
		private void lvwCategories_Enter(object sender, EventArgs e)
		{
			if (this._tobeSave)
			{
				this.txtCategoryName.Focus();
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001A7F8 File Offset: 0x000197F8
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.btnSave.Enabled = false;
			this.btnAdd.Enabled = true;
			this.addToolStripMenuItem.Enabled = true;
			this.btnCancel.Enabled = false;
			if (this.objSelectedCategory != null & this.lvwCategories.Items.Count > 0)
			{
				this.lvwCategories.Items[this.lvwCategories.Items.IndexOf(this.objSelectedCategory)].Selected = true;
			}
			if (this.lvwCategories.SelectedItems.Count > 0)
			{
				if (this._addMode)
				{
					this.lvwCategories.SelectedItems[0].Remove();
					this.lvwCategories.Items[this.lvwCategories.Items.Count - 1].Selected = true;
				}
				this.deleteToolStripMenuItem.Enabled = true;
				this.btnDelete.Enabled = true;
			}
			else
			{
				this.deleteToolStripMenuItem.Enabled = false;
				this.btnDelete.Enabled = false;
				if (this._addMode)
				{
					this.txtCategoryName.Text = "";
					this.cboGroup.SelectedIndex = -1;
					this.txtCategoryName.Enabled = false;
					this.cboGroup.Enabled = false;
				}
			}
			this._tobeSave = false;
			this._addMode = false;
			if (this.lvwCategories.Items.Count > 0)
			{
				this.lvwCategories_SelectedIndexChanged(this.lvwCategories, new EventArgs());
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001A9B6 File Offset: 0x000199B6
		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnAdd_Click(this.btnAdd, new EventArgs());
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001A9CB File Offset: 0x000199CB
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.btnDelete_Click(this.btnDelete, new EventArgs());
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001A9E0 File Offset: 0x000199E0
		private void lvwCategories_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == this.lvwColumnSorter.SortColumn)
			{
				if (this.lvwColumnSorter.Order == SortOrder.Ascending)
				{
					this.lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					this.lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				this.lvwColumnSorter.SortColumn = e.Column;
				this.lvwColumnSorter.Order = SortOrder.Ascending;
			}
			this.lvwCategories.Sort();
		}

		// Token: 0x04000176 RID: 374
		public static ConfigManager m_ConfigManager = new ConfigManager();

		// Token: 0x04000177 RID: 375
		private GroupItemSet objGroupSet;

		// Token: 0x04000178 RID: 376
		private CategorySet objCategories;

		// Token: 0x04000179 RID: 377
		private ListViewItem objSelectedCategory;

		// Token: 0x0400017A RID: 378
		private bool _tobeSave = false;

		// Token: 0x0400017B RID: 379
		private bool _changeFromListView = true;

		// Token: 0x0400017C RID: 380
		private bool _addMode = false;

		// Token: 0x0400017D RID: 381
		private bool _categoryUpdated = false;

		// Token: 0x0400017E RID: 382
		private ListViewColumnSorter lvwColumnSorter;
	}
}
