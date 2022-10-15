using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x0200000D RID: 13
	public class GroupItemSet : CollectionBase
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00003705 File Offset: 0x00002705
		public void Add(GroupItem item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003715 File Offset: 0x00002715
		public void Remove(GroupItem item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x1700003A RID: 58
		public GroupItem this[int index]
		{
			get
			{
				return (GroupItem)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000375C File Offset: 0x0000275C
		public GroupItem FindByID(string sGroupID)
		{
			foreach (object obj in base.InnerList)
			{
				GroupItem groupItem = (GroupItem)obj;
				if (groupItem.GroupID == sGroupID)
				{
					return groupItem;
				}
			}
			return null;
		}
	}
}
