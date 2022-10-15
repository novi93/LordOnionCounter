using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MS.IT.LOC.CounterEngine;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
	// Token: 0x0200000D RID: 13
	public partial class frmSummaryResult : Form
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00009F68 File Offset: 0x00008F68
		public frmSummaryResult(CounterItemSet CISet)
		{
			this.InitializeComponent();
			this.CISet = CISet;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009FCC File Offset: 0x00008FCC
		private void OnShow(object sender, EventArgs e)
		{
			this.btnSave.Enabled = false;
			this.btnCancel.Enabled = true;
			this.btnViewReport.Enabled = true;
			this.colName.Text = "Folder List";
			this.lvWItems.Items.Clear();
			this.folderList.Clear();
			this.folderBase.Clear();
			this.folderAdd.Clear();
			this.folderModify.Clear();
			this.folderDelete.Clear();
			this.colBase.Text = "Base";
			this.colAdded.Text = "Added";
			this.colModified.Text = "Modified";
			this.colDeleted.Text = "Deleted";
			this.colAddedAndcolModified.Text = "Added+Modified";
			foreach (object obj in this.CISet)
			{
				CounterItem counterItem = (CounterItem)obj;
				if (counterItem.ToBeCount)
				{
					ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
					this.lvWItems.Groups.Add(listViewGroup);
					foreach (object obj2 in counterItem.CounterDataSet)
					{
						LineCounterData lineCounterData = (LineCounterData)obj2;
						string text = lineCounterData.Name.Substring(0, lineCounterData.Name.LastIndexOf("/"));
						if (!this.folderList.Contains(text))
						{
							this.folderList.Add(text);
							try
							{
								this.folderBase.Add(text, lineCounterData.Base);
								this.folderAdd.Add(text, lineCounterData.AddedLine);
								this.folderModify.Add(text, lineCounterData.ModifiedLine);
								this.folderDelete.Add(text, lineCounterData.DeletedLine);
							}
							catch
							{
							}
						}
						else
						{
							this.folderBase[text] = (long)this.folderBase[text] + lineCounterData.Base;
							this.folderAdd[text] = (long)this.folderAdd[text] + lineCounterData.AddedLine;
							this.folderModify[text] = (long)this.folderModify[text] + lineCounterData.ModifiedLine;
							this.folderDelete[text] = (long)this.folderDelete[text] + lineCounterData.DeletedLine;
						}
					}
					this.folderList.Sort();
					for (int i = this.folderList.Count - 1; i >= 0; i--)
					{
						for (int j = i - 1; j >= 0; j--)
						{
							if (this.folderList[i].ToString().Contains(this.folderList[j].ToString()))
							{
								this.folderBase[this.folderList[j].ToString()] = (long)this.folderBase[this.folderList[j].ToString()] + (long)this.folderBase[this.folderList[i].ToString()];
								this.folderAdd[this.folderList[j].ToString()] = (long)this.folderAdd[this.folderList[j].ToString()] + (long)this.folderAdd[this.folderList[i].ToString()];
								this.folderModify[this.folderList[j].ToString()] = (long)this.folderModify[this.folderList[j].ToString()] + (long)this.folderModify[this.folderList[i].ToString()];
								this.folderDelete[this.folderList[j].ToString()] = (long)this.folderDelete[this.folderList[j].ToString()] + (long)this.folderDelete[this.folderList[i].ToString()];
								break;
							}
						}
					}
					foreach (object obj3 in this.folderList)
					{
						long num = (long)this.folderAdd[obj3] + (long)this.folderModify[obj3];
						ListViewItem listViewItem = new ListViewItem(new string[]
						{
							obj3.ToString(),
							this.folderBase[obj3].ToString(),
							this.folderAdd[obj3].ToString(),
							this.folderModify[obj3].ToString(),
							this.folderDelete[obj3].ToString(),
							num.ToString()
						});
						listViewItem.Group = listViewGroup;
						this.lvWItems.Items.Add(listViewItem);
					}
					if (counterItem.CounterDataSet.Count <= 0)
					{
						ListViewItem listViewItem = new ListViewItem(new string[]
						{
							"*********** No Result ***********",
							"",
							"",
							"",
							""
						});
						listViewItem.Group = listViewGroup;
						this.lvWItems.Items.Add(listViewItem);
						listViewGroup.Header = counterItem.Name;
					}
					else
					{
						listViewGroup.Header = counterItem.Name;
					}
					this.folderList.Clear();
					this.folderBase.Clear();
					this.folderAdd.Clear();
					this.folderModify.Clear();
					this.folderDelete.Clear();
				}
			}
			this.lvWItems.Sort();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A76C File Offset: 0x0000976C
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.OnShow(null, null);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000A778 File Offset: 0x00009778
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnCancel.Enabled = false;
			this.btnViewReport.Enabled = true;
			this.lvWItems.Items.Clear();
			this.folderList.Clear();
			this.folderBase.Clear();
			this.folderAdd.Clear();
			this.folderModify.Clear();
			this.folderDelete.Clear();
			this.colName.Text = "LOC Excluded Name";
			this.colAdded.Text = "";
			this.colBase.Text = "Counts";
			this.colModified.Text = "";
			this.colDeleted.Text = "";
			this.colAddedAndcolModified.Text = "";
			int num = 0;
			foreach (object obj in this.CISet)
			{
				CounterItem counterItem = (CounterItem)obj;
				if (counterItem.ToBeCount)
				{
					ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
					this.lvWItems.Groups.Add(listViewGroup);
					LineCounter[] lineCounters = this.counterArray[num].LineCounters;
					foreach (LineCounter lineCounter in lineCounters)
					{
						for (int j = 0; j < lineCounter.codeAreas.Length; j++)
						{
							if (!lineCounter.codeAreas[j].CountsAsCode && lineCounter.counterData[j].TotalCount > 0)
							{
								ListViewItem listViewItem = new ListViewItem(new string[]
								{
									lineCounter.counterData[j].Name.ToString(),
									lineCounter.counterData[j].TotalCount.ToString(),
									"",
									"",
									"",
									""
								});
								listViewItem.Group = listViewGroup;
								this.lvWItems.Items.Add(listViewItem);
							}
						}
					}
					if (counterItem.CounterDataSet.Count <= 0)
					{
						ListViewItem listViewItem = new ListViewItem(new string[]
						{
							"*********** No Result ***********",
							"",
							"",
							"",
							""
						});
						listViewItem.Group = listViewGroup;
						this.lvWItems.Items.Add(listViewItem);
						listViewGroup.Header = counterItem.Name;
					}
					else
					{
						listViewGroup.Header = counterItem.Name;
					}
					num++;
				}
			}
			this.lvWItems.Sort();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000AAB8 File Offset: 0x00009AB8
		private void btnViewReport_Click(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnCancel.Enabled = true;
			this.btnViewReport.Enabled = false;
			this.colName.Text = "Language List";
			this.lvWItems.Items.Clear();
			this.folderList.Clear();
			this.folderBase.Clear();
			this.folderAdd.Clear();
			this.folderModify.Clear();
			this.folderDelete.Clear();
			this.colBase.Text = "Base";
			this.colAdded.Text = "Added";
			this.colModified.Text = "Modified";
			this.colDeleted.Text = "Deleted";
			this.colAddedAndcolModified.Text = "Added+Modified";
			foreach (object obj in this.CISet)
			{
				CounterItem counterItem = (CounterItem)obj;
				if (counterItem.ToBeCount)
				{
					ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
					this.lvWItems.Groups.Add(listViewGroup);
					foreach (object obj2 in counterItem.CounterDataSet)
					{
						LineCounterData lineCounterData = (LineCounterData)obj2;
						string text = lineCounterData.Language.ToString();
						if (!this.folderList.Contains(text))
						{
							this.folderList.Add(text);
							try
							{
								this.folderBase.Add(text, lineCounterData.Base);
								this.folderAdd.Add(text, lineCounterData.AddedLine);
								this.folderModify.Add(text, lineCounterData.ModifiedLine);
								this.folderDelete.Add(text, lineCounterData.DeletedLine);
							}
							catch
							{
							}
						}
						else
						{
							this.folderBase[text] = (long)this.folderBase[text] + lineCounterData.Base;
							this.folderAdd[text] = (long)this.folderAdd[text] + lineCounterData.AddedLine;
							this.folderModify[text] = (long)this.folderModify[text] + lineCounterData.ModifiedLine;
							this.folderDelete[text] = (long)this.folderDelete[text] + lineCounterData.DeletedLine;
						}
					}
					this.folderList.Sort();
					foreach (object obj3 in this.folderList)
					{
						long num = (long)this.folderAdd[obj3] + (long)this.folderModify[obj3];
						ListViewItem listViewItem = new ListViewItem(new string[]
						{
							obj3.ToString(),
							this.folderBase[obj3].ToString(),
							this.folderAdd[obj3].ToString(),
							this.folderModify[obj3].ToString(),
							this.folderDelete[obj3].ToString(),
							num.ToString()
						});
						listViewItem.Group = listViewGroup;
						this.lvWItems.Items.Add(listViewItem);
					}
					if (counterItem.CounterDataSet.Count <= 0)
					{
						ListViewItem listViewItem = new ListViewItem(new string[]
						{
							"*********** No Result ***********",
							"",
							"",
							"",
							""
						});
						listViewItem.Group = listViewGroup;
						this.lvWItems.Items.Add(listViewItem);
						listViewGroup.Header = counterItem.Name;
					}
					else
					{
						listViewGroup.Header = counterItem.Name;
					}
					this.folderList.Clear();
					this.folderBase.Clear();
					this.folderAdd.Clear();
					this.folderModify.Clear();
					this.folderDelete.Clear();
				}
			}
			this.lvWItems.Sort();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000B01C File Offset: 0x0000A01C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400009E RID: 158
		private CounterItemSet CISet;

		// Token: 0x0400009F RID: 159
		private ArrayList folderList = new ArrayList();

		// Token: 0x040000A0 RID: 160
		private Hashtable folderBase = new Hashtable();

		// Token: 0x040000A1 RID: 161
		private Hashtable folderAdd = new Hashtable();

		// Token: 0x040000A2 RID: 162
		private Hashtable folderModify = new Hashtable();

		// Token: 0x040000A3 RID: 163
		private Hashtable folderDelete = new Hashtable();

		// Token: 0x040000A4 RID: 164
		public CodeCounter[] counterArray;
	}
}
