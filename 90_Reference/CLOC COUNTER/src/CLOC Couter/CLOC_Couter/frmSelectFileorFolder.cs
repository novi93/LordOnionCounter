using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class frmSelectFileorFolder : Form
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00008E66 File Offset: 0x00007066
		public frmSelectFileorFolder()
		{
			base.Load += this.frmSelectFileorFolder_Load;
			this.strValue = "";
			this.listfile = new List<string>();
			this.InitializeComponent();
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000092CB File Offset: 0x000074CB
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000092D5 File Offset: 0x000074D5
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000092DE File Offset: 0x000074DE
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000092E8 File Offset: 0x000074E8
		internal virtual TextBox txtPath
		{
			[CompilerGenerated]
			get
			{
				return this._txtPath;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPath_TextChanged);
				TextBox txtPath = this._txtPath;
				if (txtPath != null)
				{
					txtPath.TextChanged -= value2;
				}
				this._txtPath = value;
				txtPath = this._txtPath;
				if (txtPath != null)
				{
					txtPath.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000932B File Offset: 0x0000752B
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00009338 File Offset: 0x00007538
		internal virtual Button btnForderDialog
		{
			[CompilerGenerated]
			get
			{
				return this._btnForderDialog;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnForderDialog_Click);
				Button btnForderDialog = this._btnForderDialog;
				if (btnForderDialog != null)
				{
					btnForderDialog.Click -= value2;
				}
				this._btnForderDialog = value;
				btnForderDialog = this._btnForderDialog;
				if (btnForderDialog != null)
				{
					btnForderDialog.Click += value2;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000937B File Offset: 0x0000757B
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00009388 File Offset: 0x00007588
		internal virtual TreeView treResult
		{
			[CompilerGenerated]
			get
			{
				return this._treResult;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeViewEventHandler value2 = new TreeViewEventHandler(this.treResult_AfterSelect);
				TreeViewEventHandler value3 = new TreeViewEventHandler(this.treResult_AfterCheck);
				TreeViewEventHandler value4 = new TreeViewEventHandler(this.treResult_AfterExpand);
				TreeView treResult = this._treResult;
				if (treResult != null)
				{
					treResult.AfterSelect -= value2;
					treResult.AfterCheck -= value3;
					treResult.AfterExpand -= value4;
				}
				this._treResult = value;
				treResult = this._treResult;
				if (treResult != null)
				{
					treResult.AfterSelect += value2;
					treResult.AfterCheck += value3;
					treResult.AfterExpand += value4;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00009401 File Offset: 0x00007601
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000940C File Offset: 0x0000760C
		internal virtual Button btnOK
		{
			[CompilerGenerated]
			get
			{
				return this._btnOK;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOK_Click);
				Button btnOK = this._btnOK;
				if (btnOK != null)
				{
					btnOK.Click -= value2;
				}
				this._btnOK = value;
				btnOK = this._btnOK;
				if (btnOK != null)
				{
					btnOK.Click += value2;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000944F File Offset: 0x0000764F
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000945C File Offset: 0x0000765C
		internal virtual Button btnCancel
		{
			[CompilerGenerated]
			get
			{
				return this._btnCancel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancel_Click);
				Button btnCancel = this._btnCancel;
				if (btnCancel != null)
				{
					btnCancel.Click -= value2;
				}
				this._btnCancel = value;
				btnCancel = this._btnCancel;
				if (btnCancel != null)
				{
					btnCancel.Click += value2;
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000949F File Offset: 0x0000769F
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000094A9 File Offset: 0x000076A9
		public string pathNewDiff { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000094B2 File Offset: 0x000076B2
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000094BC File Offset: 0x000076BC
		public bool checkDiff { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000094C8 File Offset: 0x000076C8
		public string ListCheckValue
		{
			get
			{
				return this.strValue;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000094E0 File Offset: 0x000076E0
		public List<string> returnListfile
		{
			get
			{
				return this.listfile;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000094F8 File Offset: 0x000076F8
		private void frmSelectFileorFolder_Load(object sender, EventArgs e)
		{
			bool checkDiff = this.checkDiff;
			if (checkDiff)
			{
				this.btnForderDialog.Enabled = false;
				this.txtPath.Enabled = false;
			}
			this.txtPath.Text = this.pathNewDiff;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009540 File Offset: 0x00007740
		private void ListFiles(TreeNode lst, DirectoryInfo dir_info)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(lst.FullPath);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				TreeNode treeNode = new TreeNode(directoryInfo2.Name);
				lst.Nodes.Add(treeNode);
				this.ListFiles(treeNode, directoryInfo2);
			}
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				TreeNode node = new TreeNode(fileInfo.Name);
				lst.Nodes.Add(node);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000095F0 File Offset: 0x000077F0
		private void treResult_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.treResult.BeginUpdate();
			this.LoadDirectory(e.Node.FullPath, e.Node);
			bool flag = this.returnListfile.Count > 0;
			if (flag)
			{
				bool flag2 = this.returnListfile.Contains(e.Node.FullPath);
				if (flag2)
				{
					e.Node.Checked = true;
				}
				this.treResult.SelectedNode.ExpandAll();
				this.CheckNodeFromList(e.Node, this.returnListfile);
			}
			else
			{
				this.treResult.SelectedNode.Expand();
			}
			this.treResult.EndUpdate();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000096A4 File Offset: 0x000078A4
		private void treResult_AfterCheck(object sender, TreeViewEventArgs e)
		{
			bool flag = e.Action == TreeViewAction.ByKeyboard | e.Action == TreeViewAction.ByMouse;
			if (flag)
			{
				this.CheckChildNodes(e.Node);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000096D8 File Offset: 0x000078D8
		public void CheckChildNodes(TreeNode iNode)
		{
			try
			{
				this.UnCheckParentNodes(iNode);
				try
				{
					foreach (object obj in iNode.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						treeNode.Checked = iNode.Checked;
						this.CheckChildNodes(treeNode);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00009770 File Offset: 0x00007970
		public void UnCheckParentNodes(TreeNode iNode)
		{
			try
			{
				bool flag = !iNode.Checked && iNode.Parent != null;
				if (flag)
				{
					iNode.Parent.Checked = false;
					this.UnCheckParentNodes(iNode.Parent);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000097D8 File Offset: 0x000079D8
		public TreeNode CheckNode(TreeNodeCollection _nodeCollection)
		{
			try
			{
				foreach (object obj in _nodeCollection)
				{
					TreeNode treeNode = (TreeNode)obj;
					treeNode.Checked = true;
					TreeNode treeNode2 = this.CheckNode(treeNode.Nodes);
					bool flag = treeNode2 != null;
					if (flag)
					{
						return treeNode2;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00009858 File Offset: 0x00007A58
		public TreeNode UnCheckNode(TreeNodeCollection _nodeCollection)
		{
			try
			{
				foreach (object obj in _nodeCollection)
				{
					TreeNode treeNode = (TreeNode)obj;
					treeNode.Checked = false;
					TreeNode treeNode2 = this.UnCheckNode(treeNode.Nodes);
					bool flag = treeNode2 != null;
					if (flag)
					{
						return treeNode2;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000098D8 File Offset: 0x00007AD8
		private void btnForderDialog_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txtPath.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00009910 File Offset: 0x00007B10
		private void btnOK_Click(object sender, EventArgs e)
		{
			List<TreeNode> list = this.CheckedNodes(this.treResult);
			this.listfile = new List<string>();
			try
			{
				foreach (TreeNode treeNode in list)
				{
					this.listfile.Add(treeNode.FullPath);
				}
			}
			finally
			{
				List<TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.strValue = this.txtPath.Text;
			base.Hide();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000099A0 File Offset: 0x00007BA0
		private List<TreeNode> CheckedNodes(TreeView trv)
		{
			List<TreeNode> list = new List<TreeNode>();
			bool checkDiff = this.checkDiff;
			if (checkDiff)
			{
				this.FindCheckedNodesChild(list, this.treResult.Nodes);
			}
			else
			{
				this.FindCheckedNodes(list, this.treResult.Nodes);
			}
			return list;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000099F0 File Offset: 0x00007BF0
		private void FindCheckedNodes(List<TreeNode> checked_nodes, TreeNodeCollection nodes)
		{
			bool flag = false;
			try
			{
				foreach (object obj in nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					bool @checked = treeNode.Checked;
					if (@checked)
					{
						checked_nodes.Add(treeNode);
						bool flag2 = treeNode.Nodes.Count > 0;
						if (flag2)
						{
							flag = true;
						}
					}
					else
					{
						flag = false;
					}
					bool flag3 = !flag;
					if (flag3)
					{
						this.FindCheckedNodes(checked_nodes, treeNode.Nodes);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00009A94 File Offset: 0x00007C94
		private void FindCheckedNodesChild(List<TreeNode> checked_nodes, TreeNodeCollection nodes)
		{
			try
			{
				foreach (object obj in nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					bool @checked = treeNode.Checked;
					if (@checked)
					{
						bool flag = treeNode.Nodes.Count == 0;
						if (flag)
						{
							checked_nodes.Add(treeNode);
						}
					}
					this.FindCheckedNodesChild(checked_nodes, treeNode.Nodes);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00009B28 File Offset: 0x00007D28
		private void LoadDirectory(string Dir, TreeNode tds)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Dir);
			this.LoadSubDirectories(Dir, tds);
			this.LoadFiles(Dir, tds);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00009B50 File Offset: 0x00007D50
		private void LoadSubDirectories(string dir, TreeNode td)
		{
			try
			{
				td.Nodes.Clear();
				string[] directories = Directory.GetDirectories(dir);
				foreach (string text in directories)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text);
					TreeNode td2 = td.Nodes.Add(directoryInfo.Name);
					this.LoadSubDirectories(text, td2);
					this.LoadFiles(text, td2);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00009BE0 File Offset: 0x00007DE0
		private void LoadFiles(string dir, TreeNode td)
		{
			try
			{
				string[] files = Directory.GetFiles(dir, "*.*");
				foreach (string fileName in files)
				{
					FileInfo fileInfo = new FileInfo(fileName);
					TreeNode treeNode = td.Nodes.Add(fileInfo.Name);
					treeNode.Tag = fileInfo.FullName;
					treeNode.StateImageIndex = 1;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008D58 File Offset: 0x00006F58
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00009C6C File Offset: 0x00007E6C
		private void treResult_AfterExpand(object sender, TreeViewEventArgs e)
		{
			bool flag = e.Node != null;
			if (flag)
			{
				bool @checked = e.Node.Checked;
				if (@checked)
				{
					this.CheckChildNodes(e.Node);
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00009CA8 File Offset: 0x00007EA8
		private void CheckNodeFromList(TreeNode childnodes, List<string> remId)
		{
			bool flag = childnodes.Nodes == null;
			if (!flag)
			{
				try
				{
					foreach (object obj in childnodes.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						bool flag2 = treeNode == null;
						if (flag2)
						{
							break;
						}
						bool flag3 = remId.Contains(treeNode.FullPath);
						bool flag4;
						if (flag3)
						{
							treeNode.Checked = true;
							flag4 = true;
							bool flag5 = treeNode.Nodes.Count > 0;
							if (flag5)
							{
								treeNode.Collapse(true);
							}
							this.ExpandNodeParent(treeNode);
						}
						else
						{
							flag4 = false;
						}
						bool flag6 = !flag4;
						if (flag6)
						{
							treeNode.Collapse(true);
						}
						this.CheckNodeFromList(treeNode, remId);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00009D94 File Offset: 0x00007F94
		private void ExpandNodeParent(TreeNode nodeExpand)
		{
			while (nodeExpand != null)
			{
				nodeExpand.Expand();
				nodeExpand = nodeExpand.Parent;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00009DBC File Offset: 0x00007FBC
		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode();
			try
			{
				this.treResult.Nodes.Clear();
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
				treeNode.Text = this.txtPath.Text;
				this.treResult.Nodes.Add(treeNode);
				this.treResult.SelectedNode = treeNode;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot create initial node:" + ex.ToString());
			}
		}

		// Token: 0x04000061 RID: 97
		private string strValue;

		// Token: 0x04000062 RID: 98
		private List<string> listfile;
	}
}
