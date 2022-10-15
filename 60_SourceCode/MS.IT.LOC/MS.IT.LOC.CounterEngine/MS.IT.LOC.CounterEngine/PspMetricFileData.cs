using System;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000009 RID: 9
	public class PspMetricFileData
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000033AA File Offset: 0x000023AA
		internal PspMetricFileData(string thisFileName)
		{
			this._fileName = thisFileName;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000033C8 File Offset: 0x000023C8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000033E0 File Offset: 0x000023E0
		public string fileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				this._fileName = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private string _fileName;

		// Token: 0x0400001E RID: 30
		public PspMetricCounterDataSet pspMetricCounterDataSet = new PspMetricCounterDataSet();
	}
}
