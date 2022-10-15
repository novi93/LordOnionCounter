using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000013 RID: 19
	public class CategorySet : CollectionBase
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00004197 File Offset: 0x00003197
		public void Add(Category item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000041A7 File Offset: 0x000031A7
		public void Remove(Category item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000050 RID: 80
		public Category this[int index]
		{
			get
			{
				return (Category)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000041EC File Offset: 0x000031EC
		public bool Contains(Category item)
		{
			bool result = false;
			foreach (object obj in base.InnerList)
			{
				Category category = (Category)obj;
				if (category.CategoryID == item.CategoryID)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004278 File Offset: 0x00003278
		public CategorySet GetFilteredCategorySet(string sGroupID)
		{
			CategorySet categorySet = new CategorySet();
			foreach (object obj in base.InnerList)
			{
				Category category = (Category)obj;
				if (category.Group.GroupID == sGroupID)
				{
					categorySet.Add(category);
				}
			}
			return categorySet;
		}
	}
}
