using System;
using System.Collections;
using System.Windows.Forms;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000028 RID: 40
	internal class Utils
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00021518 File Offset: 0x00020518
		public static TreeNode[] GetTreeNodesFromSCItems(SCItemSet itemSet, bool check)
		{
			TreeNode[] result;
			if (itemSet != null && itemSet.Count > 0)
			{
				TreeNode[] array = new TreeNode[itemSet.Count];
				for (int i = 0; i < itemSet.Count; i++)
				{
					TreeNode treeNode = new TreeNode();
					treeNode.Text = itemSet[i].Name;
					treeNode.Tag = itemSet[i];
					array[i] = treeNode;
					treeNode.Checked = check;
					treeNode.Nodes.Add(Utils.DUMMY_NODE);
				}
				result = array;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000215B4 File Offset: 0x000205B4
		public static TreeNode[] GetFirstCheckedNodes(TreeView treeView)
		{
			ArrayList arrayList = new ArrayList();
			Utils.ReccurseNodes(treeView.Nodes, arrayList, true);
			TreeNode[] result;
			if (arrayList.Count > 0)
			{
				result = (TreeNode[])arrayList.ToArray(typeof(TreeNode));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00021604 File Offset: 0x00020604
		public static TreeNode[] GetChildUnCheckNodes(TreeNode[] nodes)
		{
			ArrayList arrayList = new ArrayList();
			foreach (TreeNode treeNode in nodes)
			{
				Utils.ReccurseNodes(treeNode.Nodes, arrayList, false);
			}
			TreeNode[] result;
			if (arrayList.Count > 0)
			{
				result = (TreeNode[])arrayList.ToArray(typeof(TreeNode));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00021678 File Offset: 0x00020678
		private static void ReccurseNodes(TreeNodeCollection nodes, ArrayList toReturn, bool check)
		{
			foreach (object obj in nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (check)
				{
					if (treeNode.Checked)
					{
						if (treeNode.Text != Utils.DUMMY_NODE)
						{
							toReturn.Add(treeNode);
						}
					}
					else
					{
						if (treeNode.Nodes == null)
						{
							break;
						}
						Utils.ReccurseNodes(treeNode.Nodes, toReturn, check);
					}
				}
				else
				{
					if (!treeNode.Checked)
					{
						if (treeNode.Text != Utils.DUMMY_NODE)
						{
							toReturn.Add(treeNode);
						}
					}
					if (treeNode.Nodes == null)
					{
						break;
					}
					Utils.ReccurseNodes(treeNode.Nodes, toReturn, check);
				}
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002178C File Offset: 0x0002078C
		public static void SetChildNodeState(TreeNode ParentNode)
		{
			foreach (object obj in ParentNode.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				treeNode.Checked = ParentNode.Checked;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000217F8 File Offset: 0x000207F8
		public static ElementSet CreateElementSet(TreeNode[] arrNode, bool include)
		{
			ElementSet elementSet = new ElementSet();
			foreach (TreeNode treeNode in arrNode)
			{
				Element element = new Element();
				SCItem scitem = (SCItem)treeNode.Tag;
				element.Include = include;
				element.ServerPath = scitem.Path;
				element.ElementType = scitem.ScType;
				elementSet.Add(element);
			}
			return elementSet;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00021874 File Offset: 0x00020874
		private static SCItem GetParentSCItem(int i, string[] arrPaths)
		{
			SCItem scitem = new SCItem();
			for (int j = 0; j < i; j++)
			{
				SCItem scitem2 = scitem;
				scitem2.Path = scitem2.Path + arrPaths[j] + "/";
			}
			scitem.Path = scitem.Path.Substring(0, scitem.Path.Length - 1);
			return scitem;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000218D9 File Offset: 0x000208D9
		public static void LoadTreeView(CounterItem CI, TreeView treeView)
		{
			Utils.LoadTreeItems(CI.IncludeElementSet, treeView, true);
			Utils.LoadTreeItems(CI.ExcludeElementSet, treeView, false);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000218F8 File Offset: 0x000208F8
		private static void UnCheckSubTreeViewNodeState(TreeNode node)
		{
			if (node.Text != Utils.DUMMY_NODE)
			{
				node.Checked = false;
			}
			if (node.Nodes != null)
			{
				if (node.Nodes.Count != 1 || !(node.Nodes[0].Text == Utils.DUMMY_NODE))
				{
					node.Expand();
				}
				foreach (object obj in node.Nodes)
				{
					TreeNode node2 = (TreeNode)obj;
					Utils.UnCheckSubTreeViewNodeState(node2);
				}
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000219D8 File Offset: 0x000209D8
		public static void UnCheckAllTreeViewNodeState(TreeView treeView)
		{
			foreach (object obj in treeView.Nodes)
			{
				TreeNode node = (TreeNode)obj;
				Utils.UnCheckSubTreeViewNodeState(node);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00021A40 File Offset: 0x00020A40
		public static void SetExpandState(TreeView treeView, CounterItem CI)
		{
			foreach (object obj in treeView.Nodes)
			{
				TreeNode node = (TreeNode)obj;
				Utils.ReccurseExpandState(node, CI);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00021AA8 File Offset: 0x00020AA8
		private static void SetCheckState(TreeNode node, CounterItem CI)
		{
			foreach (object obj in CI.IncludeElementSet)
			{
				Element element = (Element)obj;
				if (((SCItem)node.Tag).Path == element.ServerPath)
				{
					node.Checked = true;
				}
			}
			foreach (object obj2 in CI.ExcludeElementSet)
			{
				Element element = (Element)obj2;
				if (((SCItem)node.Tag).Path == element.ServerPath)
				{
					node.Checked = false;
				}
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00021BAC File Offset: 0x00020BAC
		private static void ReccurseExpandState(TreeNode node, CounterItem CI)
		{
			if (node.Text != Utils.DUMMY_NODE)
			{
				Utils.SetCheckState(node, CI);
			}
			if (node.Nodes != null)
			{
				if (node.Nodes.Count != 1 || !(node.Nodes[0].Text == Utils.DUMMY_NODE))
				{
					node.Expand();
				}
				foreach (object obj in node.Nodes)
				{
					TreeNode node2 = (TreeNode)obj;
					Utils.ReccurseExpandState(node2, CI);
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00021C8C File Offset: 0x00020C8C
		private static void LoadTreeItems(ElementSet es, TreeView treeView, bool check)
		{
			foreach (object obj in es)
			{
				Element element = (Element)obj;
				try
				{
					string[] array;
					if (element.ServerPath.Contains("//depot"))
					{
						string text = element.ServerPath.Substring(2);
						array = text.Split(new char[]
						{
							'/'
						});
						array[0] = "//depot";
					}
					else
					{
						array = element.ServerPath.Split(new char[]
						{
							'/'
						});
					}
					TreeNodeCollection treeNodeCollection = treeView.Nodes;
					TreeNode treeNode = null;
					int num = array.Length;
					int i = 1;
					while (i < num)
					{
						TreeNode treeNode2 = null;
						if (treeNodeCollection != null)
						{
							treeNode2 = Utils.GetTreeNodeForPath(array[i], treeNodeCollection);
						}
						if (treeNode2 != null || i <= 1)
						{
							treeNode = treeNode2;
							goto IL_196;
						}
						SCItemSet childItem = frmCounterItems.m_SourceControlManager.GetChildItem(Utils.GetParentSCItem(i, array), false);
						if (childItem != null)
						{
							TreeNode[] treeNodesFromSCItems = Utils.GetTreeNodesFromSCItems(childItem, false);
							treeNode.Nodes.AddRange(treeNodesFromSCItems);
							if (treeNode.Nodes.Count > 0)
							{
								treeNode.Nodes.RemoveAt(0);
							}
							treeNode.Expand();
							foreach (TreeNode treeNode3 in treeNodesFromSCItems)
							{
								if (treeNode3.Text == array[i])
								{
									treeNode2 = treeNode3;
									treeNode = treeNode2;
									break;
								}
							}
							goto IL_196;
						}
						IL_1B0:
						i++;
						continue;
						IL_196:
						if (treeNode != null)
						{
							treeNodeCollection = treeNode.Nodes;
						}
						else
						{
							treeNodeCollection = null;
						}
						goto IL_1B0;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00021ECC File Offset: 0x00020ECC
		private static TreeNode GetTreeNodeForPath(string Name, TreeNodeCollection treeNodeCollection)
		{
			foreach (object obj in treeNodeCollection)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (treeNode.Text == Name)
				{
					return treeNode;
				}
			}
			return null;
		}

		// Token: 0x040001EF RID: 495
		public static string DUMMY_NODE = "#########";
	}
}
