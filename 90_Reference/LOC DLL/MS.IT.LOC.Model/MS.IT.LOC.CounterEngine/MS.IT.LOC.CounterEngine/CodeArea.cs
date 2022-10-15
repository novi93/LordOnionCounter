using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x0200000C RID: 12
	public class CodeArea
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003862 File Offset: 0x00002862
		public CodeArea(XmlNode node)
		{
			this.LoadFromXmlNode(node);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000389C File Offset: 0x0000289C
		protected void LoadFromXmlNode(XmlNode node)
		{
			if (node.Name != "codeArea")
			{
				throw new ArgumentException("invalid xml schema", "node");
			}
			this.LoadCodeAreaAttributes(node);
			this.LoadCodeAreaExpressions(node);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000038E4 File Offset: 0x000028E4
		protected void LoadCodeAreaAttributes(XmlNode node)
		{
			XmlAttribute xmlAttribute = node.Attributes["name"];
			if (xmlAttribute != null)
			{
				this.name = xmlAttribute.Value;
				XmlAttribute xmlAttribute2 = node.Attributes["isCode"];
				if (xmlAttribute2 != null)
				{
					this.countsAsCode = Convert.ToBoolean(xmlAttribute2.Value);
				}
				else
				{
					this.countsAsCode = false;
				}
				XmlAttribute xmlAttribute3 = node.Attributes["multiLine"];
				if (xmlAttribute3 != null)
				{
					this.multiLine = Convert.ToBoolean(xmlAttribute3.Value);
				}
				else
				{
					this.multiLine = false;
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
				else
				{
					this.description = string.Empty;
				}
				return;
			}
			throw new ArgumentException("invalid xml schema. codeArea has no \"name\" attribute", "node");
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003A14 File Offset: 0x00002A14
		protected void LoadCodeAreaExpressions(XmlNode node)
		{
			if (node.Name != "codeArea")
			{
				throw new ArgumentException("invalid xml schema", "node");
			}
			RegexOptions regexOptions = RegexOptions.Compiled | RegexOptions.Singleline;
			if (!this.caseSensitive)
			{
				regexOptions |= RegexOptions.IgnoreCase;
			}
			if (this.multiLine)
			{
				XmlNode xmlNode = node.SelectSingleNode("startExpression");
				string innerText = xmlNode.InnerText;
				this.startExpression = new Regex(innerText, regexOptions);
				XmlNode xmlNode2 = node.SelectSingleNode("endExpression");
				innerText = xmlNode2.InnerText;
				this.endExpression = new Regex(innerText, regexOptions);
			}
			else
			{
				XmlNodeList xmlNodeList = node.SelectNodes("expression");
				this.expressions = new Regex[xmlNodeList.Count];
				int num = 0;
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode3 = (XmlNode)obj;
					string innerText = xmlNode3.InnerText;
					this.expressions[num++] = new Regex(innerText, regexOptions);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003B54 File Offset: 0x00002B54
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003B6C File Offset: 0x00002B6C
		public bool CaseSenstive
		{
			get
			{
				return this.caseSensitive;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003B84 File Offset: 0x00002B84
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003B9C File Offset: 0x00002B9C
		public bool CountsAsCode
		{
			get
			{
				return this.countsAsCode;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003BB4 File Offset: 0x00002BB4
		public bool MultiLine
		{
			get
			{
				return this.multiLine;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003BCC File Offset: 0x00002BCC
		public string StartExpression
		{
			get
			{
				return this.startExpression.ToString();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003BEC File Offset: 0x00002BEC
		public bool MatchesStart(string line)
		{
			return this.startExpression.IsMatch(line);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003C0C File Offset: 0x00002C0C
		public string EndExpression
		{
			get
			{
				return this.endExpression.ToString();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003C2C File Offset: 0x00002C2C
		public bool MatchesEnd(string line)
		{
			return this.endExpression.IsMatch(line);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003C4C File Offset: 0x00002C4C
		public string[] Expressions
		{
			get
			{
				string[] array = new string[this.expressions.Length];
				for (int i = 0; i < this.expressions.Length; i++)
				{
					array[i] = this.expressions[i].ToString();
				}
				return array;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003C98 File Offset: 0x00002C98
		public bool Matches(string line)
		{
			bool result = false;
			for (int i = 0; i < this.expressions.Length; i++)
			{
				if (this.expressions[i].IsMatch(line))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000036 RID: 54
		private string description = string.Empty;

		// Token: 0x04000037 RID: 55
		private bool caseSensitive = true;

		// Token: 0x04000038 RID: 56
		private string name;

		// Token: 0x04000039 RID: 57
		private bool countsAsCode = false;

		// Token: 0x0400003A RID: 58
		private bool multiLine;

		// Token: 0x0400003B RID: 59
		private Regex startExpression;

		// Token: 0x0400003C RID: 60
		private Regex endExpression;

		// Token: 0x0400003D RID: 61
		private Regex[] expressions = new Regex[0];
	}
}
