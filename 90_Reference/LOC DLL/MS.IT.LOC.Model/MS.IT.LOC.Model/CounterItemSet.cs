using System;
using System.Collections;
using System.Xml;

namespace MS.IT.LOC.Model
{
	// Token: 0x02000009 RID: 9
	public class CounterItemSet : CollectionBase
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00003064 File Offset: 0x00002064
		public CounterItemSet()
		{
			this._categoryFilterList = new ArrayList();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000307C File Offset: 0x0000207C
		public ArrayList CategoryFilters
		{
			get
			{
				return this._categoryFilterList;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003094 File Offset: 0x00002094
		public CounterItemSet FilteredItems
		{
			get
			{
				CounterItemSet result;
				if (this._categoryFilterList.Count > 0)
				{
					CounterItemSet counterItemSet = new CounterItemSet();
					bool flag = true;
					foreach (object obj in base.InnerList)
					{
						CounterItem counterItem = (CounterItem)obj;
						flag = true;
						foreach (object obj2 in this._categoryFilterList)
						{
							Category item = (Category)obj2;
							if (!counterItem.CategoryList.Contains(item))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							counterItemSet.Add(counterItem);
						}
					}
					result = counterItemSet;
				}
				else
				{
					result = this;
				}
				return result;
			}
		}

		// Token: 0x1700002D RID: 45
		public CounterItem this[int index]
		{
			get
			{
				return (CounterItem)base.InnerList[index];
			}
			set
			{
				base.InnerList[index] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		public CounterItem this[string id]
		{
			get
			{
				foreach (object obj in base.InnerList)
				{
					CounterItem counterItem = (CounterItem)obj;
					if (counterItem.CounterItemID == id)
					{
						return counterItem;
					}
				}
				return null;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003270 File Offset: 0x00002270
		public void Add(CounterItem item)
		{
			base.InnerList.Add(item);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003280 File Offset: 0x00002280
		public void Remove(CounterItem item)
		{
			base.InnerList.Remove(item);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003290 File Offset: 0x00002290
		public void ToXML(XmlTextWriter textWriter)
		{
			textWriter.WriteStartDocument();
			textWriter.WriteStartElement("Root");
			foreach (object obj in base.InnerList)
			{
				CounterItem counterItem = (CounterItem)obj;
				counterItem.ToXML(textWriter);
			}
			textWriter.WriteEndElement();
			textWriter.WriteEndDocument();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003318 File Offset: 0x00002318
		public void FromXMLNode(XmlNodeList nodeList)
		{
			foreach (object obj in nodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					if (xmlNode.Name == "CounterItem")
					{
						CounterItem counterItem = new CounterItem();
						counterItem.FromXMLNode(xmlNode);
						base.InnerList.Add(counterItem);
					}
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000033BC File Offset: 0x000023BC
		public int GetIncludeElementsCounts()
		{
			int num = 0;
			foreach (object obj in base.InnerList)
			{
				CounterItem counterItem = (CounterItem)obj;
				num += counterItem.IncludeElementSet.Count;
			}
			return num;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003438 File Offset: 0x00002438
		public int GetDownLoadItemCounts()
		{
			int num = 0;
			foreach (object obj in base.InnerList)
			{
				CounterItem counterItem = (CounterItem)obj;
				num += counterItem.DownLoadItems.Count;
			}
			return num;
		}

		// Token: 0x04000042 RID: 66
		private ArrayList _categoryFilterList;
	}
}
