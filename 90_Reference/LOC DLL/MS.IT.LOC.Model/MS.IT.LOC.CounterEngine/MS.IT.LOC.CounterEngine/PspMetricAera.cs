using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x02000008 RID: 8
	public class PspMetricAera
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002A74 File Offset: 0x00001A74
		public PspMetricAera(XmlNode node)
		{
			this.LoadFromXmlNode(node);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002AC8 File Offset: 0x00001AC8
		protected void LoadFromXmlNode(XmlNode node)
		{
			if (node.Name != "pspMetricArea")
			{
				throw new ArgumentException("invalid xml schema", "node");
			}
			this.LoadPspMetricAreaAttributes(node);
			this.LoadPspMetricAreaExpressions(node);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002B10 File Offset: 0x00001B10
		protected void LoadPspMetricAreaExpressions(XmlNode node)
		{
			if (node.Name != "pspMetricArea")
			{
				throw new ArgumentException("invalid xml schema", "node");
			}
			RegexOptions regexOptions = RegexOptions.Compiled | RegexOptions.Singleline;
			if (!this.caseSensitive)
			{
				regexOptions |= RegexOptions.IgnoreCase;
			}
			XmlNodeList xmlNodeList = node.SelectNodes("PspMetricNameFlag");
			this.PspMetricNameExps = new Regex[xmlNodeList.Count];
			int num = 0;
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				string innerText = xmlNode.InnerText;
				this.PspMetricNameExps[num++] = new Regex(innerText, regexOptions);
			}
			xmlNodeList = node.SelectNodes("pspMetricAreaStartFlag");
			this.PspMetricAreastartExps = new Regex[xmlNodeList.Count];
			num = 0;
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj2;
				string innerText = xmlNode.InnerText;
				this.PspMetricAreastartExps[num++] = new Regex(innerText, regexOptions);
			}
			xmlNodeList = node.SelectNodes("pspMetricAreaEndFlag");
			if (xmlNodeList.Count == 0)
			{
				this.PspMetricAreaendExps = this.PspMetricAreastartExps;
			}
			else
			{
				this.PspMetricAreaendExps = new Regex[xmlNodeList.Count];
				num = 0;
				foreach (object obj3 in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj3;
					string innerText = xmlNode.InnerText;
					this.PspMetricAreaendExps[num++] = new Regex(innerText, regexOptions);
				}
			}
			xmlNodeList = node.SelectNodes("ObjectType");
			this.ObjectTypeExps = new Regex[xmlNodeList.Count];
			num = 0;
			foreach (object obj4 in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj4;
				string innerText = xmlNode.InnerText;
				this.ObjectTypeExps[num++] = new Regex(innerText, regexOptions);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002DC0 File Offset: 0x00001DC0
		protected void LoadPspMetricAreaAttributes(XmlNode node)
		{
			XmlAttribute xmlAttribute = node.Attributes["name"];
			if (xmlAttribute != null)
			{
				this.name = xmlAttribute.Value;
			}
			XmlAttribute xmlAttribute2 = node.Attributes["toCount"];
			if (xmlAttribute2 != null)
			{
				this.toCount = Convert.ToBoolean(xmlAttribute2.Value);
			}
			else
			{
				this.toCount = true;
			}
			XmlAttribute xmlAttribute3 = node.Attributes["multiLine"];
			if (xmlAttribute3 != null)
			{
				this.multiLine = Convert.ToBoolean(xmlAttribute3.Value);
			}
			else
			{
				this.multiLine = true;
			}
			XmlAttribute xmlAttribute4 = node.Attributes["caseSensitive"];
			if (xmlAttribute4 != null)
			{
				this.caseSensitive = Convert.ToBoolean(xmlAttribute4.Value);
			}
			else
			{
				this.caseSensitive = true;
			}
			XmlAttribute xmlAttribute5 = node.Attributes["description"];
			if (xmlAttribute5 != null)
			{
				this.description = xmlAttribute5.Value;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002EDC File Offset: 0x00001EDC
		public bool isAPspMetricStartFlag(string line)
		{
			for (int i = 0; i < this.PspMetricAreastartExps.Length; i++)
			{
				Match match = this.PspMetricAreastartExps[i].Match(line);
				if (match.Success)
				{
					bool result;
					if (this.pspMetricCounterData.endLine == 0)
					{
						result = true;
					}
					else
					{
						this.pspMetricCounterData = new PspMetricCounterData();
						this.onCounting++;
						this.totalPspMetricDataCount++;
						this.pspMetricCounterData.id = this.totalPspMetricDataCount;
						this.pspMetricCounterData.Name = this.pspMetricCounterData.id.ToString();
						for (int j = 0; j < this.PspMetricNameExps.Length; j++)
						{
							MatchCollection matchCollection = this.PspMetricNameExps[j].Matches(line);
							string name = string.Empty;
							foreach (object obj in matchCollection)
							{
								Match match2 = (Match)obj;
								if (match2.Length != 0)
								{
									name = match2.Value;
									break;
								}
							}
							match = this.PspMetricNameExps[j].Match(line);
							if (match.Success)
							{
								this.pspMetricCounterData.Name = name;
								break;
							}
						}
						this.pspMetricCounterData.PspMetricObjectType = "";
						for (int j = 0; j < this.ObjectTypeExps.Length; j++)
						{
							MatchCollection matchCollection = this.ObjectTypeExps[j].Matches(line);
							string pspMetricObjectType = string.Empty;
							foreach (object obj2 in matchCollection)
							{
								Match match2 = (Match)obj2;
								if (match2.Length != 0)
								{
									pspMetricObjectType = match2.Value;
									break;
								}
							}
							match = this.ObjectTypeExps[j].Match(line);
							if (match.Success)
							{
								this.pspMetricCounterData.PspMetricObjectType = pspMetricObjectType;
								break;
							}
						}
						result = true;
					}
					return result;
				}
			}
			return false;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003184 File Offset: 0x00002184
		public bool isAPspMetricStartFlag(string line, int type)
		{
			for (int i = 0; i < this.PspMetricAreastartExps.Length; i++)
			{
				Match match = this.PspMetricAreastartExps[i].Match(line);
				if (match.Success)
				{
					for (int j = 0; j < this.PspMetricNameExps.Length; j++)
					{
						match = this.PspMetricNameExps[j].Match(line);
						if (match.Success)
						{
							this.pspMetricCounterData.NewName = match.ToString();
							break;
						}
					}
					for (int j = 0; j < this.ObjectTypeExps.Length; j++)
					{
						match = this.ObjectTypeExps[j].Match(line);
						if (match.Success)
						{
							this.pspMetricCounterData.PspMetricNewObjectType = match.ToString();
							break;
						}
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003280 File Offset: 0x00002280
		public bool isAPspMetricEndFlag(string line)
		{
			for (int i = 0; i < this.PspMetricAreaendExps.Length; i++)
			{
				Match match = this.PspMetricAreaendExps[i].Match(line);
				if (match.Success)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000032D4 File Offset: 0x000022D4
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000032EC File Offset: 0x000022EC
		internal string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000032F8 File Offset: 0x000022F8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00003310 File Offset: 0x00002310
		public int onCounting
		{
			get
			{
				return this._onCounting;
			}
			set
			{
				this._onCounting = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000331C File Offset: 0x0000231C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003334 File Offset: 0x00002334
		public bool toCount
		{
			get
			{
				return this._toCount;
			}
			set
			{
				this._toCount = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003340 File Offset: 0x00002340
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003358 File Offset: 0x00002358
		public bool multiLine
		{
			get
			{
				return this._multiLine;
			}
			set
			{
				this._multiLine = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003364 File Offset: 0x00002364
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000337C File Offset: 0x0000237C
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003388 File Offset: 0x00002388
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000033A0 File Offset: 0x000023A0
		public bool caseSensitive
		{
			get
			{
				return this._caseSensitive;
			}
			set
			{
				this._caseSensitive = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private Regex[] PspMetricNameExps;

		// Token: 0x04000012 RID: 18
		private Regex[] PspMetricAreastartExps;

		// Token: 0x04000013 RID: 19
		private Regex[] PspMetricAreaendExps;

		// Token: 0x04000014 RID: 20
		private Regex[] ObjectTypeExps;

		// Token: 0x04000015 RID: 21
		private string _name = null;

		// Token: 0x04000016 RID: 22
		private int _onCounting = 0;

		// Token: 0x04000017 RID: 23
		private bool _toCount = false;

		// Token: 0x04000018 RID: 24
		private bool _multiLine;

		// Token: 0x04000019 RID: 25
		private string _description = null;

		// Token: 0x0400001A RID: 26
		private bool _caseSensitive = true;

		// Token: 0x0400001B RID: 27
		public PspMetricCounterData pspMetricCounterData = new PspMetricCounterData(-1);

		// Token: 0x0400001C RID: 28
		public int totalPspMetricDataCount = 0;
	}
}
