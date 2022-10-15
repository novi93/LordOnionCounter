using System;
using System.Xml;

namespace MS.IT.LOC.Model
{
	// Token: 0x0200000E RID: 14
	public class CountStandardItem
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000037DC File Offset: 0x000027DC
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000037F4 File Offset: 0x000027F4
		public string DestineLocation
		{
			get
			{
				return this._DestineLocation;
			}
			set
			{
				this._DestineLocation = value;
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(value);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("/lineCounters");
					this.Version = xmlNode.Attributes["version"].Value;
				}
				catch
				{
					this.Version = "";
				}
			}
		}

		// Token: 0x04000052 RID: 82
		public string SourceLocation = "";

		// Token: 0x04000053 RID: 83
		public string Version = "";

		// Token: 0x04000054 RID: 84
		public bool IsUsing = false;

		// Token: 0x04000055 RID: 85
		public bool IsLocal = false;

		// Token: 0x04000056 RID: 86
		private string _DestineLocation = "";
	}
}
