using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SharpSvn;
using SharpSvn.UI;

namespace CLOC_Couter
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class frmSelectFileRepository : Form
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000082D3 File Offset: 0x000064D3
		public frmSelectFileRepository()
		{
			base.Load += this.frmSelectSVN_Load;
			this.svnclient = new SvnClient();
			this.InitializeComponent();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000085EC File Offset: 0x000067EC
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000085F8 File Offset: 0x000067F8
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000863B File Offset: 0x0000683B
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00008648 File Offset: 0x00006848
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000868B File Offset: 0x0000688B
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00008698 File Offset: 0x00006898
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
				TreeView treResult = this._treResult;
				if (treResult != null)
				{
					treResult.AfterSelect -= value2;
					treResult.AfterCheck -= value3;
				}
				this._treResult = value;
				treResult = this._treResult;
				if (treResult != null)
				{
					treResult.AfterSelect += value2;
					treResult.AfterCheck += value3;
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000086F8 File Offset: 0x000068F8
		private void frmSelectSVN_Load(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode();
			SvnUIBindArgs svnUIBindArgs = new SvnUIBindArgs();
			SvnUI.Bind(this.svnclient, svnUIBindArgs);
			try
			{
				this.treResult.Nodes.Clear();
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
				treeNode.Text = this.svnUrl;
				this.treResult.Nodes.Add(treeNode);
				treeNode.Tag = 0;
				this.treResult.SelectedNode = treeNode;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot create initial node:" + ex.ToString());
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000087B4 File Offset: 0x000069B4
		private void treResult_AfterSelect(object sender, TreeViewEventArgs e)
		{
			SvnListArgs svnListArgs = new SvnListArgs();
			bool flag = e.Node.Tag == null;
			if (!flag)
			{
				this.treResult.BeginUpdate();
				bool flag2 = Operators.CompareString(this.revision, "Head", false) == 0;
				long irevision;
				if (flag2)
				{
					irevision = -1L;
				}
				else
				{
					irevision = Conversions.ToLong(Conversion.Int(this.revision));
				}
				this.LoadTreeDir("", e.Node.FullPath, e.Node, irevision);
				this.LoadTreeFile(e.Node.FullPath, e.Node, irevision);
				this.treResult.SelectedNode.Expand();
				this.treResult.EndUpdate();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008874 File Offset: 0x00006A74
		private void LoadTreeDir(string repos, string sURL, TreeNode nNode, long irevision)
		{
			bool flag = irevision == -1L;
			Collection<SvnListEventArgs> collection;
			if (flag)
			{
				this.svnclient.GetList(new SvnUriTarget(sURL, SvnRevision.Head), ref collection);
			}
			else
			{
				this.svnclient.GetList(new SvnUriTarget(sURL, irevision), ref collection);
			}
			bool flag2 = collection != null;
			if (flag2)
			{
				nNode.Nodes.Clear();
				List<SvnListEventArgs> list = collection.Where((frmSelectFileRepository._Closure$__.$I22-0 == null) ? (frmSelectFileRepository._Closure$__.$I22-0 = ((SvnListEventArgs x) => x.Entry.NodeKind == 2 & Operators.CompareString(x.Path, "", false) != 0)) : frmSelectFileRepository._Closure$__.$I22-0).ToList<SvnListEventArgs>();
				bool flag3 = list.Count > 0;
				if (flag3)
				{
					try
					{
						foreach (SvnListEventArgs svnListEventArgs in list)
						{
							bool flag4 = Operators.CompareString(svnListEventArgs.Path, "", false) != 0;
							if (flag4)
							{
								TreeNode treeNode = nNode.Nodes.Add(svnListEventArgs.Name);
								treeNode.Tag = 0;
								this.LoadTreeDir("", svnListEventArgs.Uri.ToString(), treeNode, irevision);
								this.LoadTreeFile(svnListEventArgs.Uri.ToString(), treeNode, irevision);
							}
						}
					}
					finally
					{
						List<SvnListEventArgs>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000089DC File Offset: 0x00006BDC
		private void LoadTreeFile(string sURL, TreeNode nNode, long irevision)
		{
			bool flag = irevision == -1L;
			Collection<SvnListEventArgs> collection;
			if (flag)
			{
				this.svnclient.GetList(new SvnUriTarget(sURL, SvnRevision.Head), ref collection);
			}
			else
			{
				this.svnclient.GetList(new SvnUriTarget(sURL, irevision), ref collection);
			}
			bool flag2 = collection != null;
			if (flag2)
			{
				IEnumerable<SvnListEventArgs> enumerable = collection.Where((frmSelectFileRepository._Closure$__.$I23-0 == null) ? (frmSelectFileRepository._Closure$__.$I23-0 = ((SvnListEventArgs x) => x.Entry.NodeKind == 1)) : frmSelectFileRepository._Closure$__.$I23-0);
				try
				{
					foreach (SvnListEventArgs svnListEventArgs in enumerable)
					{
						TreeNode treeNode = nNode.Nodes.Add(svnListEventArgs.Name);
						treeNode.Name = svnListEventArgs.BasePath + "/" + svnListEventArgs.Name;
					}
				}
				finally
				{
					IEnumerator<SvnListEventArgs> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008AD8 File Offset: 0x00006CD8
		private List<TreeNode> CheckedNodes(TreeView trv)
		{
			List<TreeNode> list = new List<TreeNode>();
			this.FindCheckedNodes(list, this.treResult.Nodes);
			return list;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008B04 File Offset: 0x00006D04
		private void FindCheckedNodes(List<TreeNode> checked_nodes, TreeNodeCollection nodes)
		{
			try
			{
				foreach (object obj in nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					bool flag = treeNode.Checked & treeNode.Tag == null;
					if (flag)
					{
						checked_nodes.Add(treeNode);
					}
					this.FindCheckedNodes(checked_nodes, treeNode.Nodes);
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

		// Token: 0x060000C3 RID: 195 RVA: 0x00008B8C File Offset: 0x00006D8C
		private void btnOK_Click(object sender, EventArgs e)
		{
			SvnClient svnClient = new SvnClient();
			SvnCheckOutArgs svnCheckOutArgs = new SvnCheckOutArgs();
			this.listfile = new List<string>();
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
			base.Hide();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008C24 File Offset: 0x00006E24
		private void treResult_AfterCheck(object sender, TreeViewEventArgs e)
		{
			bool flag = e.Action == TreeViewAction.ByKeyboard | e.Action == TreeViewAction.ByMouse;
			if (flag)
			{
				this.CheckChildNodes(e.Node);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008C58 File Offset: 0x00006E58
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

		// Token: 0x060000C6 RID: 198 RVA: 0x00008CF0 File Offset: 0x00006EF0
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

		// Token: 0x060000C7 RID: 199 RVA: 0x00008D58 File Offset: 0x00006F58
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x04000051 RID: 81
		public string svnUrl;

		// Token: 0x04000052 RID: 82
		public List<string> listfile;

		// Token: 0x04000053 RID: 83
		public string revision;

		// Token: 0x04000054 RID: 84
		public SvnClient svnclient;
	}
}
