using System;
using System.Collections;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000010 RID: 16
	public class ElementSet : CollectionBase
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00003BB0 File Offset: 0x00002BB0
		public ElementSet() : this(null)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003BBC File Offset: 0x00002BBC
		public ElementSet(CounterItem item)
		{
			this.objCI = item;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003BCE File Offset: 0x00002BCE
		public void Add(Element item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003BE0 File Offset: 0x00002BE0
		public void Add(ICollection items)
		{
			foreach (object obj in items)
			{
				Element value = (Element)obj;
				base.InnerList.Add(value);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003C48 File Offset: 0x00002C48
		public void Remove(Element item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x17000045 RID: 69
		public Element this[int index]
		{
			get
			{
				return (Element)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003C8C File Offset: 0x00002C8C
		protected override void OnClear()
		{
			base.OnClear();
			if (this.objCI != null)
			{
				this.objCI._IsDirty = true;
				this.objCI._Saved = false;
			}
		}

		// Token: 0x04000068 RID: 104
		private CounterItem objCI;
	}
}
