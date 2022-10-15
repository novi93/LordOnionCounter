using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MS.IT.LOC.UI
{
	// Token: 0x0200002B RID: 43
	[HelpKeyword("vs.data.DataSet")]
	[DesignerCategory("code")]
	[XmlRoot("CounterResult")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class CounterResult : DataSet
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00022038 File Offset: 0x00021038
		[DebuggerNonUserCode]
		public CounterResult()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00022094 File Offset: 0x00021094
		[DebuggerNonUserCode]
		protected CounterResult(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
			}
			else
			{
				string s = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
					if (dataSet.Tables["CounterResultData"] != null)
					{
						base.Tables.Add(new CounterResult.CounterResultDataDataTable(dataSet.Tables["CounterResultData"]));
					}
					if (dataSet.Tables["CountStandardData"] != null)
					{
						base.Tables.Add(new CounterResult.CountStandardDataDataTable(dataSet.Tables["CountStandardData"]));
					}
					if (dataSet.Tables["CounterResultFolderData"] != null)
					{
						base.Tables.Add(new CounterResult.CounterResultFolderDataDataTable(dataSet.Tables["CounterResultFolderData"]));
					}
					if (dataSet.Tables["CounterResultExcludeData"] != null)
					{
						base.Tables.Add(new CounterResult.CounterResultExcludeDataDataTable(dataSet.Tables["CounterResultExcludeData"]));
					}
					if (dataSet.Tables["CounterResultLanguageData"] != null)
					{
						base.Tables.Add(new CounterResult.CounterResultLanguageDataDataTable(dataSet.Tables["CounterResultLanguageData"]));
					}
					if (dataSet.Tables["CounterResultMReportData"] != null)
					{
						base.Tables.Add(new CounterResult.CounterResultMReportDataDataTable(dataSet.Tables["CounterResultMReportData"]));
					}
					if (dataSet.Tables["CountResultPspSummary"] != null)
					{
						base.Tables.Add(new CounterResult.CountResultPspSummaryDataTable(dataSet.Tables["CountResultPspSummary"]));
					}
					if (dataSet.Tables["CountResultPspDetails"] != null)
					{
						base.Tables.Add(new CounterResult.CountResultPspDetailsDataTable(dataSet.Tables["CountResultPspDetails"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += value2;
				this.Relations.CollectionChanged += value2;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000223CC File Offset: 0x000213CC
		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CounterResult.CounterResultDataDataTable CounterResultData
		{
			get
			{
				return this.tableCounterResultData;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000223E4 File Offset: 0x000213E4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public CounterResult.CountStandardDataDataTable CountStandardData
		{
			get
			{
				return this.tableCountStandardData;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000223FC File Offset: 0x000213FC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public CounterResult.CounterResultFolderDataDataTable CounterResultFolderData
		{
			get
			{
				return this.tableCounterResultFolderData;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00022414 File Offset: 0x00021414
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CounterResult.CounterResultExcludeDataDataTable CounterResultExcludeData
		{
			get
			{
				return this.tableCounterResultExcludeData;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0002242C File Offset: 0x0002142C
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public CounterResult.CounterResultLanguageDataDataTable CounterResultLanguageData
		{
			get
			{
				return this.tableCounterResultLanguageData;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00022444 File Offset: 0x00021444
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public CounterResult.CounterResultMReportDataDataTable CounterResultMReportData
		{
			get
			{
				return this.tableCounterResultMReportData;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0002245C File Offset: 0x0002145C
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public CounterResult.CountResultPspSummaryDataTable CountResultPspSummary
		{
			get
			{
				return this.tableCountResultPspSummary;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00022474 File Offset: 0x00021474
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public CounterResult.CountResultPspDetailsDataTable CountResultPspDetails
		{
			get
			{
				return this.tableCountResultPspDetails;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0002248C File Offset: 0x0002148C
		// (set) Token: 0x0600025E RID: 606 RVA: 0x000224A4 File Offset: 0x000214A4
		[DebuggerNonUserCode]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600025F RID: 607 RVA: 0x000224B0 File Offset: 0x000214B0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000224C8 File Offset: 0x000214C8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000224E0 File Offset: 0x000214E0
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000224F8 File Offset: 0x000214F8
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			CounterResult counterResult = (CounterResult)base.Clone();
			counterResult.InitVars();
			counterResult.SchemaSerializationMode = this.SchemaSerializationMode;
			return counterResult;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0002252C File Offset: 0x0002152C
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00022540 File Offset: 0x00021540
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00022554 File Offset: 0x00021554
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["CounterResultData"] != null)
				{
					base.Tables.Add(new CounterResult.CounterResultDataDataTable(dataSet.Tables["CounterResultData"]));
				}
				if (dataSet.Tables["CountStandardData"] != null)
				{
					base.Tables.Add(new CounterResult.CountStandardDataDataTable(dataSet.Tables["CountStandardData"]));
				}
				if (dataSet.Tables["CounterResultFolderData"] != null)
				{
					base.Tables.Add(new CounterResult.CounterResultFolderDataDataTable(dataSet.Tables["CounterResultFolderData"]));
				}
				if (dataSet.Tables["CounterResultExcludeData"] != null)
				{
					base.Tables.Add(new CounterResult.CounterResultExcludeDataDataTable(dataSet.Tables["CounterResultExcludeData"]));
				}
				if (dataSet.Tables["CounterResultLanguageData"] != null)
				{
					base.Tables.Add(new CounterResult.CounterResultLanguageDataDataTable(dataSet.Tables["CounterResultLanguageData"]));
				}
				if (dataSet.Tables["CounterResultMReportData"] != null)
				{
					base.Tables.Add(new CounterResult.CounterResultMReportDataDataTable(dataSet.Tables["CounterResultMReportData"]));
				}
				if (dataSet.Tables["CountResultPspSummary"] != null)
				{
					base.Tables.Add(new CounterResult.CountResultPspSummaryDataTable(dataSet.Tables["CountResultPspSummary"]));
				}
				if (dataSet.Tables["CountResultPspDetails"] != null)
				{
					base.Tables.Add(new CounterResult.CountResultPspDetailsDataTable(dataSet.Tables["CountResultPspDetails"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000227D0 File Offset: 0x000217D0
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002280B File Offset: 0x0002180B
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00022818 File Offset: 0x00021818
		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableCounterResultData = (CounterResult.CounterResultDataDataTable)base.Tables["CounterResultData"];
			if (initTable)
			{
				if (this.tableCounterResultData != null)
				{
					this.tableCounterResultData.InitVars();
				}
			}
			this.tableCountStandardData = (CounterResult.CountStandardDataDataTable)base.Tables["CountStandardData"];
			if (initTable)
			{
				if (this.tableCountStandardData != null)
				{
					this.tableCountStandardData.InitVars();
				}
			}
			this.tableCounterResultFolderData = (CounterResult.CounterResultFolderDataDataTable)base.Tables["CounterResultFolderData"];
			if (initTable)
			{
				if (this.tableCounterResultFolderData != null)
				{
					this.tableCounterResultFolderData.InitVars();
				}
			}
			this.tableCounterResultExcludeData = (CounterResult.CounterResultExcludeDataDataTable)base.Tables["CounterResultExcludeData"];
			if (initTable)
			{
				if (this.tableCounterResultExcludeData != null)
				{
					this.tableCounterResultExcludeData.InitVars();
				}
			}
			this.tableCounterResultLanguageData = (CounterResult.CounterResultLanguageDataDataTable)base.Tables["CounterResultLanguageData"];
			if (initTable)
			{
				if (this.tableCounterResultLanguageData != null)
				{
					this.tableCounterResultLanguageData.InitVars();
				}
			}
			this.tableCounterResultMReportData = (CounterResult.CounterResultMReportDataDataTable)base.Tables["CounterResultMReportData"];
			if (initTable)
			{
				if (this.tableCounterResultMReportData != null)
				{
					this.tableCounterResultMReportData.InitVars();
				}
			}
			this.tableCountResultPspSummary = (CounterResult.CountResultPspSummaryDataTable)base.Tables["CountResultPspSummary"];
			if (initTable)
			{
				if (this.tableCountResultPspSummary != null)
				{
					this.tableCountResultPspSummary.InitVars();
				}
			}
			this.tableCountResultPspDetails = (CounterResult.CountResultPspDetailsDataTable)base.Tables["CountResultPspDetails"];
			if (initTable)
			{
				if (this.tableCountResultPspDetails != null)
				{
					this.tableCountResultPspDetails.InitVars();
				}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00022A28 File Offset: 0x00021A28
		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "CounterResult";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/CounterResult.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableCounterResultData = new CounterResult.CounterResultDataDataTable();
			base.Tables.Add(this.tableCounterResultData);
			this.tableCountStandardData = new CounterResult.CountStandardDataDataTable();
			base.Tables.Add(this.tableCountStandardData);
			this.tableCounterResultFolderData = new CounterResult.CounterResultFolderDataDataTable();
			base.Tables.Add(this.tableCounterResultFolderData);
			this.tableCounterResultExcludeData = new CounterResult.CounterResultExcludeDataDataTable();
			base.Tables.Add(this.tableCounterResultExcludeData);
			this.tableCounterResultLanguageData = new CounterResult.CounterResultLanguageDataDataTable();
			base.Tables.Add(this.tableCounterResultLanguageData);
			this.tableCounterResultMReportData = new CounterResult.CounterResultMReportDataDataTable();
			base.Tables.Add(this.tableCounterResultMReportData);
			this.tableCountResultPspSummary = new CounterResult.CountResultPspSummaryDataTable();
			base.Tables.Add(this.tableCountResultPspSummary);
			this.tableCountResultPspDetails = new CounterResult.CountResultPspDetailsDataTable();
			base.Tables.Add(this.tableCountResultPspDetails);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00022B54 File Offset: 0x00021B54
		[DebuggerNonUserCode]
		private bool ShouldSerializeCounterResultData()
		{
			return false;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00022B68 File Offset: 0x00021B68
		[DebuggerNonUserCode]
		private bool ShouldSerializeCountStandardData()
		{
			return false;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00022B7C File Offset: 0x00021B7C
		[DebuggerNonUserCode]
		private bool ShouldSerializeCounterResultFolderData()
		{
			return false;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00022B90 File Offset: 0x00021B90
		[DebuggerNonUserCode]
		private bool ShouldSerializeCounterResultExcludeData()
		{
			return false;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00022BA4 File Offset: 0x00021BA4
		[DebuggerNonUserCode]
		private bool ShouldSerializeCounterResultLanguageData()
		{
			return false;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00022BB8 File Offset: 0x00021BB8
		[DebuggerNonUserCode]
		private bool ShouldSerializeCounterResultMReportData()
		{
			return false;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00022BCC File Offset: 0x00021BCC
		[DebuggerNonUserCode]
		private bool ShouldSerializeCountResultPspSummary()
		{
			return false;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00022BE0 File Offset: 0x00021BE0
		[DebuggerNonUserCode]
		private bool ShouldSerializeCountResultPspDetails()
		{
			return false;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00022BF4 File Offset: 0x00021BF4
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00022C1C File Offset: 0x00021C1C
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			CounterResult counterResult = new CounterResult();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			xs.Add(counterResult.GetSchemaSerializable());
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = counterResult.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			return xmlSchemaComplexType;
		}

		// Token: 0x040001F3 RID: 499
		private CounterResult.CounterResultDataDataTable tableCounterResultData;

		// Token: 0x040001F4 RID: 500
		private CounterResult.CountStandardDataDataTable tableCountStandardData;

		// Token: 0x040001F5 RID: 501
		private CounterResult.CounterResultFolderDataDataTable tableCounterResultFolderData;

		// Token: 0x040001F6 RID: 502
		private CounterResult.CounterResultExcludeDataDataTable tableCounterResultExcludeData;

		// Token: 0x040001F7 RID: 503
		private CounterResult.CounterResultLanguageDataDataTable tableCounterResultLanguageData;

		// Token: 0x040001F8 RID: 504
		private CounterResult.CounterResultMReportDataDataTable tableCounterResultMReportData;

		// Token: 0x040001F9 RID: 505
		private CounterResult.CountResultPspSummaryDataTable tableCountResultPspSummary;

		// Token: 0x040001FA RID: 506
		private CounterResult.CountResultPspDetailsDataTable tableCountResultPspDetails;

		// Token: 0x040001FB RID: 507
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x0200002C RID: 44
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CountResultPspSummaryDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000274 RID: 628 RVA: 0x00022C78 File Offset: 0x00021C78
			[DebuggerNonUserCode]
			public CountResultPspSummaryDataTable()
			{
				base.TableName = "CountResultPspSummary";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00022CA4 File Offset: 0x00021CA4
			[DebuggerNonUserCode]
			internal CountResultPspSummaryDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000276 RID: 630 RVA: 0x00022D69 File Offset: 0x00021D69
			[DebuggerNonUserCode]
			protected CountResultPspSummaryDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000277 RID: 631 RVA: 0x00022D80 File Offset: 0x00021D80
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000278 RID: 632 RVA: 0x00022D98 File Offset: 0x00021D98
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000279 RID: 633 RVA: 0x00022DB0 File Offset: 0x00021DB0
			[DebuggerNonUserCode]
			public DataColumn FilePathColumn
			{
				get
				{
					return this.columnFilePath;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600027A RID: 634 RVA: 0x00022DC8 File Offset: 0x00021DC8
			[DebuggerNonUserCode]
			public DataColumn TagTypeColumn
			{
				get
				{
					return this.columnTagType;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600027B RID: 635 RVA: 0x00022DE0 File Offset: 0x00021DE0
			[DebuggerNonUserCode]
			public DataColumn TagValueColumn
			{
				get
				{
					return this.columnTagValue;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x0600027C RID: 636 RVA: 0x00022DF8 File Offset: 0x00021DF8
			[DebuggerNonUserCode]
			public DataColumn ObjectTypeColumn
			{
				get
				{
					return this.columnObjectType;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x0600027D RID: 637 RVA: 0x00022E10 File Offset: 0x00021E10
			[DebuggerNonUserCode]
			public DataColumn ElementsColumn
			{
				get
				{
					return this.columnElements;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600027E RID: 638 RVA: 0x00022E28 File Offset: 0x00021E28
			[DebuggerNonUserCode]
			public DataColumn BaseColumn
			{
				get
				{
					return this.columnBase;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600027F RID: 639 RVA: 0x00022E40 File Offset: 0x00021E40
			[DebuggerNonUserCode]
			public DataColumn AddedColumn
			{
				get
				{
					return this.columnAdded;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000280 RID: 640 RVA: 0x00022E58 File Offset: 0x00021E58
			[DebuggerNonUserCode]
			public DataColumn ModifiedColumn
			{
				get
				{
					return this.columnModified;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000281 RID: 641 RVA: 0x00022E70 File Offset: 0x00021E70
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000282 RID: 642 RVA: 0x00022E88 File Offset: 0x00021E88
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000076 RID: 118
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspSummaryRow this[int index]
			{
				get
				{
					return (CounterResult.CountResultPspSummaryRow)base.Rows[index];
				}
			}

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x06000284 RID: 644 RVA: 0x00022ECB File Offset: 0x00021ECB
			// (remove) Token: 0x06000285 RID: 645 RVA: 0x00022EE4 File Offset: 0x00021EE4
			public event CounterResult.CountResultPspSummaryRowChangeEventHandler CountResultPspSummaryRowChanging;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x06000286 RID: 646 RVA: 0x00022EFD File Offset: 0x00021EFD
			// (remove) Token: 0x06000287 RID: 647 RVA: 0x00022F16 File Offset: 0x00021F16
			public event CounterResult.CountResultPspSummaryRowChangeEventHandler CountResultPspSummaryRowChanged;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x06000288 RID: 648 RVA: 0x00022F2F File Offset: 0x00021F2F
			// (remove) Token: 0x06000289 RID: 649 RVA: 0x00022F48 File Offset: 0x00021F48
			public event CounterResult.CountResultPspSummaryRowChangeEventHandler CountResultPspSummaryRowDeleting;

			// Token: 0x14000010 RID: 16
			// (add) Token: 0x0600028A RID: 650 RVA: 0x00022F61 File Offset: 0x00021F61
			// (remove) Token: 0x0600028B RID: 651 RVA: 0x00022F7A File Offset: 0x00021F7A
			public event CounterResult.CountResultPspSummaryRowChangeEventHandler CountResultPspSummaryRowDeleted;

			// Token: 0x0600028C RID: 652 RVA: 0x00022F93 File Offset: 0x00021F93
			[DebuggerNonUserCode]
			public void AddCountResultPspSummaryRow(CounterResult.CountResultPspSummaryRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x0600028D RID: 653 RVA: 0x00022FA4 File Offset: 0x00021FA4
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspSummaryRow AddCountResultPspSummaryRow(string CounterTaskID, string CounterTaskName, string FilePath, string TagType, string TagValue, string ObjectType, long Elements, long Base, long Added, long Modified, long Deleted)
			{
				CounterResult.CountResultPspSummaryRow countResultPspSummaryRow = (CounterResult.CountResultPspSummaryRow)base.NewRow();
				countResultPspSummaryRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					FilePath,
					TagType,
					TagValue,
					ObjectType,
					Elements,
					Base,
					Added,
					Modified,
					Deleted
				};
				base.Rows.Add(countResultPspSummaryRow);
				return countResultPspSummaryRow;
			}

			// Token: 0x0600028E RID: 654 RVA: 0x00023030 File Offset: 0x00022030
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600028F RID: 655 RVA: 0x00023050 File Offset: 0x00022050
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CountResultPspSummaryDataTable countResultPspSummaryDataTable = (CounterResult.CountResultPspSummaryDataTable)base.Clone();
				countResultPspSummaryDataTable.InitVars();
				return countResultPspSummaryDataTable;
			}

			// Token: 0x06000290 RID: 656 RVA: 0x00023078 File Offset: 0x00022078
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CountResultPspSummaryDataTable();
			}

			// Token: 0x06000291 RID: 657 RVA: 0x00023090 File Offset: 0x00022090
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnFilePath = base.Columns["FilePath"];
				this.columnTagType = base.Columns["TagType"];
				this.columnTagValue = base.Columns["TagValue"];
				this.columnObjectType = base.Columns["ObjectType"];
				this.columnElements = base.Columns["Elements"];
				this.columnBase = base.Columns["Base"];
				this.columnAdded = base.Columns["Added"];
				this.columnModified = base.Columns["Modified"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x06000292 RID: 658 RVA: 0x00023190 File Offset: 0x00022190
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnFilePath = new DataColumn("FilePath", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFilePath);
				this.columnTagType = new DataColumn("TagType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTagType);
				this.columnTagValue = new DataColumn("TagValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTagValue);
				this.columnObjectType = new DataColumn("ObjectType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObjectType);
				this.columnElements = new DataColumn("Elements", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnElements);
				this.columnBase = new DataColumn("Base", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnBase);
				this.columnAdded = new DataColumn("Added", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnAdded);
				this.columnModified = new DataColumn("Modified", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnModified);
				this.columnDeleted = new DataColumn("Deleted", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnTagType.Caption = "FilePath";
				this.columnObjectType.Caption = "FilePath";
				this.columnElements.Caption = "FilePath";
				this.columnBase.Caption = "FilePath";
				this.columnAdded.Caption = "FilePath";
				this.columnModified.Caption = "FilePath";
			}

			// Token: 0x06000293 RID: 659 RVA: 0x00023400 File Offset: 0x00022400
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspSummaryRow NewCountResultPspSummaryRow()
			{
				return (CounterResult.CountResultPspSummaryRow)base.NewRow();
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00023420 File Offset: 0x00022420
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CountResultPspSummaryRow(builder);
			}

			// Token: 0x06000295 RID: 661 RVA: 0x00023438 File Offset: 0x00022438
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CountResultPspSummaryRow);
			}

			// Token: 0x06000296 RID: 662 RVA: 0x00023454 File Offset: 0x00022454
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CountResultPspSummaryRowChanged != null)
				{
					this.CountResultPspSummaryRowChanged(this, new CounterResult.CountResultPspSummaryRowChangeEvent((CounterResult.CountResultPspSummaryRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000297 RID: 663 RVA: 0x0002349C File Offset: 0x0002249C
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CountResultPspSummaryRowChanging != null)
				{
					this.CountResultPspSummaryRowChanging(this, new CounterResult.CountResultPspSummaryRowChangeEvent((CounterResult.CountResultPspSummaryRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000298 RID: 664 RVA: 0x000234E4 File Offset: 0x000224E4
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CountResultPspSummaryRowDeleted != null)
				{
					this.CountResultPspSummaryRowDeleted(this, new CounterResult.CountResultPspSummaryRowChangeEvent((CounterResult.CountResultPspSummaryRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000299 RID: 665 RVA: 0x0002352C File Offset: 0x0002252C
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CountResultPspSummaryRowDeleting != null)
				{
					this.CountResultPspSummaryRowDeleting(this, new CounterResult.CountResultPspSummaryRowChangeEvent((CounterResult.CountResultPspSummaryRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600029A RID: 666 RVA: 0x00023574 File Offset: 0x00022574
			[DebuggerNonUserCode]
			public void RemoveCountResultPspSummaryRow(CounterResult.CountResultPspSummaryRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x0600029B RID: 667 RVA: 0x00023584 File Offset: 0x00022584
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CountResultPspSummaryDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x040001FC RID: 508
			private DataColumn columnCounterTaskID;

			// Token: 0x040001FD RID: 509
			private DataColumn columnCounterTaskName;

			// Token: 0x040001FE RID: 510
			private DataColumn columnFilePath;

			// Token: 0x040001FF RID: 511
			private DataColumn columnTagType;

			// Token: 0x04000200 RID: 512
			private DataColumn columnTagValue;

			// Token: 0x04000201 RID: 513
			private DataColumn columnObjectType;

			// Token: 0x04000202 RID: 514
			private DataColumn columnElements;

			// Token: 0x04000203 RID: 515
			private DataColumn columnBase;

			// Token: 0x04000204 RID: 516
			private DataColumn columnAdded;

			// Token: 0x04000205 RID: 517
			private DataColumn columnModified;

			// Token: 0x04000206 RID: 518
			private DataColumn columnDeleted;
		}

		// Token: 0x0200002D RID: 45
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CounterResultMReportDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x0600029C RID: 668 RVA: 0x0002369D File Offset: 0x0002269D
			[DebuggerNonUserCode]
			public CounterResultMReportDataDataTable()
			{
				base.TableName = "CounterResultMReportData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600029D RID: 669 RVA: 0x000236CC File Offset: 0x000226CC
			[DebuggerNonUserCode]
			internal CounterResultMReportDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00023791 File Offset: 0x00022791
			[DebuggerNonUserCode]
			protected CounterResultMReportDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x0600029F RID: 671 RVA: 0x000237A8 File Offset: 0x000227A8
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x000237C0 File Offset: 0x000227C0
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x000237D8 File Offset: 0x000227D8
			[DebuggerNonUserCode]
			public DataColumn MetricColumn
			{
				get
				{
					return this.columnMetric;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060002A2 RID: 674 RVA: 0x000237F0 File Offset: 0x000227F0
			[DebuggerNonUserCode]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060002A3 RID: 675 RVA: 0x00023808 File Offset: 0x00022808
			[DebuggerNonUserCode]
			public DataColumn DataColumn
			{
				get
				{
					return this.columnData;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060002A4 RID: 676 RVA: 0x00023820 File Offset: 0x00022820
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700007D RID: 125
			[DebuggerNonUserCode]
			public CounterResult.CounterResultMReportDataRow this[int index]
			{
				get
				{
					return (CounterResult.CounterResultMReportDataRow)base.Rows[index];
				}
			}

			// Token: 0x14000011 RID: 17
			// (add) Token: 0x060002A6 RID: 678 RVA: 0x00023863 File Offset: 0x00022863
			// (remove) Token: 0x060002A7 RID: 679 RVA: 0x0002387C File Offset: 0x0002287C
			public event CounterResult.CounterResultMReportDataRowChangeEventHandler CounterResultMReportDataRowChanging;

			// Token: 0x14000012 RID: 18
			// (add) Token: 0x060002A8 RID: 680 RVA: 0x00023895 File Offset: 0x00022895
			// (remove) Token: 0x060002A9 RID: 681 RVA: 0x000238AE File Offset: 0x000228AE
			public event CounterResult.CounterResultMReportDataRowChangeEventHandler CounterResultMReportDataRowChanged;

			// Token: 0x14000013 RID: 19
			// (add) Token: 0x060002AA RID: 682 RVA: 0x000238C7 File Offset: 0x000228C7
			// (remove) Token: 0x060002AB RID: 683 RVA: 0x000238E0 File Offset: 0x000228E0
			public event CounterResult.CounterResultMReportDataRowChangeEventHandler CounterResultMReportDataRowDeleting;

			// Token: 0x14000014 RID: 20
			// (add) Token: 0x060002AC RID: 684 RVA: 0x000238F9 File Offset: 0x000228F9
			// (remove) Token: 0x060002AD RID: 685 RVA: 0x00023912 File Offset: 0x00022912
			public event CounterResult.CounterResultMReportDataRowChangeEventHandler CounterResultMReportDataRowDeleted;

			// Token: 0x060002AE RID: 686 RVA: 0x0002392B File Offset: 0x0002292B
			[DebuggerNonUserCode]
			public void AddCounterResultMReportDataRow(CounterResult.CounterResultMReportDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060002AF RID: 687 RVA: 0x0002393C File Offset: 0x0002293C
			[DebuggerNonUserCode]
			public CounterResult.CounterResultMReportDataRow AddCounterResultMReportDataRow(string CounterTaskID, string CounterTaskName, string Metric, string Description, string Data)
			{
				CounterResult.CounterResultMReportDataRow counterResultMReportDataRow = (CounterResult.CounterResultMReportDataRow)base.NewRow();
				counterResultMReportDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					Metric,
					Description,
					Data
				};
				base.Rows.Add(counterResultMReportDataRow);
				return counterResultMReportDataRow;
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x00023990 File Offset: 0x00022990
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x000239B0 File Offset: 0x000229B0
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CounterResultMReportDataDataTable counterResultMReportDataDataTable = (CounterResult.CounterResultMReportDataDataTable)base.Clone();
				counterResultMReportDataDataTable.InitVars();
				return counterResultMReportDataDataTable;
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x000239D8 File Offset: 0x000229D8
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CounterResultMReportDataDataTable();
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x000239F0 File Offset: 0x000229F0
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnMetric = base.Columns["Metric"];
				this.columnDescription = base.Columns["Description"];
				this.columnData = base.Columns["Data"];
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x00023A6C File Offset: 0x00022A6C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnMetric = new DataColumn("Metric", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMetric);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnData = new DataColumn("Data", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnData);
				this.columnMetric.Caption = "InfoName";
				this.columnDescription.Caption = "InfoValue";
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x00023B84 File Offset: 0x00022B84
			[DebuggerNonUserCode]
			public CounterResult.CounterResultMReportDataRow NewCounterResultMReportDataRow()
			{
				return (CounterResult.CounterResultMReportDataRow)base.NewRow();
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00023BA4 File Offset: 0x00022BA4
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CounterResultMReportDataRow(builder);
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00023BBC File Offset: 0x00022BBC
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CounterResultMReportDataRow);
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00023BD8 File Offset: 0x00022BD8
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CounterResultMReportDataRowChanged != null)
				{
					this.CounterResultMReportDataRowChanged(this, new CounterResult.CounterResultMReportDataRowChangeEvent((CounterResult.CounterResultMReportDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x00023C20 File Offset: 0x00022C20
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CounterResultMReportDataRowChanging != null)
				{
					this.CounterResultMReportDataRowChanging(this, new CounterResult.CounterResultMReportDataRowChangeEvent((CounterResult.CounterResultMReportDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00023C68 File Offset: 0x00022C68
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CounterResultMReportDataRowDeleted != null)
				{
					this.CounterResultMReportDataRowDeleted(this, new CounterResult.CounterResultMReportDataRowChangeEvent((CounterResult.CounterResultMReportDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00023CB0 File Offset: 0x00022CB0
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CounterResultMReportDataRowDeleting != null)
				{
					this.CounterResultMReportDataRowDeleting(this, new CounterResult.CounterResultMReportDataRowChangeEvent((CounterResult.CounterResultMReportDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00023CF8 File Offset: 0x00022CF8
			[DebuggerNonUserCode]
			public void RemoveCounterResultMReportDataRow(CounterResult.CounterResultMReportDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00023D08 File Offset: 0x00022D08
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CounterResultMReportDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x0400020B RID: 523
			private DataColumn columnCounterTaskID;

			// Token: 0x0400020C RID: 524
			private DataColumn columnCounterTaskName;

			// Token: 0x0400020D RID: 525
			private DataColumn columnMetric;

			// Token: 0x0400020E RID: 526
			private DataColumn columnDescription;

			// Token: 0x0400020F RID: 527
			private DataColumn columnData;
		}

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060002BF RID: 703
		public delegate void CounterResultDataRowChangeEventHandler(object sender, CounterResult.CounterResultDataRowChangeEvent e);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060002C3 RID: 707
		public delegate void CountStandardDataRowChangeEventHandler(object sender, CounterResult.CountStandardDataRowChangeEvent e);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060002C7 RID: 711
		public delegate void CounterResultFolderDataRowChangeEventHandler(object sender, CounterResult.CounterResultFolderDataRowChangeEvent e);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060002CB RID: 715
		public delegate void CounterResultExcludeDataRowChangeEventHandler(object sender, CounterResult.CounterResultExcludeDataRowChangeEvent e);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060002CF RID: 719
		public delegate void CounterResultLanguageDataRowChangeEventHandler(object sender, CounterResult.CounterResultLanguageDataRowChangeEvent e);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060002D3 RID: 723
		public delegate void CounterResultMReportDataRowChangeEventHandler(object sender, CounterResult.CounterResultMReportDataRowChangeEvent e);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060002D7 RID: 727
		public delegate void CountResultPspSummaryRowChangeEventHandler(object sender, CounterResult.CountResultPspSummaryRowChangeEvent e);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060002DB RID: 731
		public delegate void CountResultPspDetailsRowChangeEventHandler(object sender, CounterResult.CountResultPspDetailsRowChangeEvent e);

		// Token: 0x02000036 RID: 54
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CounterResultDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x060002DE RID: 734 RVA: 0x00023E21 File Offset: 0x00022E21
			[DebuggerNonUserCode]
			public CounterResultDataDataTable()
			{
				base.TableName = "CounterResultData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00023E50 File Offset: 0x00022E50
			[DebuggerNonUserCode]
			internal CounterResultDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x00023F15 File Offset: 0x00022F15
			[DebuggerNonUserCode]
			protected CounterResultDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x00023F2C File Offset: 0x00022F2C
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x00023F44 File Offset: 0x00022F44
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x00023F5C File Offset: 0x00022F5C
			[DebuggerNonUserCode]
			public DataColumn FilePathColumn
			{
				get
				{
					return this.columnFilePath;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x00023F74 File Offset: 0x00022F74
			[DebuggerNonUserCode]
			public DataColumn BaseColumn
			{
				get
				{
					return this.columnBase;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x00023F8C File Offset: 0x00022F8C
			[DebuggerNonUserCode]
			public DataColumn AddedColumn
			{
				get
				{
					return this.columnAdded;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x00023FA4 File Offset: 0x00022FA4
			[DebuggerNonUserCode]
			public DataColumn ModifiedColumn
			{
				get
				{
					return this.columnModified;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060002E7 RID: 743 RVA: 0x00023FBC File Offset: 0x00022FBC
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060002E8 RID: 744 RVA: 0x00023FD4 File Offset: 0x00022FD4
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000086 RID: 134
			[DebuggerNonUserCode]
			public CounterResult.CounterResultDataRow this[int index]
			{
				get
				{
					return (CounterResult.CounterResultDataRow)base.Rows[index];
				}
			}

			// Token: 0x14000015 RID: 21
			// (add) Token: 0x060002EA RID: 746 RVA: 0x00024017 File Offset: 0x00023017
			// (remove) Token: 0x060002EB RID: 747 RVA: 0x00024030 File Offset: 0x00023030
			public event CounterResult.CounterResultDataRowChangeEventHandler CounterResultDataRowChanging;

			// Token: 0x14000016 RID: 22
			// (add) Token: 0x060002EC RID: 748 RVA: 0x00024049 File Offset: 0x00023049
			// (remove) Token: 0x060002ED RID: 749 RVA: 0x00024062 File Offset: 0x00023062
			public event CounterResult.CounterResultDataRowChangeEventHandler CounterResultDataRowChanged;

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x060002EE RID: 750 RVA: 0x0002407B File Offset: 0x0002307B
			// (remove) Token: 0x060002EF RID: 751 RVA: 0x00024094 File Offset: 0x00023094
			public event CounterResult.CounterResultDataRowChangeEventHandler CounterResultDataRowDeleting;

			// Token: 0x14000018 RID: 24
			// (add) Token: 0x060002F0 RID: 752 RVA: 0x000240AD File Offset: 0x000230AD
			// (remove) Token: 0x060002F1 RID: 753 RVA: 0x000240C6 File Offset: 0x000230C6
			public event CounterResult.CounterResultDataRowChangeEventHandler CounterResultDataRowDeleted;

			// Token: 0x060002F2 RID: 754 RVA: 0x000240DF File Offset: 0x000230DF
			[DebuggerNonUserCode]
			public void AddCounterResultDataRow(CounterResult.CounterResultDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x000240F0 File Offset: 0x000230F0
			[DebuggerNonUserCode]
			public CounterResult.CounterResultDataRow AddCounterResultDataRow(string CounterTaskID, string CounterTaskName, string FilePath, long Base, long Added, long Modified, long Deleted)
			{
				CounterResult.CounterResultDataRow counterResultDataRow = (CounterResult.CounterResultDataRow)base.NewRow();
				counterResultDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					FilePath,
					Base,
					Added,
					Modified,
					Deleted
				};
				base.Rows.Add(counterResultDataRow);
				return counterResultDataRow;
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x00024160 File Offset: 0x00023160
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x00024180 File Offset: 0x00023180
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CounterResultDataDataTable counterResultDataDataTable = (CounterResult.CounterResultDataDataTable)base.Clone();
				counterResultDataDataTable.InitVars();
				return counterResultDataDataTable;
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x000241A8 File Offset: 0x000231A8
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CounterResultDataDataTable();
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x000241C0 File Offset: 0x000231C0
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnFilePath = base.Columns["FilePath"];
				this.columnBase = base.Columns["Base"];
				this.columnAdded = base.Columns["Added"];
				this.columnModified = base.Columns["Modified"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00024268 File Offset: 0x00023268
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnFilePath = new DataColumn("FilePath", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFilePath);
				this.columnBase = new DataColumn("Base", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnBase);
				this.columnAdded = new DataColumn("Added", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnAdded);
				this.columnModified = new DataColumn("Modified", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnModified);
				this.columnDeleted = new DataColumn("Deleted", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000243B8 File Offset: 0x000233B8
			[DebuggerNonUserCode]
			public CounterResult.CounterResultDataRow NewCounterResultDataRow()
			{
				return (CounterResult.CounterResultDataRow)base.NewRow();
			}

			// Token: 0x060002FA RID: 762 RVA: 0x000243D8 File Offset: 0x000233D8
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CounterResultDataRow(builder);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x000243F0 File Offset: 0x000233F0
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CounterResultDataRow);
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0002440C File Offset: 0x0002340C
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CounterResultDataRowChanged != null)
				{
					this.CounterResultDataRowChanged(this, new CounterResult.CounterResultDataRowChangeEvent((CounterResult.CounterResultDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00024454 File Offset: 0x00023454
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CounterResultDataRowChanging != null)
				{
					this.CounterResultDataRowChanging(this, new CounterResult.CounterResultDataRowChangeEvent((CounterResult.CounterResultDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0002449C File Offset: 0x0002349C
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CounterResultDataRowDeleted != null)
				{
					this.CounterResultDataRowDeleted(this, new CounterResult.CounterResultDataRowChangeEvent((CounterResult.CounterResultDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x060002FF RID: 767 RVA: 0x000244E4 File Offset: 0x000234E4
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CounterResultDataRowDeleting != null)
				{
					this.CounterResultDataRowDeleting(this, new CounterResult.CounterResultDataRowChangeEvent((CounterResult.CounterResultDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0002452C File Offset: 0x0002352C
			[DebuggerNonUserCode]
			public void RemoveCounterResultDataRow(CounterResult.CounterResultDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0002453C File Offset: 0x0002353C
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CounterResultDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000214 RID: 532
			private DataColumn columnCounterTaskID;

			// Token: 0x04000215 RID: 533
			private DataColumn columnCounterTaskName;

			// Token: 0x04000216 RID: 534
			private DataColumn columnFilePath;

			// Token: 0x04000217 RID: 535
			private DataColumn columnBase;

			// Token: 0x04000218 RID: 536
			private DataColumn columnAdded;

			// Token: 0x04000219 RID: 537
			private DataColumn columnModified;

			// Token: 0x0400021A RID: 538
			private DataColumn columnDeleted;
		}

		// Token: 0x02000037 RID: 55
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CountStandardDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000302 RID: 770 RVA: 0x00024655 File Offset: 0x00023655
			[DebuggerNonUserCode]
			public CountStandardDataDataTable()
			{
				base.TableName = "CountStandardData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00024684 File Offset: 0x00023684
			[DebuggerNonUserCode]
			internal CountStandardDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00024749 File Offset: 0x00023749
			[DebuggerNonUserCode]
			protected CountStandardDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00024760 File Offset: 0x00023760
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000306 RID: 774 RVA: 0x00024778 File Offset: 0x00023778
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00024790 File Offset: 0x00023790
			[DebuggerNonUserCode]
			public DataColumn InfoNameColumn
			{
				get
				{
					return this.columnInfoName;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000308 RID: 776 RVA: 0x000247A8 File Offset: 0x000237A8
			[DebuggerNonUserCode]
			public DataColumn InfoValueColumn
			{
				get
				{
					return this.columnInfoValue;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000309 RID: 777 RVA: 0x000247C0 File Offset: 0x000237C0
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700008C RID: 140
			[DebuggerNonUserCode]
			public CounterResult.CountStandardDataRow this[int index]
			{
				get
				{
					return (CounterResult.CountStandardDataRow)base.Rows[index];
				}
			}

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x0600030B RID: 779 RVA: 0x00024803 File Offset: 0x00023803
			// (remove) Token: 0x0600030C RID: 780 RVA: 0x0002481C File Offset: 0x0002381C
			public event CounterResult.CountStandardDataRowChangeEventHandler CountStandardDataRowChanging;

			// Token: 0x1400001A RID: 26
			// (add) Token: 0x0600030D RID: 781 RVA: 0x00024835 File Offset: 0x00023835
			// (remove) Token: 0x0600030E RID: 782 RVA: 0x0002484E File Offset: 0x0002384E
			public event CounterResult.CountStandardDataRowChangeEventHandler CountStandardDataRowChanged;

			// Token: 0x1400001B RID: 27
			// (add) Token: 0x0600030F RID: 783 RVA: 0x00024867 File Offset: 0x00023867
			// (remove) Token: 0x06000310 RID: 784 RVA: 0x00024880 File Offset: 0x00023880
			public event CounterResult.CountStandardDataRowChangeEventHandler CountStandardDataRowDeleting;

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x06000311 RID: 785 RVA: 0x00024899 File Offset: 0x00023899
			// (remove) Token: 0x06000312 RID: 786 RVA: 0x000248B2 File Offset: 0x000238B2
			public event CounterResult.CountStandardDataRowChangeEventHandler CountStandardDataRowDeleted;

			// Token: 0x06000313 RID: 787 RVA: 0x000248CB File Offset: 0x000238CB
			[DebuggerNonUserCode]
			public void AddCountStandardDataRow(CounterResult.CountStandardDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000314 RID: 788 RVA: 0x000248DC File Offset: 0x000238DC
			[DebuggerNonUserCode]
			public CounterResult.CountStandardDataRow AddCountStandardDataRow(string CounterTaskID, string CounterTaskName, string InfoName, string InfoValue)
			{
				CounterResult.CountStandardDataRow countStandardDataRow = (CounterResult.CountStandardDataRow)base.NewRow();
				countStandardDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					InfoName,
					InfoValue
				};
				base.Rows.Add(countStandardDataRow);
				return countStandardDataRow;
			}

			// Token: 0x06000315 RID: 789 RVA: 0x00024928 File Offset: 0x00023928
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00024948 File Offset: 0x00023948
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CountStandardDataDataTable countStandardDataDataTable = (CounterResult.CountStandardDataDataTable)base.Clone();
				countStandardDataDataTable.InitVars();
				return countStandardDataDataTable;
			}

			// Token: 0x06000317 RID: 791 RVA: 0x00024970 File Offset: 0x00023970
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CountStandardDataDataTable();
			}

			// Token: 0x06000318 RID: 792 RVA: 0x00024988 File Offset: 0x00023988
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnInfoName = base.Columns["InfoName"];
				this.columnInfoValue = base.Columns["InfoValue"];
			}

			// Token: 0x06000319 RID: 793 RVA: 0x000249F0 File Offset: 0x000239F0
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnInfoName = new DataColumn("InfoName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInfoName);
				this.columnInfoValue = new DataColumn("InfoValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnInfoValue);
			}

			// Token: 0x0600031A RID: 794 RVA: 0x00024AB8 File Offset: 0x00023AB8
			[DebuggerNonUserCode]
			public CounterResult.CountStandardDataRow NewCountStandardDataRow()
			{
				return (CounterResult.CountStandardDataRow)base.NewRow();
			}

			// Token: 0x0600031B RID: 795 RVA: 0x00024AD8 File Offset: 0x00023AD8
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CountStandardDataRow(builder);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00024AF0 File Offset: 0x00023AF0
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CountStandardDataRow);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x00024B0C File Offset: 0x00023B0C
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CountStandardDataRowChanged != null)
				{
					this.CountStandardDataRowChanged(this, new CounterResult.CountStandardDataRowChangeEvent((CounterResult.CountStandardDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600031E RID: 798 RVA: 0x00024B54 File Offset: 0x00023B54
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CountStandardDataRowChanging != null)
				{
					this.CountStandardDataRowChanging(this, new CounterResult.CountStandardDataRowChangeEvent((CounterResult.CountStandardDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600031F RID: 799 RVA: 0x00024B9C File Offset: 0x00023B9C
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CountStandardDataRowDeleted != null)
				{
					this.CountStandardDataRowDeleted(this, new CounterResult.CountStandardDataRowChangeEvent((CounterResult.CountStandardDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000320 RID: 800 RVA: 0x00024BE4 File Offset: 0x00023BE4
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CountStandardDataRowDeleting != null)
				{
					this.CountStandardDataRowDeleting(this, new CounterResult.CountStandardDataRowChangeEvent((CounterResult.CountStandardDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000321 RID: 801 RVA: 0x00024C2C File Offset: 0x00023C2C
			[DebuggerNonUserCode]
			public void RemoveCountStandardDataRow(CounterResult.CountStandardDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000322 RID: 802 RVA: 0x00024C3C File Offset: 0x00023C3C
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CountStandardDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x0400021F RID: 543
			private DataColumn columnCounterTaskID;

			// Token: 0x04000220 RID: 544
			private DataColumn columnCounterTaskName;

			// Token: 0x04000221 RID: 545
			private DataColumn columnInfoName;

			// Token: 0x04000222 RID: 546
			private DataColumn columnInfoValue;
		}

		// Token: 0x02000038 RID: 56
		[XmlSchemaProvider("GetTypedTableSchema")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class CounterResultFolderDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000323 RID: 803 RVA: 0x00024D55 File Offset: 0x00023D55
			[DebuggerNonUserCode]
			public CounterResultFolderDataDataTable()
			{
				base.TableName = "CounterResultFolderData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00024D84 File Offset: 0x00023D84
			[DebuggerNonUserCode]
			internal CounterResultFolderDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000325 RID: 805 RVA: 0x00024E49 File Offset: 0x00023E49
			[DebuggerNonUserCode]
			protected CounterResultFolderDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000326 RID: 806 RVA: 0x00024E60 File Offset: 0x00023E60
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000327 RID: 807 RVA: 0x00024E78 File Offset: 0x00023E78
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000328 RID: 808 RVA: 0x00024E90 File Offset: 0x00023E90
			[DebuggerNonUserCode]
			public DataColumn FolderColumn
			{
				get
				{
					return this.columnFolder;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000329 RID: 809 RVA: 0x00024EA8 File Offset: 0x00023EA8
			[DebuggerNonUserCode]
			public DataColumn BaseColumn
			{
				get
				{
					return this.columnBase;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600032A RID: 810 RVA: 0x00024EC0 File Offset: 0x00023EC0
			[DebuggerNonUserCode]
			public DataColumn AddedColumn
			{
				get
				{
					return this.columnAdded;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600032B RID: 811 RVA: 0x00024ED8 File Offset: 0x00023ED8
			[DebuggerNonUserCode]
			public DataColumn ModifiedColumn
			{
				get
				{
					return this.columnModified;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600032C RID: 812 RVA: 0x00024EF0 File Offset: 0x00023EF0
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00024F08 File Offset: 0x00023F08
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000095 RID: 149
			[DebuggerNonUserCode]
			public CounterResult.CounterResultFolderDataRow this[int index]
			{
				get
				{
					return (CounterResult.CounterResultFolderDataRow)base.Rows[index];
				}
			}

			// Token: 0x1400001D RID: 29
			// (add) Token: 0x0600032F RID: 815 RVA: 0x00024F4B File Offset: 0x00023F4B
			// (remove) Token: 0x06000330 RID: 816 RVA: 0x00024F64 File Offset: 0x00023F64
			public event CounterResult.CounterResultFolderDataRowChangeEventHandler CounterResultFolderDataRowChanging;

			// Token: 0x1400001E RID: 30
			// (add) Token: 0x06000331 RID: 817 RVA: 0x00024F7D File Offset: 0x00023F7D
			// (remove) Token: 0x06000332 RID: 818 RVA: 0x00024F96 File Offset: 0x00023F96
			public event CounterResult.CounterResultFolderDataRowChangeEventHandler CounterResultFolderDataRowChanged;

			// Token: 0x1400001F RID: 31
			// (add) Token: 0x06000333 RID: 819 RVA: 0x00024FAF File Offset: 0x00023FAF
			// (remove) Token: 0x06000334 RID: 820 RVA: 0x00024FC8 File Offset: 0x00023FC8
			public event CounterResult.CounterResultFolderDataRowChangeEventHandler CounterResultFolderDataRowDeleting;

			// Token: 0x14000020 RID: 32
			// (add) Token: 0x06000335 RID: 821 RVA: 0x00024FE1 File Offset: 0x00023FE1
			// (remove) Token: 0x06000336 RID: 822 RVA: 0x00024FFA File Offset: 0x00023FFA
			public event CounterResult.CounterResultFolderDataRowChangeEventHandler CounterResultFolderDataRowDeleted;

			// Token: 0x06000337 RID: 823 RVA: 0x00025013 File Offset: 0x00024013
			[DebuggerNonUserCode]
			public void AddCounterResultFolderDataRow(CounterResult.CounterResultFolderDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00025024 File Offset: 0x00024024
			[DebuggerNonUserCode]
			public CounterResult.CounterResultFolderDataRow AddCounterResultFolderDataRow(string CounterTaskID, string CounterTaskName, string Folder, long Base, long Added, long Modified, long Deleted)
			{
				CounterResult.CounterResultFolderDataRow counterResultFolderDataRow = (CounterResult.CounterResultFolderDataRow)base.NewRow();
				counterResultFolderDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					Folder,
					Base,
					Added,
					Modified,
					Deleted
				};
				base.Rows.Add(counterResultFolderDataRow);
				return counterResultFolderDataRow;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00025094 File Offset: 0x00024094
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600033A RID: 826 RVA: 0x000250B4 File Offset: 0x000240B4
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CounterResultFolderDataDataTable counterResultFolderDataDataTable = (CounterResult.CounterResultFolderDataDataTable)base.Clone();
				counterResultFolderDataDataTable.InitVars();
				return counterResultFolderDataDataTable;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x000250DC File Offset: 0x000240DC
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CounterResultFolderDataDataTable();
			}

			// Token: 0x0600033C RID: 828 RVA: 0x000250F4 File Offset: 0x000240F4
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnFolder = base.Columns["Folder"];
				this.columnBase = base.Columns["Base"];
				this.columnAdded = base.Columns["Added"];
				this.columnModified = base.Columns["Modified"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0002519C File Offset: 0x0002419C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnFolder = new DataColumn("Folder", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFolder);
				this.columnBase = new DataColumn("Base", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnBase);
				this.columnAdded = new DataColumn("Added", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnAdded);
				this.columnModified = new DataColumn("Modified", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnModified);
				this.columnDeleted = new DataColumn("Deleted", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnFolder.Caption = "FilePath";
			}

			// Token: 0x0600033E RID: 830 RVA: 0x00025300 File Offset: 0x00024300
			[DebuggerNonUserCode]
			public CounterResult.CounterResultFolderDataRow NewCounterResultFolderDataRow()
			{
				return (CounterResult.CounterResultFolderDataRow)base.NewRow();
			}

			// Token: 0x0600033F RID: 831 RVA: 0x00025320 File Offset: 0x00024320
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CounterResultFolderDataRow(builder);
			}

			// Token: 0x06000340 RID: 832 RVA: 0x00025338 File Offset: 0x00024338
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CounterResultFolderDataRow);
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00025354 File Offset: 0x00024354
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CounterResultFolderDataRowChanged != null)
				{
					this.CounterResultFolderDataRowChanged(this, new CounterResult.CounterResultFolderDataRowChangeEvent((CounterResult.CounterResultFolderDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0002539C File Offset: 0x0002439C
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CounterResultFolderDataRowChanging != null)
				{
					this.CounterResultFolderDataRowChanging(this, new CounterResult.CounterResultFolderDataRowChangeEvent((CounterResult.CounterResultFolderDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000343 RID: 835 RVA: 0x000253E4 File Offset: 0x000243E4
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CounterResultFolderDataRowDeleted != null)
				{
					this.CounterResultFolderDataRowDeleted(this, new CounterResult.CounterResultFolderDataRowChangeEvent((CounterResult.CounterResultFolderDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0002542C File Offset: 0x0002442C
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CounterResultFolderDataRowDeleting != null)
				{
					this.CounterResultFolderDataRowDeleting(this, new CounterResult.CounterResultFolderDataRowChangeEvent((CounterResult.CounterResultFolderDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000345 RID: 837 RVA: 0x00025474 File Offset: 0x00024474
			[DebuggerNonUserCode]
			public void RemoveCounterResultFolderDataRow(CounterResult.CounterResultFolderDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00025484 File Offset: 0x00024484
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CounterResultFolderDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000227 RID: 551
			private DataColumn columnCounterTaskID;

			// Token: 0x04000228 RID: 552
			private DataColumn columnCounterTaskName;

			// Token: 0x04000229 RID: 553
			private DataColumn columnFolder;

			// Token: 0x0400022A RID: 554
			private DataColumn columnBase;

			// Token: 0x0400022B RID: 555
			private DataColumn columnAdded;

			// Token: 0x0400022C RID: 556
			private DataColumn columnModified;

			// Token: 0x0400022D RID: 557
			private DataColumn columnDeleted;
		}

		// Token: 0x02000039 RID: 57
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CounterResultExcludeDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000347 RID: 839 RVA: 0x0002559D File Offset: 0x0002459D
			[DebuggerNonUserCode]
			public CounterResultExcludeDataDataTable()
			{
				base.TableName = "CounterResultExcludeData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000348 RID: 840 RVA: 0x000255CC File Offset: 0x000245CC
			[DebuggerNonUserCode]
			internal CounterResultExcludeDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00025691 File Offset: 0x00024691
			[DebuggerNonUserCode]
			protected CounterResultExcludeDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600034A RID: 842 RVA: 0x000256A8 File Offset: 0x000246A8
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600034B RID: 843 RVA: 0x000256C0 File Offset: 0x000246C0
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600034C RID: 844 RVA: 0x000256D8 File Offset: 0x000246D8
			[DebuggerNonUserCode]
			public DataColumn ExcludeNameColumn
			{
				get
				{
					return this.columnExcludeName;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600034D RID: 845 RVA: 0x000256F0 File Offset: 0x000246F0
			[DebuggerNonUserCode]
			public DataColumn CountsColumn
			{
				get
				{
					return this.columnCounts;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600034E RID: 846 RVA: 0x00025708 File Offset: 0x00024708
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700009B RID: 155
			[DebuggerNonUserCode]
			public CounterResult.CounterResultExcludeDataRow this[int index]
			{
				get
				{
					return (CounterResult.CounterResultExcludeDataRow)base.Rows[index];
				}
			}

			// Token: 0x14000021 RID: 33
			// (add) Token: 0x06000350 RID: 848 RVA: 0x0002574B File Offset: 0x0002474B
			// (remove) Token: 0x06000351 RID: 849 RVA: 0x00025764 File Offset: 0x00024764
			public event CounterResult.CounterResultExcludeDataRowChangeEventHandler CounterResultExcludeDataRowChanging;

			// Token: 0x14000022 RID: 34
			// (add) Token: 0x06000352 RID: 850 RVA: 0x0002577D File Offset: 0x0002477D
			// (remove) Token: 0x06000353 RID: 851 RVA: 0x00025796 File Offset: 0x00024796
			public event CounterResult.CounterResultExcludeDataRowChangeEventHandler CounterResultExcludeDataRowChanged;

			// Token: 0x14000023 RID: 35
			// (add) Token: 0x06000354 RID: 852 RVA: 0x000257AF File Offset: 0x000247AF
			// (remove) Token: 0x06000355 RID: 853 RVA: 0x000257C8 File Offset: 0x000247C8
			public event CounterResult.CounterResultExcludeDataRowChangeEventHandler CounterResultExcludeDataRowDeleting;

			// Token: 0x14000024 RID: 36
			// (add) Token: 0x06000356 RID: 854 RVA: 0x000257E1 File Offset: 0x000247E1
			// (remove) Token: 0x06000357 RID: 855 RVA: 0x000257FA File Offset: 0x000247FA
			public event CounterResult.CounterResultExcludeDataRowChangeEventHandler CounterResultExcludeDataRowDeleted;

			// Token: 0x06000358 RID: 856 RVA: 0x00025813 File Offset: 0x00024813
			[DebuggerNonUserCode]
			public void AddCounterResultExcludeDataRow(CounterResult.CounterResultExcludeDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000359 RID: 857 RVA: 0x00025824 File Offset: 0x00024824
			[DebuggerNonUserCode]
			public CounterResult.CounterResultExcludeDataRow AddCounterResultExcludeDataRow(string CounterTaskID, string CounterTaskName, string ExcludeName, long Counts)
			{
				CounterResult.CounterResultExcludeDataRow counterResultExcludeDataRow = (CounterResult.CounterResultExcludeDataRow)base.NewRow();
				counterResultExcludeDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					ExcludeName,
					Counts
				};
				base.Rows.Add(counterResultExcludeDataRow);
				return counterResultExcludeDataRow;
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00025878 File Offset: 0x00024878
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00025898 File Offset: 0x00024898
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CounterResultExcludeDataDataTable counterResultExcludeDataDataTable = (CounterResult.CounterResultExcludeDataDataTable)base.Clone();
				counterResultExcludeDataDataTable.InitVars();
				return counterResultExcludeDataDataTable;
			}

			// Token: 0x0600035C RID: 860 RVA: 0x000258C0 File Offset: 0x000248C0
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CounterResultExcludeDataDataTable();
			}

			// Token: 0x0600035D RID: 861 RVA: 0x000258D8 File Offset: 0x000248D8
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnExcludeName = base.Columns["ExcludeName"];
				this.columnCounts = base.Columns["Counts"];
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00025940 File Offset: 0x00024940
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnExcludeName = new DataColumn("ExcludeName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnExcludeName);
				this.columnCounts = new DataColumn("Counts", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnCounts);
				this.columnExcludeName.Caption = "FilePath";
				this.columnCounts.Caption = "Base";
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00025A28 File Offset: 0x00024A28
			[DebuggerNonUserCode]
			public CounterResult.CounterResultExcludeDataRow NewCounterResultExcludeDataRow()
			{
				return (CounterResult.CounterResultExcludeDataRow)base.NewRow();
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00025A48 File Offset: 0x00024A48
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CounterResultExcludeDataRow(builder);
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00025A60 File Offset: 0x00024A60
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CounterResultExcludeDataRow);
			}

			// Token: 0x06000362 RID: 866 RVA: 0x00025A7C File Offset: 0x00024A7C
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CounterResultExcludeDataRowChanged != null)
				{
					this.CounterResultExcludeDataRowChanged(this, new CounterResult.CounterResultExcludeDataRowChangeEvent((CounterResult.CounterResultExcludeDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000363 RID: 867 RVA: 0x00025AC4 File Offset: 0x00024AC4
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CounterResultExcludeDataRowChanging != null)
				{
					this.CounterResultExcludeDataRowChanging(this, new CounterResult.CounterResultExcludeDataRowChangeEvent((CounterResult.CounterResultExcludeDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x00025B0C File Offset: 0x00024B0C
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CounterResultExcludeDataRowDeleted != null)
				{
					this.CounterResultExcludeDataRowDeleted(this, new CounterResult.CounterResultExcludeDataRowChangeEvent((CounterResult.CounterResultExcludeDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00025B54 File Offset: 0x00024B54
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CounterResultExcludeDataRowDeleting != null)
				{
					this.CounterResultExcludeDataRowDeleting(this, new CounterResult.CounterResultExcludeDataRowChangeEvent((CounterResult.CounterResultExcludeDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00025B9C File Offset: 0x00024B9C
			[DebuggerNonUserCode]
			public void RemoveCounterResultExcludeDataRow(CounterResult.CounterResultExcludeDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000367 RID: 871 RVA: 0x00025BAC File Offset: 0x00024BAC
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CounterResultExcludeDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000232 RID: 562
			private DataColumn columnCounterTaskID;

			// Token: 0x04000233 RID: 563
			private DataColumn columnCounterTaskName;

			// Token: 0x04000234 RID: 564
			private DataColumn columnExcludeName;

			// Token: 0x04000235 RID: 565
			private DataColumn columnCounts;
		}

		// Token: 0x0200003A RID: 58
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CounterResultLanguageDataDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000368 RID: 872 RVA: 0x00025CC5 File Offset: 0x00024CC5
			[DebuggerNonUserCode]
			public CounterResultLanguageDataDataTable()
			{
				base.TableName = "CounterResultLanguageData";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000369 RID: 873 RVA: 0x00025CF4 File Offset: 0x00024CF4
			[DebuggerNonUserCode]
			internal CounterResultLanguageDataDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00025DB9 File Offset: 0x00024DB9
			[DebuggerNonUserCode]
			protected CounterResultLanguageDataDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x0600036B RID: 875 RVA: 0x00025DD0 File Offset: 0x00024DD0
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600036C RID: 876 RVA: 0x00025DE8 File Offset: 0x00024DE8
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00025E00 File Offset: 0x00024E00
			[DebuggerNonUserCode]
			public DataColumn LanguageNameColumn
			{
				get
				{
					return this.columnLanguageName;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600036E RID: 878 RVA: 0x00025E18 File Offset: 0x00024E18
			[DebuggerNonUserCode]
			public DataColumn BaseColumn
			{
				get
				{
					return this.columnBase;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00025E30 File Offset: 0x00024E30
			[DebuggerNonUserCode]
			public DataColumn AddedColumn
			{
				get
				{
					return this.columnAdded;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x06000370 RID: 880 RVA: 0x00025E48 File Offset: 0x00024E48
			[DebuggerNonUserCode]
			public DataColumn ModifiedColumn
			{
				get
				{
					return this.columnModified;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00025E60 File Offset: 0x00024E60
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000372 RID: 882 RVA: 0x00025E78 File Offset: 0x00024E78
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x170000A4 RID: 164
			[DebuggerNonUserCode]
			public CounterResult.CounterResultLanguageDataRow this[int index]
			{
				get
				{
					return (CounterResult.CounterResultLanguageDataRow)base.Rows[index];
				}
			}

			// Token: 0x14000025 RID: 37
			// (add) Token: 0x06000374 RID: 884 RVA: 0x00025EBB File Offset: 0x00024EBB
			// (remove) Token: 0x06000375 RID: 885 RVA: 0x00025ED4 File Offset: 0x00024ED4
			public event CounterResult.CounterResultLanguageDataRowChangeEventHandler CounterResultLanguageDataRowChanging;

			// Token: 0x14000026 RID: 38
			// (add) Token: 0x06000376 RID: 886 RVA: 0x00025EED File Offset: 0x00024EED
			// (remove) Token: 0x06000377 RID: 887 RVA: 0x00025F06 File Offset: 0x00024F06
			public event CounterResult.CounterResultLanguageDataRowChangeEventHandler CounterResultLanguageDataRowChanged;

			// Token: 0x14000027 RID: 39
			// (add) Token: 0x06000378 RID: 888 RVA: 0x00025F1F File Offset: 0x00024F1F
			// (remove) Token: 0x06000379 RID: 889 RVA: 0x00025F38 File Offset: 0x00024F38
			public event CounterResult.CounterResultLanguageDataRowChangeEventHandler CounterResultLanguageDataRowDeleting;

			// Token: 0x14000028 RID: 40
			// (add) Token: 0x0600037A RID: 890 RVA: 0x00025F51 File Offset: 0x00024F51
			// (remove) Token: 0x0600037B RID: 891 RVA: 0x00025F6A File Offset: 0x00024F6A
			public event CounterResult.CounterResultLanguageDataRowChangeEventHandler CounterResultLanguageDataRowDeleted;

			// Token: 0x0600037C RID: 892 RVA: 0x00025F83 File Offset: 0x00024F83
			[DebuggerNonUserCode]
			public void AddCounterResultLanguageDataRow(CounterResult.CounterResultLanguageDataRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00025F94 File Offset: 0x00024F94
			[DebuggerNonUserCode]
			public CounterResult.CounterResultLanguageDataRow AddCounterResultLanguageDataRow(string CounterTaskID, string CounterTaskName, string LanguageName, long Base, long Added, long Modified, long Deleted)
			{
				CounterResult.CounterResultLanguageDataRow counterResultLanguageDataRow = (CounterResult.CounterResultLanguageDataRow)base.NewRow();
				counterResultLanguageDataRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					LanguageName,
					Base,
					Added,
					Modified,
					Deleted
				};
				base.Rows.Add(counterResultLanguageDataRow);
				return counterResultLanguageDataRow;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00026004 File Offset: 0x00025004
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00026024 File Offset: 0x00025024
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CounterResultLanguageDataDataTable counterResultLanguageDataDataTable = (CounterResult.CounterResultLanguageDataDataTable)base.Clone();
				counterResultLanguageDataDataTable.InitVars();
				return counterResultLanguageDataDataTable;
			}

			// Token: 0x06000380 RID: 896 RVA: 0x0002604C File Offset: 0x0002504C
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CounterResultLanguageDataDataTable();
			}

			// Token: 0x06000381 RID: 897 RVA: 0x00026064 File Offset: 0x00025064
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnLanguageName = base.Columns["LanguageName"];
				this.columnBase = base.Columns["Base"];
				this.columnAdded = base.Columns["Added"];
				this.columnModified = base.Columns["Modified"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x06000382 RID: 898 RVA: 0x0002610C File Offset: 0x0002510C
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnLanguageName = new DataColumn("LanguageName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLanguageName);
				this.columnBase = new DataColumn("Base", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnBase);
				this.columnAdded = new DataColumn("Added", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnAdded);
				this.columnModified = new DataColumn("Modified", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnModified);
				this.columnDeleted = new DataColumn("Deleted", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnLanguageName.Caption = "FilePath";
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00026270 File Offset: 0x00025270
			[DebuggerNonUserCode]
			public CounterResult.CounterResultLanguageDataRow NewCounterResultLanguageDataRow()
			{
				return (CounterResult.CounterResultLanguageDataRow)base.NewRow();
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00026290 File Offset: 0x00025290
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CounterResultLanguageDataRow(builder);
			}

			// Token: 0x06000385 RID: 901 RVA: 0x000262A8 File Offset: 0x000252A8
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CounterResultLanguageDataRow);
			}

			// Token: 0x06000386 RID: 902 RVA: 0x000262C4 File Offset: 0x000252C4
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CounterResultLanguageDataRowChanged != null)
				{
					this.CounterResultLanguageDataRowChanged(this, new CounterResult.CounterResultLanguageDataRowChangeEvent((CounterResult.CounterResultLanguageDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000387 RID: 903 RVA: 0x0002630C File Offset: 0x0002530C
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CounterResultLanguageDataRowChanging != null)
				{
					this.CounterResultLanguageDataRowChanging(this, new CounterResult.CounterResultLanguageDataRowChangeEvent((CounterResult.CounterResultLanguageDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000388 RID: 904 RVA: 0x00026354 File Offset: 0x00025354
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CounterResultLanguageDataRowDeleted != null)
				{
					this.CounterResultLanguageDataRowDeleted(this, new CounterResult.CounterResultLanguageDataRowChangeEvent((CounterResult.CounterResultLanguageDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000389 RID: 905 RVA: 0x0002639C File Offset: 0x0002539C
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CounterResultLanguageDataRowDeleting != null)
				{
					this.CounterResultLanguageDataRowDeleting(this, new CounterResult.CounterResultLanguageDataRowChangeEvent((CounterResult.CounterResultLanguageDataRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600038A RID: 906 RVA: 0x000263E4 File Offset: 0x000253E4
			[DebuggerNonUserCode]
			public void RemoveCounterResultLanguageDataRow(CounterResult.CounterResultLanguageDataRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x000263F4 File Offset: 0x000253F4
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CounterResultLanguageDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x0400023A RID: 570
			private DataColumn columnCounterTaskID;

			// Token: 0x0400023B RID: 571
			private DataColumn columnCounterTaskName;

			// Token: 0x0400023C RID: 572
			private DataColumn columnLanguageName;

			// Token: 0x0400023D RID: 573
			private DataColumn columnBase;

			// Token: 0x0400023E RID: 574
			private DataColumn columnAdded;

			// Token: 0x0400023F RID: 575
			private DataColumn columnModified;

			// Token: 0x04000240 RID: 576
			private DataColumn columnDeleted;
		}

		// Token: 0x0200003B RID: 59
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CountResultPspDetailsDataTable : DataTable, IEnumerable
		{
			// Token: 0x0600038C RID: 908 RVA: 0x0002650D File Offset: 0x0002550D
			[DebuggerNonUserCode]
			public CountResultPspDetailsDataTable()
			{
				base.TableName = "CountResultPspDetails";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0002653C File Offset: 0x0002553C
			[DebuggerNonUserCode]
			internal CountResultPspDetailsDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00026601 File Offset: 0x00025601
			[DebuggerNonUserCode]
			protected CountResultPspDetailsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600038F RID: 911 RVA: 0x00026618 File Offset: 0x00025618
			[DebuggerNonUserCode]
			public DataColumn CounterTaskIDColumn
			{
				get
				{
					return this.columnCounterTaskID;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000390 RID: 912 RVA: 0x00026630 File Offset: 0x00025630
			[DebuggerNonUserCode]
			public DataColumn CounterTaskNameColumn
			{
				get
				{
					return this.columnCounterTaskName;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000391 RID: 913 RVA: 0x00026648 File Offset: 0x00025648
			[DebuggerNonUserCode]
			public DataColumn FilePathColumn
			{
				get
				{
					return this.columnFilePath;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00026660 File Offset: 0x00025660
			[DebuggerNonUserCode]
			public DataColumn TagTypeColumn
			{
				get
				{
					return this.columnTagType;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000393 RID: 915 RVA: 0x00026678 File Offset: 0x00025678
			[DebuggerNonUserCode]
			public DataColumn TagNameColumn
			{
				get
				{
					return this.columnTagName;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00026690 File Offset: 0x00025690
			[DebuggerNonUserCode]
			public DataColumn ParentNameColumn
			{
				get
				{
					return this.columnParentName;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000395 RID: 917 RVA: 0x000266A8 File Offset: 0x000256A8
			[DebuggerNonUserCode]
			public DataColumn StatusColumn
			{
				get
				{
					return this.columnStatus;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000396 RID: 918 RVA: 0x000266C0 File Offset: 0x000256C0
			[DebuggerNonUserCode]
			public DataColumn BaseColumn
			{
				get
				{
					return this.columnBase;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000397 RID: 919 RVA: 0x000266D8 File Offset: 0x000256D8
			[DebuggerNonUserCode]
			public DataColumn AddedColumn
			{
				get
				{
					return this.columnAdded;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000398 RID: 920 RVA: 0x000266F0 File Offset: 0x000256F0
			[DebuggerNonUserCode]
			public DataColumn ModifiedColumn
			{
				get
				{
					return this.columnModified;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000399 RID: 921 RVA: 0x00026708 File Offset: 0x00025708
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00026720 File Offset: 0x00025720
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x170000B1 RID: 177
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspDetailsRow this[int index]
			{
				get
				{
					return (CounterResult.CountResultPspDetailsRow)base.Rows[index];
				}
			}

			// Token: 0x14000029 RID: 41
			// (add) Token: 0x0600039C RID: 924 RVA: 0x00026763 File Offset: 0x00025763
			// (remove) Token: 0x0600039D RID: 925 RVA: 0x0002677C File Offset: 0x0002577C
			public event CounterResult.CountResultPspDetailsRowChangeEventHandler CountResultPspDetailsRowChanging;

			// Token: 0x1400002A RID: 42
			// (add) Token: 0x0600039E RID: 926 RVA: 0x00026795 File Offset: 0x00025795
			// (remove) Token: 0x0600039F RID: 927 RVA: 0x000267AE File Offset: 0x000257AE
			public event CounterResult.CountResultPspDetailsRowChangeEventHandler CountResultPspDetailsRowChanged;

			// Token: 0x1400002B RID: 43
			// (add) Token: 0x060003A0 RID: 928 RVA: 0x000267C7 File Offset: 0x000257C7
			// (remove) Token: 0x060003A1 RID: 929 RVA: 0x000267E0 File Offset: 0x000257E0
			public event CounterResult.CountResultPspDetailsRowChangeEventHandler CountResultPspDetailsRowDeleting;

			// Token: 0x1400002C RID: 44
			// (add) Token: 0x060003A2 RID: 930 RVA: 0x000267F9 File Offset: 0x000257F9
			// (remove) Token: 0x060003A3 RID: 931 RVA: 0x00026812 File Offset: 0x00025812
			public event CounterResult.CountResultPspDetailsRowChangeEventHandler CountResultPspDetailsRowDeleted;

			// Token: 0x060003A4 RID: 932 RVA: 0x0002682B File Offset: 0x0002582B
			[DebuggerNonUserCode]
			public void AddCountResultPspDetailsRow(CounterResult.CountResultPspDetailsRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x0002683C File Offset: 0x0002583C
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspDetailsRow AddCountResultPspDetailsRow(string CounterTaskID, string CounterTaskName, string FilePath, string TagType, string TagName, string ParentName, string Status, long Base, long Added, long Modified, long Deleted)
			{
				CounterResult.CountResultPspDetailsRow countResultPspDetailsRow = (CounterResult.CountResultPspDetailsRow)base.NewRow();
				countResultPspDetailsRow.ItemArray = new object[]
				{
					CounterTaskID,
					CounterTaskName,
					FilePath,
					TagType,
					TagName,
					ParentName,
					Status,
					Base,
					Added,
					Modified,
					Deleted
				};
				base.Rows.Add(countResultPspDetailsRow);
				return countResultPspDetailsRow;
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x000268C4 File Offset: 0x000258C4
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x000268E4 File Offset: 0x000258E4
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterResult.CountResultPspDetailsDataTable countResultPspDetailsDataTable = (CounterResult.CountResultPspDetailsDataTable)base.Clone();
				countResultPspDetailsDataTable.InitVars();
				return countResultPspDetailsDataTable;
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x0002690C File Offset: 0x0002590C
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterResult.CountResultPspDetailsDataTable();
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00026924 File Offset: 0x00025924
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCounterTaskID = base.Columns["CounterTaskID"];
				this.columnCounterTaskName = base.Columns["CounterTaskName"];
				this.columnFilePath = base.Columns["FilePath"];
				this.columnTagType = base.Columns["TagType"];
				this.columnTagName = base.Columns["TagName"];
				this.columnParentName = base.Columns["ParentName"];
				this.columnStatus = base.Columns["Status"];
				this.columnBase = base.Columns["Base"];
				this.columnAdded = base.Columns["Added"];
				this.columnModified = base.Columns["Modified"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x060003AA RID: 938 RVA: 0x00026A24 File Offset: 0x00025A24
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCounterTaskID = new DataColumn("CounterTaskID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskID);
				this.columnCounterTaskName = new DataColumn("CounterTaskName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCounterTaskName);
				this.columnFilePath = new DataColumn("FilePath", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFilePath);
				this.columnTagType = new DataColumn("TagType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTagType);
				this.columnTagName = new DataColumn("TagName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTagName);
				this.columnParentName = new DataColumn("ParentName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentName);
				this.columnStatus = new DataColumn("Status", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnStatus);
				this.columnBase = new DataColumn("Base", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnBase);
				this.columnAdded = new DataColumn("Added", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnAdded);
				this.columnModified = new DataColumn("Modified", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnModified);
				this.columnDeleted = new DataColumn("Deleted", typeof(long), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnTagType.Caption = "FilePath";
				this.columnTagName.Caption = "FilePath";
				this.columnBase.Caption = "FilePath";
				this.columnAdded.Caption = "FilePath";
				this.columnModified.Caption = "FilePath";
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00026C84 File Offset: 0x00025C84
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspDetailsRow NewCountResultPspDetailsRow()
			{
				return (CounterResult.CountResultPspDetailsRow)base.NewRow();
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00026CA4 File Offset: 0x00025CA4
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterResult.CountResultPspDetailsRow(builder);
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00026CBC File Offset: 0x00025CBC
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterResult.CountResultPspDetailsRow);
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00026CD8 File Offset: 0x00025CD8
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CountResultPspDetailsRowChanged != null)
				{
					this.CountResultPspDetailsRowChanged(this, new CounterResult.CountResultPspDetailsRowChangeEvent((CounterResult.CountResultPspDetailsRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00026D20 File Offset: 0x00025D20
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CountResultPspDetailsRowChanging != null)
				{
					this.CountResultPspDetailsRowChanging(this, new CounterResult.CountResultPspDetailsRowChangeEvent((CounterResult.CountResultPspDetailsRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00026D68 File Offset: 0x00025D68
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CountResultPspDetailsRowDeleted != null)
				{
					this.CountResultPspDetailsRowDeleted(this, new CounterResult.CountResultPspDetailsRowChangeEvent((CounterResult.CountResultPspDetailsRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00026DB0 File Offset: 0x00025DB0
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CountResultPspDetailsRowDeleting != null)
				{
					this.CountResultPspDetailsRowDeleting(this, new CounterResult.CountResultPspDetailsRowChangeEvent((CounterResult.CountResultPspDetailsRow)e.Row, e.Action));
				}
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00026DF8 File Offset: 0x00025DF8
			[DebuggerNonUserCode]
			public void RemoveCountResultPspDetailsRow(CounterResult.CountResultPspDetailsRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00026E08 File Offset: 0x00025E08
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterResult counterResult = new CounterResult();
				xs.Add(counterResult.GetSchemaSerializable());
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = counterResult.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CountResultPspDetailsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000245 RID: 581
			private DataColumn columnCounterTaskID;

			// Token: 0x04000246 RID: 582
			private DataColumn columnCounterTaskName;

			// Token: 0x04000247 RID: 583
			private DataColumn columnFilePath;

			// Token: 0x04000248 RID: 584
			private DataColumn columnTagType;

			// Token: 0x04000249 RID: 585
			private DataColumn columnTagName;

			// Token: 0x0400024A RID: 586
			private DataColumn columnParentName;

			// Token: 0x0400024B RID: 587
			private DataColumn columnStatus;

			// Token: 0x0400024C RID: 588
			private DataColumn columnBase;

			// Token: 0x0400024D RID: 589
			private DataColumn columnAdded;

			// Token: 0x0400024E RID: 590
			private DataColumn columnModified;

			// Token: 0x0400024F RID: 591
			private DataColumn columnDeleted;
		}

		// Token: 0x0200003C RID: 60
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultDataRow : DataRow
		{
			// Token: 0x060003B4 RID: 948 RVA: 0x00026F21 File Offset: 0x00025F21
			[DebuggerNonUserCode]
			internal CounterResultDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCounterResultData = (CounterResult.CounterResultDataDataTable)base.Table;
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00026F40 File Offset: 0x00025F40
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00026F88 File Offset: 0x00025F88
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00026FA0 File Offset: 0x00025FA0
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x00026FE8 File Offset: 0x00025FE8
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00027000 File Offset: 0x00026000
			// (set) Token: 0x060003BA RID: 954 RVA: 0x00027048 File Offset: 0x00026048
			[DebuggerNonUserCode]
			public string FilePath
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultData.FilePathColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FilePath' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.FilePathColumn] = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060003BB RID: 955 RVA: 0x00027060 File Offset: 0x00026060
			// (set) Token: 0x060003BC RID: 956 RVA: 0x000270A8 File Offset: 0x000260A8
			[DebuggerNonUserCode]
			public long Base
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultData.BaseColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Base' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.BaseColumn] = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060003BD RID: 957 RVA: 0x000270C4 File Offset: 0x000260C4
			// (set) Token: 0x060003BE RID: 958 RVA: 0x0002710C File Offset: 0x0002610C
			[DebuggerNonUserCode]
			public long Added
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultData.AddedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Added' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.AddedColumn] = value;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060003BF RID: 959 RVA: 0x00027128 File Offset: 0x00026128
			// (set) Token: 0x060003C0 RID: 960 RVA: 0x00027170 File Offset: 0x00026170
			[DebuggerNonUserCode]
			public long Modified
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultData.ModifiedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Modified' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.ModifiedColumn] = value;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x0002718C File Offset: 0x0002618C
			// (set) Token: 0x060003C2 RID: 962 RVA: 0x000271D4 File Offset: 0x000261D4
			[DebuggerNonUserCode]
			public long Deleted
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultData.DeletedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Deleted' in table 'CounterResultData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultData.DeletedColumn] = value;
				}
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x000271F0 File Offset: 0x000261F0
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCounterResultData.CounterTaskIDColumn);
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00027213 File Offset: 0x00026213
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCounterResultData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00027230 File Offset: 0x00026230
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCounterResultData.CounterTaskNameColumn);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00027253 File Offset: 0x00026253
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCounterResultData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00027270 File Offset: 0x00026270
			[DebuggerNonUserCode]
			public bool IsFilePathNull()
			{
				return base.IsNull(this.tableCounterResultData.FilePathColumn);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00027293 File Offset: 0x00026293
			[DebuggerNonUserCode]
			public void SetFilePathNull()
			{
				base[this.tableCounterResultData.FilePathColumn] = Convert.DBNull;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x000272B0 File Offset: 0x000262B0
			[DebuggerNonUserCode]
			public bool IsBaseNull()
			{
				return base.IsNull(this.tableCounterResultData.BaseColumn);
			}

			// Token: 0x060003CA RID: 970 RVA: 0x000272D3 File Offset: 0x000262D3
			[DebuggerNonUserCode]
			public void SetBaseNull()
			{
				base[this.tableCounterResultData.BaseColumn] = Convert.DBNull;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x000272F0 File Offset: 0x000262F0
			[DebuggerNonUserCode]
			public bool IsAddedNull()
			{
				return base.IsNull(this.tableCounterResultData.AddedColumn);
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00027313 File Offset: 0x00026313
			[DebuggerNonUserCode]
			public void SetAddedNull()
			{
				base[this.tableCounterResultData.AddedColumn] = Convert.DBNull;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00027330 File Offset: 0x00026330
			[DebuggerNonUserCode]
			public bool IsModifiedNull()
			{
				return base.IsNull(this.tableCounterResultData.ModifiedColumn);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00027353 File Offset: 0x00026353
			[DebuggerNonUserCode]
			public void SetModifiedNull()
			{
				base[this.tableCounterResultData.ModifiedColumn] = Convert.DBNull;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00027370 File Offset: 0x00026370
			[DebuggerNonUserCode]
			public bool IsDeletedNull()
			{
				return base.IsNull(this.tableCounterResultData.DeletedColumn);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00027393 File Offset: 0x00026393
			[DebuggerNonUserCode]
			public void SetDeletedNull()
			{
				base[this.tableCounterResultData.DeletedColumn] = Convert.DBNull;
			}

			// Token: 0x04000254 RID: 596
			private CounterResult.CounterResultDataDataTable tableCounterResultData;
		}

		// Token: 0x0200003D RID: 61
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountStandardDataRow : DataRow
		{
			// Token: 0x060003D1 RID: 977 RVA: 0x000273AD File Offset: 0x000263AD
			[DebuggerNonUserCode]
			internal CountStandardDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCountStandardData = (CounterResult.CountStandardDataDataTable)base.Table;
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x000273CC File Offset: 0x000263CC
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x00027414 File Offset: 0x00026414
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountStandardData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CountStandardData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountStandardData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x0002742C File Offset: 0x0002642C
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x00027474 File Offset: 0x00026474
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountStandardData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CountStandardData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountStandardData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x0002748C File Offset: 0x0002648C
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x000274D4 File Offset: 0x000264D4
			[DebuggerNonUserCode]
			public string InfoName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountStandardData.InfoNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'InfoName' in table 'CountStandardData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountStandardData.InfoNameColumn] = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x000274EC File Offset: 0x000264EC
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x00027534 File Offset: 0x00026534
			[DebuggerNonUserCode]
			public string InfoValue
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountStandardData.InfoValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'InfoValue' in table 'CountStandardData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountStandardData.InfoValueColumn] = value;
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x0002754C File Offset: 0x0002654C
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCountStandardData.CounterTaskIDColumn);
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0002756F File Offset: 0x0002656F
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCountStandardData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0002758C File Offset: 0x0002658C
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCountStandardData.CounterTaskNameColumn);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x000275AF File Offset: 0x000265AF
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCountStandardData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x000275CC File Offset: 0x000265CC
			[DebuggerNonUserCode]
			public bool IsInfoNameNull()
			{
				return base.IsNull(this.tableCountStandardData.InfoNameColumn);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x000275EF File Offset: 0x000265EF
			[DebuggerNonUserCode]
			public void SetInfoNameNull()
			{
				base[this.tableCountStandardData.InfoNameColumn] = Convert.DBNull;
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x0002760C File Offset: 0x0002660C
			[DebuggerNonUserCode]
			public bool IsInfoValueNull()
			{
				return base.IsNull(this.tableCountStandardData.InfoValueColumn);
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0002762F File Offset: 0x0002662F
			[DebuggerNonUserCode]
			public void SetInfoValueNull()
			{
				base[this.tableCountStandardData.InfoValueColumn] = Convert.DBNull;
			}

			// Token: 0x04000255 RID: 597
			private CounterResult.CountStandardDataDataTable tableCountStandardData;
		}

		// Token: 0x0200003E RID: 62
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultFolderDataRow : DataRow
		{
			// Token: 0x060003E2 RID: 994 RVA: 0x00027649 File Offset: 0x00026649
			[DebuggerNonUserCode]
			internal CounterResultFolderDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCounterResultFolderData = (CounterResult.CounterResultFolderDataDataTable)base.Table;
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00027668 File Offset: 0x00026668
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x000276B0 File Offset: 0x000266B0
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultFolderData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x000276C8 File Offset: 0x000266C8
			// (set) Token: 0x060003E6 RID: 998 RVA: 0x00027710 File Offset: 0x00026710
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultFolderData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x00027728 File Offset: 0x00026728
			// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00027770 File Offset: 0x00026770
			[DebuggerNonUserCode]
			public string Folder
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultFolderData.FolderColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Folder' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.FolderColumn] = value;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00027788 File Offset: 0x00026788
			// (set) Token: 0x060003EA RID: 1002 RVA: 0x000277D0 File Offset: 0x000267D0
			[DebuggerNonUserCode]
			public long Base
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultFolderData.BaseColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Base' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.BaseColumn] = value;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060003EB RID: 1003 RVA: 0x000277EC File Offset: 0x000267EC
			// (set) Token: 0x060003EC RID: 1004 RVA: 0x00027834 File Offset: 0x00026834
			[DebuggerNonUserCode]
			public long Added
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultFolderData.AddedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Added' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.AddedColumn] = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060003ED RID: 1005 RVA: 0x00027850 File Offset: 0x00026850
			// (set) Token: 0x060003EE RID: 1006 RVA: 0x00027898 File Offset: 0x00026898
			[DebuggerNonUserCode]
			public long Modified
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultFolderData.ModifiedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Modified' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.ModifiedColumn] = value;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060003EF RID: 1007 RVA: 0x000278B4 File Offset: 0x000268B4
			// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000278FC File Offset: 0x000268FC
			[DebuggerNonUserCode]
			public long Deleted
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultFolderData.DeletedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Deleted' in table 'CounterResultFolderData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultFolderData.DeletedColumn] = value;
				}
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00027918 File Offset: 0x00026918
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.CounterTaskIDColumn);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x0002793B File Offset: 0x0002693B
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCounterResultFolderData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00027958 File Offset: 0x00026958
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.CounterTaskNameColumn);
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x0002797B File Offset: 0x0002697B
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCounterResultFolderData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00027998 File Offset: 0x00026998
			[DebuggerNonUserCode]
			public bool IsFolderNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.FolderColumn);
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x000279BB File Offset: 0x000269BB
			[DebuggerNonUserCode]
			public void SetFolderNull()
			{
				base[this.tableCounterResultFolderData.FolderColumn] = Convert.DBNull;
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x000279D8 File Offset: 0x000269D8
			[DebuggerNonUserCode]
			public bool IsBaseNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.BaseColumn);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x000279FB File Offset: 0x000269FB
			[DebuggerNonUserCode]
			public void SetBaseNull()
			{
				base[this.tableCounterResultFolderData.BaseColumn] = Convert.DBNull;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00027A18 File Offset: 0x00026A18
			[DebuggerNonUserCode]
			public bool IsAddedNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.AddedColumn);
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00027A3B File Offset: 0x00026A3B
			[DebuggerNonUserCode]
			public void SetAddedNull()
			{
				base[this.tableCounterResultFolderData.AddedColumn] = Convert.DBNull;
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00027A58 File Offset: 0x00026A58
			[DebuggerNonUserCode]
			public bool IsModifiedNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.ModifiedColumn);
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00027A7B File Offset: 0x00026A7B
			[DebuggerNonUserCode]
			public void SetModifiedNull()
			{
				base[this.tableCounterResultFolderData.ModifiedColumn] = Convert.DBNull;
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00027A98 File Offset: 0x00026A98
			[DebuggerNonUserCode]
			public bool IsDeletedNull()
			{
				return base.IsNull(this.tableCounterResultFolderData.DeletedColumn);
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00027ABB File Offset: 0x00026ABB
			[DebuggerNonUserCode]
			public void SetDeletedNull()
			{
				base[this.tableCounterResultFolderData.DeletedColumn] = Convert.DBNull;
			}

			// Token: 0x04000256 RID: 598
			private CounterResult.CounterResultFolderDataDataTable tableCounterResultFolderData;
		}

		// Token: 0x0200003F RID: 63
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultExcludeDataRow : DataRow
		{
			// Token: 0x060003FF RID: 1023 RVA: 0x00027AD5 File Offset: 0x00026AD5
			[DebuggerNonUserCode]
			internal CounterResultExcludeDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCounterResultExcludeData = (CounterResult.CounterResultExcludeDataDataTable)base.Table;
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00027AF4 File Offset: 0x00026AF4
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00027B3C File Offset: 0x00026B3C
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultExcludeData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CounterResultExcludeData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultExcludeData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x00027B54 File Offset: 0x00026B54
			// (set) Token: 0x06000403 RID: 1027 RVA: 0x00027B9C File Offset: 0x00026B9C
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultExcludeData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CounterResultExcludeData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultExcludeData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00027BB4 File Offset: 0x00026BB4
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x00027BFC File Offset: 0x00026BFC
			[DebuggerNonUserCode]
			public string ExcludeName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultExcludeData.ExcludeNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ExcludeName' in table 'CounterResultExcludeData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultExcludeData.ExcludeNameColumn] = value;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x00027C14 File Offset: 0x00026C14
			// (set) Token: 0x06000407 RID: 1031 RVA: 0x00027C5C File Offset: 0x00026C5C
			[DebuggerNonUserCode]
			public long Counts
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultExcludeData.CountsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Counts' in table 'CounterResultExcludeData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultExcludeData.CountsColumn] = value;
				}
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00027C78 File Offset: 0x00026C78
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCounterResultExcludeData.CounterTaskIDColumn);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00027C9B File Offset: 0x00026C9B
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCounterResultExcludeData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00027CB8 File Offset: 0x00026CB8
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCounterResultExcludeData.CounterTaskNameColumn);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00027CDB File Offset: 0x00026CDB
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCounterResultExcludeData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00027CF8 File Offset: 0x00026CF8
			[DebuggerNonUserCode]
			public bool IsExcludeNameNull()
			{
				return base.IsNull(this.tableCounterResultExcludeData.ExcludeNameColumn);
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00027D1B File Offset: 0x00026D1B
			[DebuggerNonUserCode]
			public void SetExcludeNameNull()
			{
				base[this.tableCounterResultExcludeData.ExcludeNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00027D38 File Offset: 0x00026D38
			[DebuggerNonUserCode]
			public bool IsCountsNull()
			{
				return base.IsNull(this.tableCounterResultExcludeData.CountsColumn);
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00027D5B File Offset: 0x00026D5B
			[DebuggerNonUserCode]
			public void SetCountsNull()
			{
				base[this.tableCounterResultExcludeData.CountsColumn] = Convert.DBNull;
			}

			// Token: 0x04000257 RID: 599
			private CounterResult.CounterResultExcludeDataDataTable tableCounterResultExcludeData;
		}

		// Token: 0x02000040 RID: 64
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultLanguageDataRow : DataRow
		{
			// Token: 0x06000410 RID: 1040 RVA: 0x00027D75 File Offset: 0x00026D75
			[DebuggerNonUserCode]
			internal CounterResultLanguageDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCounterResultLanguageData = (CounterResult.CounterResultLanguageDataDataTable)base.Table;
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00027D94 File Offset: 0x00026D94
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00027DDC File Offset: 0x00026DDC
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultLanguageData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x00027DF4 File Offset: 0x00026DF4
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x00027E3C File Offset: 0x00026E3C
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultLanguageData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00027E54 File Offset: 0x00026E54
			// (set) Token: 0x06000416 RID: 1046 RVA: 0x00027E9C File Offset: 0x00026E9C
			[DebuggerNonUserCode]
			public string LanguageName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultLanguageData.LanguageNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'LanguageName' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.LanguageNameColumn] = value;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x00027EB4 File Offset: 0x00026EB4
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x00027EFC File Offset: 0x00026EFC
			[DebuggerNonUserCode]
			public long Base
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultLanguageData.BaseColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Base' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.BaseColumn] = value;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x00027F18 File Offset: 0x00026F18
			// (set) Token: 0x0600041A RID: 1050 RVA: 0x00027F60 File Offset: 0x00026F60
			[DebuggerNonUserCode]
			public long Added
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultLanguageData.AddedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Added' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.AddedColumn] = value;
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x0600041B RID: 1051 RVA: 0x00027F7C File Offset: 0x00026F7C
			// (set) Token: 0x0600041C RID: 1052 RVA: 0x00027FC4 File Offset: 0x00026FC4
			[DebuggerNonUserCode]
			public long Modified
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultLanguageData.ModifiedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Modified' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.ModifiedColumn] = value;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x0600041D RID: 1053 RVA: 0x00027FE0 File Offset: 0x00026FE0
			// (set) Token: 0x0600041E RID: 1054 RVA: 0x00028028 File Offset: 0x00027028
			[DebuggerNonUserCode]
			public long Deleted
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCounterResultLanguageData.DeletedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Deleted' in table 'CounterResultLanguageData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultLanguageData.DeletedColumn] = value;
				}
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00028044 File Offset: 0x00027044
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.CounterTaskIDColumn);
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00028067 File Offset: 0x00027067
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCounterResultLanguageData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00028084 File Offset: 0x00027084
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.CounterTaskNameColumn);
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x000280A7 File Offset: 0x000270A7
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCounterResultLanguageData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x000280C4 File Offset: 0x000270C4
			[DebuggerNonUserCode]
			public bool IsLanguageNameNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.LanguageNameColumn);
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x000280E7 File Offset: 0x000270E7
			[DebuggerNonUserCode]
			public void SetLanguageNameNull()
			{
				base[this.tableCounterResultLanguageData.LanguageNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00028104 File Offset: 0x00027104
			[DebuggerNonUserCode]
			public bool IsBaseNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.BaseColumn);
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x00028127 File Offset: 0x00027127
			[DebuggerNonUserCode]
			public void SetBaseNull()
			{
				base[this.tableCounterResultLanguageData.BaseColumn] = Convert.DBNull;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00028144 File Offset: 0x00027144
			[DebuggerNonUserCode]
			public bool IsAddedNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.AddedColumn);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00028167 File Offset: 0x00027167
			[DebuggerNonUserCode]
			public void SetAddedNull()
			{
				base[this.tableCounterResultLanguageData.AddedColumn] = Convert.DBNull;
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00028184 File Offset: 0x00027184
			[DebuggerNonUserCode]
			public bool IsModifiedNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.ModifiedColumn);
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x000281A7 File Offset: 0x000271A7
			[DebuggerNonUserCode]
			public void SetModifiedNull()
			{
				base[this.tableCounterResultLanguageData.ModifiedColumn] = Convert.DBNull;
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x000281C4 File Offset: 0x000271C4
			[DebuggerNonUserCode]
			public bool IsDeletedNull()
			{
				return base.IsNull(this.tableCounterResultLanguageData.DeletedColumn);
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x000281E7 File Offset: 0x000271E7
			[DebuggerNonUserCode]
			public void SetDeletedNull()
			{
				base[this.tableCounterResultLanguageData.DeletedColumn] = Convert.DBNull;
			}

			// Token: 0x04000258 RID: 600
			private CounterResult.CounterResultLanguageDataDataTable tableCounterResultLanguageData;
		}

		// Token: 0x02000041 RID: 65
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultMReportDataRow : DataRow
		{
			// Token: 0x0600042D RID: 1069 RVA: 0x00028201 File Offset: 0x00027201
			[DebuggerNonUserCode]
			internal CounterResultMReportDataRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCounterResultMReportData = (CounterResult.CounterResultMReportDataDataTable)base.Table;
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00028220 File Offset: 0x00027220
			// (set) Token: 0x0600042F RID: 1071 RVA: 0x00028268 File Offset: 0x00027268
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultMReportData.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CounterResultMReportData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultMReportData.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x00028280 File Offset: 0x00027280
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x000282C8 File Offset: 0x000272C8
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultMReportData.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CounterResultMReportData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultMReportData.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x000282E0 File Offset: 0x000272E0
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x00028328 File Offset: 0x00027328
			[DebuggerNonUserCode]
			public string Metric
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultMReportData.MetricColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Metric' in table 'CounterResultMReportData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultMReportData.MetricColumn] = value;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00028340 File Offset: 0x00027340
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x00028388 File Offset: 0x00027388
			[DebuggerNonUserCode]
			public string Description
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultMReportData.DescriptionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Description' in table 'CounterResultMReportData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultMReportData.DescriptionColumn] = value;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x000283A0 File Offset: 0x000273A0
			// (set) Token: 0x06000437 RID: 1079 RVA: 0x000283E8 File Offset: 0x000273E8
			[DebuggerNonUserCode]
			public string Data
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCounterResultMReportData.DataColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Data' in table 'CounterResultMReportData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCounterResultMReportData.DataColumn] = value;
				}
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00028400 File Offset: 0x00027400
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCounterResultMReportData.CounterTaskIDColumn);
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x00028423 File Offset: 0x00027423
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCounterResultMReportData.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x00028440 File Offset: 0x00027440
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCounterResultMReportData.CounterTaskNameColumn);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00028463 File Offset: 0x00027463
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCounterResultMReportData.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00028480 File Offset: 0x00027480
			[DebuggerNonUserCode]
			public bool IsMetricNull()
			{
				return base.IsNull(this.tableCounterResultMReportData.MetricColumn);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x000284A3 File Offset: 0x000274A3
			[DebuggerNonUserCode]
			public void SetMetricNull()
			{
				base[this.tableCounterResultMReportData.MetricColumn] = Convert.DBNull;
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x000284C0 File Offset: 0x000274C0
			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return base.IsNull(this.tableCounterResultMReportData.DescriptionColumn);
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x000284E3 File Offset: 0x000274E3
			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				base[this.tableCounterResultMReportData.DescriptionColumn] = Convert.DBNull;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00028500 File Offset: 0x00027500
			[DebuggerNonUserCode]
			public bool IsDataNull()
			{
				return base.IsNull(this.tableCounterResultMReportData.DataColumn);
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00028523 File Offset: 0x00027523
			[DebuggerNonUserCode]
			public void SetDataNull()
			{
				base[this.tableCounterResultMReportData.DataColumn] = Convert.DBNull;
			}

			// Token: 0x04000259 RID: 601
			private CounterResult.CounterResultMReportDataDataTable tableCounterResultMReportData;
		}

		// Token: 0x02000042 RID: 66
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountResultPspSummaryRow : DataRow
		{
			// Token: 0x06000442 RID: 1090 RVA: 0x0002853D File Offset: 0x0002753D
			[DebuggerNonUserCode]
			internal CountResultPspSummaryRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCountResultPspSummary = (CounterResult.CountResultPspSummaryDataTable)base.Table;
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x0002855C File Offset: 0x0002755C
			// (set) Token: 0x06000444 RID: 1092 RVA: 0x000285A4 File Offset: 0x000275A4
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000285BC File Offset: 0x000275BC
			// (set) Token: 0x06000446 RID: 1094 RVA: 0x00028604 File Offset: 0x00027604
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000447 RID: 1095 RVA: 0x0002861C File Offset: 0x0002761C
			// (set) Token: 0x06000448 RID: 1096 RVA: 0x00028664 File Offset: 0x00027664
			[DebuggerNonUserCode]
			public string FilePath
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.FilePathColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FilePath' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.FilePathColumn] = value;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000449 RID: 1097 RVA: 0x0002867C File Offset: 0x0002767C
			// (set) Token: 0x0600044A RID: 1098 RVA: 0x000286C4 File Offset: 0x000276C4
			[DebuggerNonUserCode]
			public string TagType
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.TagTypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TagType' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.TagTypeColumn] = value;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x000286DC File Offset: 0x000276DC
			// (set) Token: 0x0600044C RID: 1100 RVA: 0x00028724 File Offset: 0x00027724
			[DebuggerNonUserCode]
			public string TagValue
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.TagValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TagValue' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.TagValueColumn] = value;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x0002873C File Offset: 0x0002773C
			// (set) Token: 0x0600044E RID: 1102 RVA: 0x00028784 File Offset: 0x00027784
			[DebuggerNonUserCode]
			public string ObjectType
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspSummary.ObjectTypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ObjectType' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.ObjectTypeColumn] = value;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x0002879C File Offset: 0x0002779C
			// (set) Token: 0x06000450 RID: 1104 RVA: 0x000287E4 File Offset: 0x000277E4
			[DebuggerNonUserCode]
			public long Elements
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspSummary.ElementsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Elements' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.ElementsColumn] = value;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x00028800 File Offset: 0x00027800
			// (set) Token: 0x06000452 RID: 1106 RVA: 0x00028848 File Offset: 0x00027848
			[DebuggerNonUserCode]
			public long Base
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspSummary.BaseColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Base' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.BaseColumn] = value;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x00028864 File Offset: 0x00027864
			// (set) Token: 0x06000454 RID: 1108 RVA: 0x000288AC File Offset: 0x000278AC
			[DebuggerNonUserCode]
			public long Added
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspSummary.AddedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Added' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.AddedColumn] = value;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x000288C8 File Offset: 0x000278C8
			// (set) Token: 0x06000456 RID: 1110 RVA: 0x00028910 File Offset: 0x00027910
			[DebuggerNonUserCode]
			public long Modified
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspSummary.ModifiedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Modified' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.ModifiedColumn] = value;
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000457 RID: 1111 RVA: 0x0002892C File Offset: 0x0002792C
			// (set) Token: 0x06000458 RID: 1112 RVA: 0x00028974 File Offset: 0x00027974
			[DebuggerNonUserCode]
			public long Deleted
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspSummary.DeletedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Deleted' in table 'CountResultPspSummary' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspSummary.DeletedColumn] = value;
				}
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00028990 File Offset: 0x00027990
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.CounterTaskIDColumn);
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x000289B3 File Offset: 0x000279B3
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCountResultPspSummary.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x000289D0 File Offset: 0x000279D0
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.CounterTaskNameColumn);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x000289F3 File Offset: 0x000279F3
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCountResultPspSummary.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00028A10 File Offset: 0x00027A10
			[DebuggerNonUserCode]
			public bool IsFilePathNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.FilePathColumn);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00028A33 File Offset: 0x00027A33
			[DebuggerNonUserCode]
			public void SetFilePathNull()
			{
				base[this.tableCountResultPspSummary.FilePathColumn] = Convert.DBNull;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00028A50 File Offset: 0x00027A50
			[DebuggerNonUserCode]
			public bool IsTagTypeNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.TagTypeColumn);
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00028A73 File Offset: 0x00027A73
			[DebuggerNonUserCode]
			public void SetTagTypeNull()
			{
				base[this.tableCountResultPspSummary.TagTypeColumn] = Convert.DBNull;
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00028A90 File Offset: 0x00027A90
			[DebuggerNonUserCode]
			public bool IsTagValueNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.TagValueColumn);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00028AB3 File Offset: 0x00027AB3
			[DebuggerNonUserCode]
			public void SetTagValueNull()
			{
				base[this.tableCountResultPspSummary.TagValueColumn] = Convert.DBNull;
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00028AD0 File Offset: 0x00027AD0
			[DebuggerNonUserCode]
			public bool IsObjectTypeNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.ObjectTypeColumn);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00028AF3 File Offset: 0x00027AF3
			[DebuggerNonUserCode]
			public void SetObjectTypeNull()
			{
				base[this.tableCountResultPspSummary.ObjectTypeColumn] = Convert.DBNull;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00028B10 File Offset: 0x00027B10
			[DebuggerNonUserCode]
			public bool IsElementsNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.ElementsColumn);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00028B33 File Offset: 0x00027B33
			[DebuggerNonUserCode]
			public void SetElementsNull()
			{
				base[this.tableCountResultPspSummary.ElementsColumn] = Convert.DBNull;
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00028B50 File Offset: 0x00027B50
			[DebuggerNonUserCode]
			public bool IsBaseNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.BaseColumn);
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00028B73 File Offset: 0x00027B73
			[DebuggerNonUserCode]
			public void SetBaseNull()
			{
				base[this.tableCountResultPspSummary.BaseColumn] = Convert.DBNull;
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00028B90 File Offset: 0x00027B90
			[DebuggerNonUserCode]
			public bool IsAddedNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.AddedColumn);
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00028BB3 File Offset: 0x00027BB3
			[DebuggerNonUserCode]
			public void SetAddedNull()
			{
				base[this.tableCountResultPspSummary.AddedColumn] = Convert.DBNull;
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00028BD0 File Offset: 0x00027BD0
			[DebuggerNonUserCode]
			public bool IsModifiedNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.ModifiedColumn);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00028BF3 File Offset: 0x00027BF3
			[DebuggerNonUserCode]
			public void SetModifiedNull()
			{
				base[this.tableCountResultPspSummary.ModifiedColumn] = Convert.DBNull;
			}

			// Token: 0x0600046D RID: 1133 RVA: 0x00028C10 File Offset: 0x00027C10
			[DebuggerNonUserCode]
			public bool IsDeletedNull()
			{
				return base.IsNull(this.tableCountResultPspSummary.DeletedColumn);
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00028C33 File Offset: 0x00027C33
			[DebuggerNonUserCode]
			public void SetDeletedNull()
			{
				base[this.tableCountResultPspSummary.DeletedColumn] = Convert.DBNull;
			}

			// Token: 0x0400025A RID: 602
			private CounterResult.CountResultPspSummaryDataTable tableCountResultPspSummary;
		}

		// Token: 0x02000043 RID: 67
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountResultPspDetailsRow : DataRow
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x00028C4D File Offset: 0x00027C4D
			[DebuggerNonUserCode]
			internal CountResultPspDetailsRow(DataRowBuilder rb) : base(rb)
			{
				this.tableCountResultPspDetails = (CounterResult.CountResultPspDetailsDataTable)base.Table;
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x00028C6C File Offset: 0x00027C6C
			// (set) Token: 0x06000471 RID: 1137 RVA: 0x00028CB4 File Offset: 0x00027CB4
			[DebuggerNonUserCode]
			public string CounterTaskID
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.CounterTaskIDColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskID' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.CounterTaskIDColumn] = value;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x00028CCC File Offset: 0x00027CCC
			// (set) Token: 0x06000473 RID: 1139 RVA: 0x00028D14 File Offset: 0x00027D14
			[DebuggerNonUserCode]
			public string CounterTaskName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.CounterTaskNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CounterTaskName' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.CounterTaskNameColumn] = value;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00028D2C File Offset: 0x00027D2C
			// (set) Token: 0x06000475 RID: 1141 RVA: 0x00028D74 File Offset: 0x00027D74
			[DebuggerNonUserCode]
			public string FilePath
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.FilePathColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FilePath' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.FilePathColumn] = value;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00028D8C File Offset: 0x00027D8C
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x00028DD4 File Offset: 0x00027DD4
			[DebuggerNonUserCode]
			public string TagType
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.TagTypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TagType' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.TagTypeColumn] = value;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00028DEC File Offset: 0x00027DEC
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x00028E34 File Offset: 0x00027E34
			[DebuggerNonUserCode]
			public string TagName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.TagNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TagName' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.TagNameColumn] = value;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x00028E4C File Offset: 0x00027E4C
			// (set) Token: 0x0600047B RID: 1147 RVA: 0x00028E94 File Offset: 0x00027E94
			[DebuggerNonUserCode]
			public string ParentName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.ParentNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentName' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.ParentNameColumn] = value;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x00028EAC File Offset: 0x00027EAC
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00028EF4 File Offset: 0x00027EF4
			[DebuggerNonUserCode]
			public string Status
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableCountResultPspDetails.StatusColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Status' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.StatusColumn] = value;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00028F0C File Offset: 0x00027F0C
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x00028F54 File Offset: 0x00027F54
			[DebuggerNonUserCode]
			public long Base
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspDetails.BaseColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Base' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.BaseColumn] = value;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x00028F70 File Offset: 0x00027F70
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x00028FB8 File Offset: 0x00027FB8
			[DebuggerNonUserCode]
			public long Added
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspDetails.AddedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Added' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.AddedColumn] = value;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00028FD4 File Offset: 0x00027FD4
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x0002901C File Offset: 0x0002801C
			[DebuggerNonUserCode]
			public long Modified
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspDetails.ModifiedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Modified' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.ModifiedColumn] = value;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x00029038 File Offset: 0x00028038
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x00029080 File Offset: 0x00028080
			[DebuggerNonUserCode]
			public long Deleted
			{
				get
				{
					long result;
					try
					{
						result = (long)base[this.tableCountResultPspDetails.DeletedColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Deleted' in table 'CountResultPspDetails' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableCountResultPspDetails.DeletedColumn] = value;
				}
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x0002909C File Offset: 0x0002809C
			[DebuggerNonUserCode]
			public bool IsCounterTaskIDNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.CounterTaskIDColumn);
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x000290BF File Offset: 0x000280BF
			[DebuggerNonUserCode]
			public void SetCounterTaskIDNull()
			{
				base[this.tableCountResultPspDetails.CounterTaskIDColumn] = Convert.DBNull;
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x000290DC File Offset: 0x000280DC
			[DebuggerNonUserCode]
			public bool IsCounterTaskNameNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.CounterTaskNameColumn);
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x000290FF File Offset: 0x000280FF
			[DebuggerNonUserCode]
			public void SetCounterTaskNameNull()
			{
				base[this.tableCountResultPspDetails.CounterTaskNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x0002911C File Offset: 0x0002811C
			[DebuggerNonUserCode]
			public bool IsFilePathNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.FilePathColumn);
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x0002913F File Offset: 0x0002813F
			[DebuggerNonUserCode]
			public void SetFilePathNull()
			{
				base[this.tableCountResultPspDetails.FilePathColumn] = Convert.DBNull;
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x0002915C File Offset: 0x0002815C
			[DebuggerNonUserCode]
			public bool IsTagTypeNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.TagTypeColumn);
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x0002917F File Offset: 0x0002817F
			[DebuggerNonUserCode]
			public void SetTagTypeNull()
			{
				base[this.tableCountResultPspDetails.TagTypeColumn] = Convert.DBNull;
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0002919C File Offset: 0x0002819C
			[DebuggerNonUserCode]
			public bool IsTagNameNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.TagNameColumn);
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x000291BF File Offset: 0x000281BF
			[DebuggerNonUserCode]
			public void SetTagNameNull()
			{
				base[this.tableCountResultPspDetails.TagNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x000291DC File Offset: 0x000281DC
			[DebuggerNonUserCode]
			public bool IsParentNameNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.ParentNameColumn);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x000291FF File Offset: 0x000281FF
			[DebuggerNonUserCode]
			public void SetParentNameNull()
			{
				base[this.tableCountResultPspDetails.ParentNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x0002921C File Offset: 0x0002821C
			[DebuggerNonUserCode]
			public bool IsStatusNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.StatusColumn);
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x0002923F File Offset: 0x0002823F
			[DebuggerNonUserCode]
			public void SetStatusNull()
			{
				base[this.tableCountResultPspDetails.StatusColumn] = Convert.DBNull;
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x0002925C File Offset: 0x0002825C
			[DebuggerNonUserCode]
			public bool IsBaseNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.BaseColumn);
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x0002927F File Offset: 0x0002827F
			[DebuggerNonUserCode]
			public void SetBaseNull()
			{
				base[this.tableCountResultPspDetails.BaseColumn] = Convert.DBNull;
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x0002929C File Offset: 0x0002829C
			[DebuggerNonUserCode]
			public bool IsAddedNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.AddedColumn);
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x000292BF File Offset: 0x000282BF
			[DebuggerNonUserCode]
			public void SetAddedNull()
			{
				base[this.tableCountResultPspDetails.AddedColumn] = Convert.DBNull;
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x000292DC File Offset: 0x000282DC
			[DebuggerNonUserCode]
			public bool IsModifiedNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.ModifiedColumn);
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x000292FF File Offset: 0x000282FF
			[DebuggerNonUserCode]
			public void SetModifiedNull()
			{
				base[this.tableCountResultPspDetails.ModifiedColumn] = Convert.DBNull;
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x0002931C File Offset: 0x0002831C
			[DebuggerNonUserCode]
			public bool IsDeletedNull()
			{
				return base.IsNull(this.tableCountResultPspDetails.DeletedColumn);
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0002933F File Offset: 0x0002833F
			[DebuggerNonUserCode]
			public void SetDeletedNull()
			{
				base[this.tableCountResultPspDetails.DeletedColumn] = Convert.DBNull;
			}

			// Token: 0x0400025B RID: 603
			private CounterResult.CountResultPspDetailsDataTable tableCountResultPspDetails;
		}

		// Token: 0x02000044 RID: 68
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultDataRowChangeEvent : EventArgs
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x00029359 File Offset: 0x00028359
			[DebuggerNonUserCode]
			public CounterResultDataRowChangeEvent(CounterResult.CounterResultDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x00029374 File Offset: 0x00028374
			[DebuggerNonUserCode]
			public CounterResult.CounterResultDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x0002938C File Offset: 0x0002838C
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400025C RID: 604
			private CounterResult.CounterResultDataRow eventRow;

			// Token: 0x0400025D RID: 605
			private DataRowAction eventAction;
		}

		// Token: 0x02000045 RID: 69
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountStandardDataRowChangeEvent : EventArgs
		{
			// Token: 0x0600049F RID: 1183 RVA: 0x000293A4 File Offset: 0x000283A4
			[DebuggerNonUserCode]
			public CountStandardDataRowChangeEvent(CounterResult.CountStandardDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000293C0 File Offset: 0x000283C0
			[DebuggerNonUserCode]
			public CounterResult.CountStandardDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000293D8 File Offset: 0x000283D8
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400025E RID: 606
			private CounterResult.CountStandardDataRow eventRow;

			// Token: 0x0400025F RID: 607
			private DataRowAction eventAction;
		}

		// Token: 0x02000046 RID: 70
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultFolderDataRowChangeEvent : EventArgs
		{
			// Token: 0x060004A2 RID: 1186 RVA: 0x000293F0 File Offset: 0x000283F0
			[DebuggerNonUserCode]
			public CounterResultFolderDataRowChangeEvent(CounterResult.CounterResultFolderDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0002940C File Offset: 0x0002840C
			[DebuggerNonUserCode]
			public CounterResult.CounterResultFolderDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00029424 File Offset: 0x00028424
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000260 RID: 608
			private CounterResult.CounterResultFolderDataRow eventRow;

			// Token: 0x04000261 RID: 609
			private DataRowAction eventAction;
		}

		// Token: 0x02000047 RID: 71
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultExcludeDataRowChangeEvent : EventArgs
		{
			// Token: 0x060004A5 RID: 1189 RVA: 0x0002943C File Offset: 0x0002843C
			[DebuggerNonUserCode]
			public CounterResultExcludeDataRowChangeEvent(CounterResult.CounterResultExcludeDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00029458 File Offset: 0x00028458
			[DebuggerNonUserCode]
			public CounterResult.CounterResultExcludeDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00029470 File Offset: 0x00028470
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000262 RID: 610
			private CounterResult.CounterResultExcludeDataRow eventRow;

			// Token: 0x04000263 RID: 611
			private DataRowAction eventAction;
		}

		// Token: 0x02000048 RID: 72
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultLanguageDataRowChangeEvent : EventArgs
		{
			// Token: 0x060004A8 RID: 1192 RVA: 0x00029488 File Offset: 0x00028488
			[DebuggerNonUserCode]
			public CounterResultLanguageDataRowChangeEvent(CounterResult.CounterResultLanguageDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000294A4 File Offset: 0x000284A4
			[DebuggerNonUserCode]
			public CounterResult.CounterResultLanguageDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x000294BC File Offset: 0x000284BC
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000264 RID: 612
			private CounterResult.CounterResultLanguageDataRow eventRow;

			// Token: 0x04000265 RID: 613
			private DataRowAction eventAction;
		}

		// Token: 0x02000049 RID: 73
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CounterResultMReportDataRowChangeEvent : EventArgs
		{
			// Token: 0x060004AB RID: 1195 RVA: 0x000294D4 File Offset: 0x000284D4
			[DebuggerNonUserCode]
			public CounterResultMReportDataRowChangeEvent(CounterResult.CounterResultMReportDataRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060004AC RID: 1196 RVA: 0x000294F0 File Offset: 0x000284F0
			[DebuggerNonUserCode]
			public CounterResult.CounterResultMReportDataRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060004AD RID: 1197 RVA: 0x00029508 File Offset: 0x00028508
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000266 RID: 614
			private CounterResult.CounterResultMReportDataRow eventRow;

			// Token: 0x04000267 RID: 615
			private DataRowAction eventAction;
		}

		// Token: 0x0200004A RID: 74
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountResultPspSummaryRowChangeEvent : EventArgs
		{
			// Token: 0x060004AE RID: 1198 RVA: 0x00029520 File Offset: 0x00028520
			[DebuggerNonUserCode]
			public CountResultPspSummaryRowChangeEvent(CounterResult.CountResultPspSummaryRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060004AF RID: 1199 RVA: 0x0002953C File Offset: 0x0002853C
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspSummaryRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00029554 File Offset: 0x00028554
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000268 RID: 616
			private CounterResult.CountResultPspSummaryRow eventRow;

			// Token: 0x04000269 RID: 617
			private DataRowAction eventAction;
		}

		// Token: 0x0200004B RID: 75
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class CountResultPspDetailsRowChangeEvent : EventArgs
		{
			// Token: 0x060004B1 RID: 1201 RVA: 0x0002956C File Offset: 0x0002856C
			[DebuggerNonUserCode]
			public CountResultPspDetailsRowChangeEvent(CounterResult.CountResultPspDetailsRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00029588 File Offset: 0x00028588
			[DebuggerNonUserCode]
			public CounterResult.CountResultPspDetailsRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000295A0 File Offset: 0x000285A0
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400026A RID: 618
			private CounterResult.CountResultPspDetailsRow eventRow;

			// Token: 0x0400026B RID: 619
			private DataRowAction eventAction;
		}
	}
}
