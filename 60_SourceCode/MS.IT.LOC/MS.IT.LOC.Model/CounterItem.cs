using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000003 RID: 3
	public class CounterItem
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002208 File Offset: 0x00001208
		public CounterItem()
		{
			this._CounterItemID = Guid.NewGuid().ToString();
			this._CategorySet = new CategorySet();
			this._ExcludeElementSet = new ElementSet(this);
			this._IncludeElementSet = new ElementSet(this);
			this._ToBeCount = true;
			this._IsNew = true;
			this._IsDirty = true;
			this._Saved = true;
			this._PspMetrics = false;
			this._MReport = false;
			this._StandardReport = true;
			this._ServerName = "";
			this._ServerType = SourceServerType.Base;
			this._ServerPort = "";
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002358 File Offset: 0x00001358
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002370 File Offset: 0x00001370
		[ReadOnly(true)]
		[Description("PSP Metrics")]
		[Browsable(true)]
		public bool PspMetrics
		{
			get
			{
				return this._PspMetrics;
			}
			set
			{
				this._PspMetrics = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000237C File Offset: 0x0000137C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002394 File Offset: 0x00001394
		[ReadOnly(true)]
		[Description("M Report")]
		[Browsable(true)]
		public bool MReport
		{
			get
			{
				return this._MReport;
			}
			set
			{
				this._MReport = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000023A0 File Offset: 0x000013A0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000023B8 File Offset: 0x000013B8
		[Description("Standard Report")]
		[ReadOnly(true)]
		[Browsable(true)]
		public bool StandardReport
		{
			get
			{
				return this._StandardReport;
			}
			set
			{
				this._StandardReport = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000023C4 File Offset: 0x000013C4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000023DC File Offset: 0x000013DC
		[Browsable(true)]
		[Description("Base item in source control")]
		[ReadOnly(true)]
		public string BaseItem
		{
			get
			{
				return this._BaseItem;
			}
			set
			{
				this._BaseItem = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000023E8 File Offset: 0x000013E8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002400 File Offset: 0x00001400
		[ReadOnly(true)]
		[Description("Diff item in source control")]
		[Browsable(true)]
		public string DiffItem
		{
			get
			{
				return this._DiffItem;
			}
			set
			{
				this._DiffItem = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000240C File Offset: 0x0000140C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002424 File Offset: 0x00001424
		[ReadOnly(true)]
		[Description("Diff item in source control")]
		[Browsable(true)]
		public string LabelsBeseVer
		{
			get
			{
				return this._LabelsBeseVer;
			}
			set
			{
				this._LabelsBeseVer = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002430 File Offset: 0x00001430
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002448 File Offset: 0x00001448
		[Browsable(true)]
		[Description("Diff item in source control")]
		[ReadOnly(true)]
		public string LabelsDiffVer
		{
			get
			{
				return this._LabelsDiffVer;
			}
			set
			{
				this._LabelsDiffVer = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002454 File Offset: 0x00001454
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000246C File Offset: 0x0000146C
		[Browsable(true)]
		[Description("Base version in source control")]
		[ReadOnly(true)]
		public string BaseVersion
		{
			get
			{
				return this._BaseVersion;
			}
			set
			{
				this._BaseVersion = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002478 File Offset: 0x00001478
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002490 File Offset: 0x00001490
		[ReadOnly(true)]
		[Browsable(true)]
		[Description("Diff version in source control")]
		public string DiffVersion
		{
			get
			{
				return this._DiffVersion;
			}
			set
			{
				this._DiffVersion = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000249C File Offset: 0x0000149C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000024B4 File Offset: 0x000014B4
		[Browsable(true)]
		[Description("Source control server port")]
		[ReadOnly(true)]
		public string ServerPort
		{
			get
			{
				return this._ServerPort;
			}
			set
			{
				this._ServerPort = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000024C0 File Offset: 0x000014C0
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000024D8 File Offset: 0x000014D8
		[Description("Source control server user")]
		[ReadOnly(true)]
		[Browsable(true)]
		public string ServerUser
		{
			get
			{
				return this._ServerUser;
			}
			set
			{
				this._ServerUser = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000024E4 File Offset: 0x000014E4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000024FC File Offset: 0x000014FC
		[Description("Source control server user password")]
		[ReadOnly(true)]
		[Browsable(true)]
		public string ServerPassword
		{
			get
			{
				return this._ServerPassword;
			}
			set
			{
				this._ServerPassword = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002508 File Offset: 0x00001508
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002520 File Offset: 0x00001520
		[Browsable(false)]
		public LineCounterDataSet CounterDataSet
		{
			get
			{
				return this._CounterDataSet;
			}
			set
			{
				this._CounterDataSet = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000252C File Offset: 0x0000152C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002544 File Offset: 0x00001544
		[ReadOnly(true)]
		[Browsable(true)]
		[Description("Type of counter task")]
		public CIType Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
				this._IsDirty = true;
				this._Saved = false;
				if (this._Type == CIType.LATEST)
				{
					this._StartDate = DateTime.MinValue.Date;
					this._EndDate = DateTime.MinValue.Date;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000025A0 File Offset: 0x000015A0
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000025BD File Offset: 0x000015BD
		[Browsable(true)]
		[Description("Start date of counter task")]
		[DisplayName("Start Date")]
		[ReadOnly(true)]
		public DateTime StartDate
		{
			get
			{
				return this._StartDate.Date;
			}
			set
			{
				this._StartDate = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000025D8 File Offset: 0x000015D8
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000025F5 File Offset: 0x000015F5
		[Description("End date of counter task")]
		[Browsable(true)]
		[DisplayName("End Date")]
		[ReadOnly(true)]
		public DateTime EndDate
		{
			get
			{
				return this._EndDate.Date;
			}
			set
			{
				this._EndDate = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002610 File Offset: 0x00001610
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002628 File Offset: 0x00001628
		[Browsable(false)]
		public ElementSet IncludeElementSet
		{
			get
			{
				return this._IncludeElementSet;
			}
			set
			{
				this._IncludeElementSet = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002640 File Offset: 0x00001640
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002658 File Offset: 0x00001658
		[Browsable(false)]
		public ElementSet ExcludeElementSet
		{
			get
			{
				return this._ExcludeElementSet;
			}
			set
			{
				this._ExcludeElementSet = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002670 File Offset: 0x00001670
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002688 File Offset: 0x00001688
		[Browsable(false)]
		public SCItemSet DownLoadItems
		{
			get
			{
				return this._DownLoadItems;
			}
			set
			{
				this._DownLoadItems = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002694 File Offset: 0x00001694
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000026AC File Offset: 0x000016AC
		[Description("Name of counter task")]
		[ReadOnly(true)]
		[Browsable(true)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if (value.ToString().Trim().Length <= 100)
				{
					this._Name = value;
					this._IsDirty = true;
					this._Saved = false;
					return;
				}
				throw new Exception("Length of counter task should be less than equal to 100.");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000026F8 File Offset: 0x000016F8
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002710 File Offset: 0x00001710
		[Browsable(false)]
		public string CounterItemID
		{
			get
			{
				return this._CounterItemID;
			}
			set
			{
				this._CounterItemID = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002728 File Offset: 0x00001728
		[ReadOnly(true)]
		[Browsable(true)]
		[Description("Is counter task configured")]
		public string Configured
		{
			get
			{
				string result;
				if (this._ExcludeElementSet.Count <= 0 && this._IncludeElementSet.Count <= 0)
				{
					result = "No";
				}
				else
				{
					result = "Yes";
				}
				return result;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000276C File Offset: 0x0000176C
		[Browsable(false)]
		public bool IsDirty
		{
			get
			{
				return this._IsDirty;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002784 File Offset: 0x00001784
		[Browsable(false)]
		public bool IsNew
		{
			get
			{
				return this._IsNew;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000279C File Offset: 0x0000179C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000027B4 File Offset: 0x000017B4
		[ReadOnly(true)]
		[Browsable(true)]
		[Description("Enable/Disable counter task")]
		[DisplayName("Enable")]
		public bool ToBeCount
		{
			get
			{
				return this._ToBeCount;
			}
			set
			{
				this._ToBeCount = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000027CC File Offset: 0x000017CC
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000027E4 File Offset: 0x000017E4
		[Description("The source control server name")]
		[ReadOnly(true)]
		[Browsable(true)]
		[DisplayName("ServerName")]
		public string ServerName
		{
			get
			{
				return this._ServerName;
			}
			set
			{
				this._ServerName = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000027F0 File Offset: 0x000017F0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002808 File Offset: 0x00001808
		[DisplayName("ServerType")]
		[ReadOnly(true)]
		[Browsable(true)]
		[Description("the source control server type")]
		public SourceServerType ServerType
		{
			get
			{
				return this._ServerType;
			}
			set
			{
				this._ServerType = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002814 File Offset: 0x00001814
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000282C File Offset: 0x0000182C
		[Browsable(false)]
		public CategorySet CategoryList
		{
			get
			{
				return this._CategorySet;
			}
			set
			{
				this._CategorySet = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002844 File Offset: 0x00001844
		[Description("Categories of counter task")]
		[Browsable(true)]
		[ReadOnly(true)]
		public string Categories
		{
			get
			{
				string text = "";
				foreach (object obj in this._CategorySet)
				{
					Category category = (Category)obj;
					text = text + category.CategoryName + ",";
				}
				text = ((text.Length > 0) ? text.Substring(0, text.Length - 1) : "");
				return text;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000028E8 File Offset: 0x000018E8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002900 File Offset: 0x00001900
		[Browsable(false)]
		public bool Saved
		{
			get
			{
				return this._Saved;
			}
			set
			{
				this._Saved = value;
				this._IsDirty = false;
				this._IsNew = false;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002918 File Offset: 0x00001918
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002930 File Offset: 0x00001930
		[ReadOnly(true)]
		[Description("Number of weeks between the code changes occurred")]
		[Browsable(true)]
		public double WeeksofChurn
		{
			get
			{
				return this._WeeksofChurn;
			}
			set
			{
				this._WeeksofChurn = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000293C File Offset: 0x0000193C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002954 File Offset: 0x00001954
		[Browsable(true)]
		[Description("Number of Builds / Drops during weeks of churn")]
		[ReadOnly(true)]
		public double Churncount
		{
			get
			{
				return this._Churncount;
			}
			set
			{
				this._Churncount = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002960 File Offset: 0x00001960
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002978 File Offset: 0x00001978
		[ReadOnly(true)]
		[Description("Reserved")]
		[Browsable(true)]
		public string Reserved
		{
			get
			{
				return this._Reserved;
			}
			set
			{
				this._Reserved = value;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002984 File Offset: 0x00001984
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000299C File Offset: 0x0000199C
		public void FromXMLNode(XmlNode node)
		{
			this.IncludeElementSet.Clear();
			this.ExcludeElementSet.Clear();
			if (node.Attributes["Type"].Value == "DateRange")
			{
				this._Type = CIType.DATE_RANGE;
			}
			else if (node.Attributes["Type"].Value == "Latest")
			{
				this._Type = CIType.LATEST;
			}
			this.StartDate = DateTime.Parse(node.Attributes["StartDate"].Value);
			this.EndDate = DateTime.Parse(node.Attributes["EndDate"].Value);
			this.Name = node.Attributes["Name"].Value;
			XmlNodeList childNodes = node.ChildNodes;
			foreach (object obj in childNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					if (xmlNode.Name == "Element")
					{
						Element element = new Element();
						element.FromXMLNode(xmlNode);
						if (xmlNode.Attributes["Include"].Value == "Y")
						{
							this.IncludeElementSet.Add(element);
						}
						else
						{
							this.ExcludeElementSet.Add(element);
						}
					}
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002B60 File Offset: 0x00001B60
		public void ToXML(XmlTextWriter textWriter)
		{
			StringBuilder stringBuilder = new StringBuilder();
			textWriter.WriteStartElement("CounterItem");
			if (this.Type == CIType.DATE_RANGE)
			{
				textWriter.WriteAttributeString("Type", "DateRange");
			}
			else if (this.Type == CIType.LATEST)
			{
				textWriter.WriteAttributeString("Type", "Latest");
			}
			textWriter.WriteAttributeString("StartDate", this.StartDate.ToString());
			textWriter.WriteAttributeString("EndDate", this.EndDate.ToString());
			textWriter.WriteAttributeString("Name", this.Name.ToString());
			foreach (object obj in this.IncludeElementSet)
			{
				Element element = (Element)obj;
				element.ToXML(textWriter);
			}
			foreach (object obj2 in this.ExcludeElementSet)
			{
				Element element = (Element)obj2;
				element.ToXML(textWriter);
			}
			textWriter.WriteEndElement();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002CE4 File Offset: 0x00001CE4
		public void LoadObject(Hashtable objList)
		{
			this._CounterItemID = (string)objList["CounterItemID"];
			this._Name = (string)objList["Name"];
			this._Type = (CIType)((int)objList["ItemType"]);
			this._StartDate = (DateTime)objList["StartDate"];
			this._EndDate = (DateTime)objList["EndDate"];
			this._BaseVersion = (string)objList["BaseVersion"];
			this._DiffVersion = (string)objList["DiffVersion"];
			this._BaseItem = (string)objList["BaseItem"];
			this._DiffItem = (string)objList["DiffItem"];
			this._ToBeCount = (bool)objList["ToBeCount"];
			this._IncludeElementSet.Add((ElementSet)objList["IncludeElementSet"]);
			this._ExcludeElementSet.Add((ElementSet)objList["ExcludeElementSet"]);
			this._CategorySet = (CategorySet)objList["CategoryList"];
			this._IsDirty = false;
			this._IsNew = false;
			this._Saved = true;
			try
			{
				this._PspMetrics = bool.Parse((string)objList["PspMetrics"]);
			}
			catch
			{
				this._PspMetrics = false;
			}
			try
			{
				this._MReport = bool.Parse((string)objList["MReport"]);
			}
			catch
			{
				this._MReport = false;
			}
			try
			{
				this._StandardReport = bool.Parse((string)objList["StandardReport"]);
			}
			catch
			{
				this._StandardReport = true;
			}
			this._ServerName = (string)objList["ServerName"];
			this._ServerPort = (string)objList["ServerPort"];
			if (objList["ServerType"] != null)
			{
				switch ((int)objList["ServerType"])
				{
				case 1:
					this._ServerType = SourceServerType.VSTF;
					break;
				case 2:
					this._ServerType = SourceServerType.VSS;
					break;
				case 3:
					this._ServerType = SourceServerType.SD;
					break;
				case 4:
					this._ServerType = SourceServerType.FILESYS;
					break;
				default:
					this._ServerType = SourceServerType.Base;
					break;
				}
			}
			else
			{
				this._ServerType = SourceServerType.Base;
			}
		}

		// Token: 0x04000007 RID: 7
		private bool _PspMetrics = false;

		// Token: 0x04000008 RID: 8
		private bool _MReport = false;

		// Token: 0x04000009 RID: 9
		private bool _StandardReport = true;

		// Token: 0x0400000A RID: 10
		private string _BaseItem = "";

		// Token: 0x0400000B RID: 11
		private string _DiffItem = "";

		// Token: 0x0400000C RID: 12
		private string _LabelsBeseVer = "";

		// Token: 0x0400000D RID: 13
		private string _LabelsDiffVer = "";

		// Token: 0x0400000E RID: 14
		private string _BaseVersion = "";

		// Token: 0x0400000F RID: 15
		private string _DiffVersion = "";

		// Token: 0x04000010 RID: 16
		private string _ServerPort = "";

		// Token: 0x04000011 RID: 17
		private string _ServerUser = "";

		// Token: 0x04000012 RID: 18
		private string _ServerPassword = "";

		// Token: 0x04000013 RID: 19
		private LineCounterDataSet _CounterDataSet = new LineCounterDataSet();

		// Token: 0x04000014 RID: 20
		public Hashtable PspMetricHash = new Hashtable();

		// Token: 0x04000015 RID: 21
		private CIType _Type;

		// Token: 0x04000016 RID: 22
		private DateTime _StartDate;

		// Token: 0x04000017 RID: 23
		private DateTime _EndDate;

		// Token: 0x04000018 RID: 24
		private ElementSet _IncludeElementSet;

		// Token: 0x04000019 RID: 25
		private ElementSet _ExcludeElementSet;

		// Token: 0x0400001A RID: 26
		private SCItemSet _DownLoadItems = new SCItemSet();

		// Token: 0x0400001B RID: 27
		private string _Name;

		// Token: 0x0400001C RID: 28
		private string _CounterItemID;

		// Token: 0x0400001D RID: 29
		internal bool _IsDirty = false;

		// Token: 0x0400001E RID: 30
		private bool _IsNew = false;

		// Token: 0x0400001F RID: 31
		private bool _ToBeCount;

		// Token: 0x04000020 RID: 32
		private string _ServerName;

		// Token: 0x04000021 RID: 33
		private SourceServerType _ServerType;

		// Token: 0x04000022 RID: 34
		private CategorySet _CategorySet;

		// Token: 0x04000023 RID: 35
		internal bool _Saved = true;

		// Token: 0x04000024 RID: 36
		private double _WeeksofChurn;

		// Token: 0x04000025 RID: 37
		private double _Churncount;

		// Token: 0x04000026 RID: 38
		private string _Reserved;
	}
}
