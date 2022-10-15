using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000014 RID: 20
	public class LineCounterDataSet : CollectionBase
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00004310 File Offset: 0x00003310
		public void Add(LineCounterData item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004320 File Offset: 0x00003320
		public void Add(ICollection items)
		{
			foreach (object obj in items)
			{
				LineCounterData value = (LineCounterData)obj;
				base.InnerList.Add(value);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004388 File Offset: 0x00003388
		public void Remove(LineCounterData item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000051 RID: 81
		public LineCounterData this[int index]
		{
			get
			{
				return (LineCounterData)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}
	}
}
