using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000012 RID: 18
	public class CounterCountDetailSet : CollectionBase
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x000040C7 File Offset: 0x000030C7
		public void Add(CounterCountDetail item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000040D8 File Offset: 0x000030D8
		public void Add(ICollection items)
		{
			foreach (object obj in items)
			{
				CounterCountDetail value = (CounterCountDetail)obj;
				base.InnerList.Add(value);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004140 File Offset: 0x00003140
		public void Remove(CounterCountDetail item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x1700004F RID: 79
		public CounterCountDetail this[int index]
		{
			get
			{
				return (CounterCountDetail)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
