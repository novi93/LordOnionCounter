using System;
using System.Collections;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x0200000A RID: 10
	public class PspMetricCounterDataSet : CollectionBase
	{
		// Token: 0x17000014 RID: 20
		public PspMetricCounterData this[int index]
		{
			get
			{
				return (PspMetricCounterData)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000342C File Offset: 0x0000242C
		public int Add(PspMetricCounterData value)
		{
			return base.List.Add(value);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000344C File Offset: 0x0000244C
		public int IndexOf(PspMetricCounterData value)
		{
			return base.List.IndexOf(value);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000346A File Offset: 0x0000246A
		public void Insert(int index, PspMetricCounterData value)
		{
			base.List.Insert(index, value);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000347B File Offset: 0x0000247B
		public void Remove(PspMetricCounterData value)
		{
			base.List.Remove(value);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000348C File Offset: 0x0000248C
		public bool Contains(PspMetricCounterData value)
		{
			return base.List.Contains(value);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000034AA File Offset: 0x000024AA
		protected override void OnInsert(int index, object value)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000034AD File Offset: 0x000024AD
		protected override void OnRemove(int index, object value)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000034B0 File Offset: 0x000024B0
		protected override void OnSet(int index, object oldValue, object newValue)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000034B4 File Offset: 0x000024B4
		protected override void OnValidate(object value)
		{
			if (value.GetType() != typeof(PspMetricCounterData))
			{
				throw new ArgumentException("value must be of type PspMetricCounterData.", "value");
			}
		}

		// Token: 0x0400001F RID: 31
		public int currentDataId;
	}
}
