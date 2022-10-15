using System;
using System.Collections;
using System.Xml;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000011 RID: 17
	public class Element
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00003CC8 File Offset: 0x00002CC8
		public Element()
		{
			this._ElementID = Guid.NewGuid().ToString();
			this._IsDirty = true;
			this._IsNew = true;
			this._Saved = true;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003D24 File Offset: 0x00002D24
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00003D3C File Offset: 0x00002D3C
		public SCItemType ElementType
		{
			get
			{
				return this._ElementType;
			}
			set
			{
				this._ElementType = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003D54 File Offset: 0x00002D54
		public string Name
		{
			get
			{
				string result;
				if (this.ServerPath != null)
				{
					string[] array = this.ServerPath.Split(new char[]
					{
						'/'
					});
					result = array[array.Length - 1];
				}
				else
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003D9C File Offset: 0x00002D9C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00003DB4 File Offset: 0x00002DB4
		public string ServerPath
		{
			get
			{
				return this._ServerPath;
			}
			set
			{
				this._ServerPath = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003DCC File Offset: 0x00002DCC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00003DE4 File Offset: 0x00002DE4
		public bool Include
		{
			get
			{
				return this._Include;
			}
			set
			{
				this._Include = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003DFC File Offset: 0x00002DFC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00003E14 File Offset: 0x00002E14
		public string ElementID
		{
			get
			{
				return this._ElementID;
			}
			set
			{
				this._ElementID = value;
				this._IsDirty = true;
				this._Saved = false;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003E2C File Offset: 0x00002E2C
		public bool IsDirty
		{
			get
			{
				return this._IsDirty;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003E44 File Offset: 0x00002E44
		public bool IsNew
		{
			get
			{
				return this._IsNew;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003E5C File Offset: 0x00002E5C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00003E74 File Offset: 0x00002E74
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
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003E88 File Offset: 0x00002E88
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00003EA0 File Offset: 0x00002EA0
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

		// Token: 0x060000B2 RID: 178 RVA: 0x00003EB8 File Offset: 0x00002EB8
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003ED0 File Offset: 0x00002ED0
		public void FromXMLNode(XmlNode node)
		{
			if (node.Attributes["Include"].Value == "Y")
			{
				this.Include = true;
			}
			else
			{
				this.Include = false;
			}
			if (node.Attributes["ElementType"].Value == "File")
			{
				this.ElementType = SCItemType.FILE;
			}
			else if (node.Attributes["ElementType"].Value == "Folder")
			{
				this.ElementType = SCItemType.FOLDER;
			}
			this.ServerPath = node.Attributes["ServerPath"].Value;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003F98 File Offset: 0x00002F98
		public void ToXML(XmlTextWriter textWriter)
		{
			textWriter.WriteStartElement("Element");
			string value = "";
			textWriter.WriteAttributeString("Include", this.Include ? "Y" : "N");
			if (this.ElementType == SCItemType.FILE)
			{
				value = "File";
			}
			else if (this.ElementType == SCItemType.FOLDER)
			{
				value = "Folder";
			}
			textWriter.WriteAttributeString("ElementType", value);
			textWriter.WriteAttributeString("ServerPath", this._ServerPath);
			textWriter.WriteEndElement();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004030 File Offset: 0x00003030
		public void LoadObject(Hashtable objList)
		{
			this._ElementID = (string)objList["ElementID"];
			this._Include = (bool)objList["Include"];
			this._ElementType = (((int)objList["ElementType"] == 0) ? SCItemType.FILE : SCItemType.FOLDER);
			this._ServerPath = (string)objList["ServerPath"];
			this._CounterItemID = (string)objList["CounterItemID"];
			this._IsDirty = false;
			this._IsNew = false;
			this._Saved = true;
		}

		// Token: 0x04000069 RID: 105
		private SCItemType _ElementType;

		// Token: 0x0400006A RID: 106
		private string _ServerPath;

		// Token: 0x0400006B RID: 107
		private bool _Include;

		// Token: 0x0400006C RID: 108
		private string _ElementID;

		// Token: 0x0400006D RID: 109
		private bool _IsDirty = false;

		// Token: 0x0400006E RID: 110
		private bool _IsNew = false;

		// Token: 0x0400006F RID: 111
		private string _CounterItemID;

		// Token: 0x04000070 RID: 112
		private bool _Saved = true;
	}
}
