using System;
using System.Collections;
using System.Windows.Forms;

namespace MS.IT.LOC.UI
{
	// Token: 0x02000003 RID: 3
	public class ListViewColumnSorter : IComparer
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002884 File Offset: 0x00001884
		public ListViewColumnSorter()
		{
			this.ColumnToSort = 0;
			this.OrderOfSort = SortOrder.None;
			this.ObjectCompare = new CaseInsensitiveComparer();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028A8 File Offset: 0x000018A8
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = this.ObjectCompare.Compare(listViewItem.SubItems[this.ColumnToSort].Text, listViewItem2.SubItems[this.ColumnToSort].Text);
			int result;
			if (this.OrderOfSort == SortOrder.Ascending)
			{
				result = num;
			}
			else if (this.OrderOfSort == SortOrder.Descending)
			{
				result = -num;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000293C File Offset: 0x0000193C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002931 File Offset: 0x00001931
		public int SortColumn
		{
			get
			{
				return this.ColumnToSort;
			}
			set
			{
				this.ColumnToSort = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002960 File Offset: 0x00001960
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002954 File Offset: 0x00001954
		public SortOrder Order
		{
			get
			{
				return this.OrderOfSort;
			}
			set
			{
				this.OrderOfSort = value;
			}
		}

		// Token: 0x0400000D RID: 13
		private int ColumnToSort;

		// Token: 0x0400000E RID: 14
		private SortOrder OrderOfSort;

		// Token: 0x0400000F RID: 15
		private CaseInsensitiveComparer ObjectCompare;
	}
}
