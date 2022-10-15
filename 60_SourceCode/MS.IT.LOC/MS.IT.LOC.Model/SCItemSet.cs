using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000017 RID: 23
	public class SCItemSet : CollectionBase
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00004720 File Offset: 0x00003720
		public void Add(SCItem scItem)
		{
			base.InnerList.Add(scItem);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004730 File Offset: 0x00003730
		public void Remove(SCItem scItem)
		{
			base.InnerList.Remove(scItem);
		}

		// Token: 0x17000058 RID: 88
		public SCItem this[int index]
		{
			get
			{
				return (SCItem)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		public SCItem this[string id]
		{
			get
			{
				foreach (object obj in base.InnerList)
				{
					SCItem scitem = (SCItem)obj;
					if (scitem.ID == id)
					{
						return scitem;
					}
				}
				return null;
			}
		}
	}
}
