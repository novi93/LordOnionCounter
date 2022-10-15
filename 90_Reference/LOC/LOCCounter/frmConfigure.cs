using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000012 RID: 18
	public partial class frmConfigure : Form
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000DBE0 File Offset: 0x0000CBE0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000DBF8 File Offset: 0x0000CBF8
		public CounterItem CurrentCounterItem
		{
			get
			{
				return this._CounterItem;
			}
			set
			{
				this._CounterItem = value;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000DC04 File Offset: 0x0000CC04
		public frmConfigure(CounterItem counterItem)
		{
			this._CounterItem = counterItem;
			this.InitializeComponent();
			this.lblStatus.Enabled = false;
			frmCounterItems.m_SourceControlManager.OnItemGet += this.m_SourceControlManager_OnItemGet;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000DC5A File Offset: 0x0000CC5A
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Utils.UnCheckAllTreeViewNodeState(this.treeViewSourceControl);
			Utils.SetExpandState(this.treeViewSourceControl, this._CounterItem);
			base.Hide();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000DC84 File Offset: 0x0000CC84
		public void m_SourceControlManager_OnConnect(object source, SourceControlEventArgs args)
		{
			Application.DoEvents();
			this.lblStatus.Text = args.ToString();
			if (args == SourceControlEventArgs.Connecting)
			{
				this.Cursor = Cursors.WaitCursor;
			}
			else if (args == SourceControlEventArgs.Connected)
			{
				this.Cursor = Cursors.Default;
			}
			else if (args == SourceControlEventArgs.UnableToConnect)
			{
				this.Cursor = Cursors.Default;
				if (this._CounterItem.ServerType != SourceServerType.FILESYS)
				{
					MessageBox.Show("Can't connect to the server", this.Text);
				}
				else
				{
					MessageBox.Show("Can't open the file folder", this.Text);
				}
				base.Close();
			}
			else if (args == SourceControlEventArgs.NotConnected)
			{
				this.Cursor = Cursors.Default;
				if (this._CounterItem.ServerType != SourceServerType.FILESYS)
				{
					MessageBox.Show("Can't connect to the server", this.Text);
				}
				else
				{
					MessageBox.Show("Can't open the file folder", this.Text);
				}
				base.Close();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000DDA4 File Offset: 0x0000CDA4
		protected void m_SourceControlManager_OnItemGet(object source, SourceControlEventArgs args)
		{
			Application.DoEvents();
			if (args == SourceControlEventArgs.Getting)
			{
				this.Cursor = Cursors.WaitCursor;
			}
			else if (args == SourceControlEventArgs.Got)
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000DDF4 File Offset: 0x0000CDF4
		public void InitTree()
		{
			this.m_IsInit = false;
			this.treeViewSourceControl.Nodes.Clear();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000DE10 File Offset: 0x0000CE10
		private void OnShow(object sender, EventArgs e)
		{
			frmCounterItems.m_SourceControlManager.InitEvent("OnConnect");
			frmCounterItems.m_SourceControlManager.OnConnect += this.m_SourceControlManager_OnConnect;
			Application.DoEvents();
			this.labelMessage.Text = "Select Elements for Counter Task : " + this._CounterItem.Name;
			this.Text = this.labelMessage.Text;
			this.lblStatus.Text = "Connected";
			this.btnApply.Enabled = false;
			this.btnReset.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			frmCounterItems.m_SourceControlManager.m_CurrentCountItem = this._CounterItem;
			if (!this.m_IsInit || (this._CounterItem.IncludeElementSet.Count == 0 && this._CounterItem.ExcludeElementSet.Count == 0))
			{
				this.treeViewSourceControl.Nodes.Clear();
				SourceControlManager.currentBTLC.BaseVersion = this._CounterItem.LabelsBeseVer;
				SourceControlManager.currentBTLC.DiffVersion = this._CounterItem.LabelsDiffVer;
				SourceControlManager.currentBTLC.currentCIType = this._CounterItem.Type;
				TreeNode[] treeNodesFromSCItems = Utils.GetTreeNodesFromSCItems(frmCounterItems.m_SourceControlManager.GetChildItem(null, false), false);
				if (treeNodesFromSCItems != null)
				{
					this.treeViewSourceControl.Nodes.AddRange(treeNodesFromSCItems);
				}
				if (this._CounterItem != null)
				{
					Utils.LoadTreeView(this._CounterItem, this.treeViewSourceControl);
					if (this.treeViewSourceControl.Nodes.Count == 0)
					{
						if (this._CounterItem.ServerType == SourceServerType.FILESYS)
						{
							MessageBox.Show("The folder you have choosed is empty!");
						}
					}
				}
				this.m_IsInit = true;
			}
			Utils.SetExpandState(this.treeViewSourceControl, this._CounterItem);
			if (this.treeViewSourceControl.Nodes == null || this.treeViewSourceControl.Nodes.Count < 1)
			{
				MessageBox.Show("There is no item found!", "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				base.Close();
			}
			else
			{
				this.btnApply.Enabled = true;
				this.btnReset.Enabled = true;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000E064 File Offset: 0x0000D064
		private void Before_Expand(object sender, TreeViewCancelEventArgs e)
		{
			this.treeViewSourceControl.SelectedNode = e.Node;
			if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == Utils.DUMMY_NODE)
			{
				this.Cursor = Cursors.WaitCursor;
				e.Node.Nodes.Clear();
				SCItem parent = (SCItem)e.Node.Tag;
				SCItemSet childItem = frmCounterItems.m_SourceControlManager.GetChildItem(parent, false);
				if (childItem != null)
				{
					TreeNode[] treeNodesFromSCItems = Utils.GetTreeNodesFromSCItems(childItem, e.Node.Checked);
					if (treeNodesFromSCItems != null)
					{
						e.Node.Nodes.AddRange(treeNodesFromSCItems);
					}
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000E14C File Offset: 0x0000D14C
		private void btnApply_Click(object sender, EventArgs e)
		{
			TreeNode[] firstCheckedNodes = Utils.GetFirstCheckedNodes(this.treeViewSourceControl);
			if (firstCheckedNodes != null)
			{
				this.CurrentCounterItem.IncludeElementSet = Utils.CreateElementSet(firstCheckedNodes, true);
				TreeNode[] childUnCheckNodes = Utils.GetChildUnCheckNodes(firstCheckedNodes);
				if (childUnCheckNodes != null)
				{
					this.CurrentCounterItem.ExcludeElementSet = Utils.CreateElementSet(childUnCheckNodes, false);
				}
				else
				{
					this.CurrentCounterItem.ExcludeElementSet.Clear();
				}
			}
			else
			{
				this.CurrentCounterItem.IncludeElementSet.Clear();
			}
			base.Hide();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000E1D8 File Offset: 0x0000D1D8
		private void AfterCheck(object sender, TreeViewEventArgs e)
		{
			Utils.SetChildNodeState(e.Node);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E1E7 File Offset: 0x0000D1E7
		private void btnReset_Click(object sender, EventArgs e)
		{
			Utils.UnCheckAllTreeViewNodeState(this.treeViewSourceControl);
			Utils.SetExpandState(this.treeViewSourceControl, this._CounterItem);
		}

		// Token: 0x040000E0 RID: 224
		private CounterItem _CounterItem;

		// Token: 0x040000E1 RID: 225
		public bool m_IsInit = false;
	}
}
