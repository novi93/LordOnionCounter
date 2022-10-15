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
	// Token: 0x02000013 RID: 19
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("CounterDataDataSet")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[HelpKeyword("vs.data.DataSet")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class CounterDataDataSet : DataSet
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000E8EC File Offset: 0x0000D8EC
		[DebuggerNonUserCode]
		public CounterDataDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000E948 File Offset: 0x0000D948
		[DebuggerNonUserCode]
		protected CounterDataDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
					if (dataSet.Tables["ByQtrByApplication"] != null)
					{
						base.Tables.Add(new CounterDataDataSet.ByQtrByApplicationDataTable(dataSet.Tables["ByQtrByApplication"]));
					}
					if (dataSet.Tables["ReportQuery1"] != null)
					{
						base.Tables.Add(new CounterDataDataSet.ReportQuery1DataTable(dataSet.Tables["ReportQuery1"]));
					}
					if (dataSet.Tables["TotalLOC"] != null)
					{
						base.Tables.Add(new CounterDataDataSet.TotalLOCDataTable(dataSet.Tables["TotalLOC"]));
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000EB54 File Offset: 0x0000DB54
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public CounterDataDataSet.ByQtrByApplicationDataTable ByQtrByApplication
		{
			get
			{
				return this.tableByQtrByApplication;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000EB6C File Offset: 0x0000DB6C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public CounterDataDataSet.ReportQuery1DataTable ReportQuery1
		{
			get
			{
				return this.tableReportQuery1;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000EB84 File Offset: 0x0000DB84
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public CounterDataDataSet.TotalLOCDataTable TotalLOC
		{
			get
			{
				return this.tableTotalLOC;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000EB9C File Offset: 0x0000DB9C
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000EBB4 File Offset: 0x0000DBB4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000EBC0 File Offset: 0x0000DBC0
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000EBD8 File Offset: 0x0000DBD8
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000EBF0 File Offset: 0x0000DBF0
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000EC08 File Offset: 0x0000DC08
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			CounterDataDataSet counterDataDataSet = (CounterDataDataSet)base.Clone();
			counterDataDataSet.InitVars();
			counterDataDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return counterDataDataSet;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000EC3C File Offset: 0x0000DC3C
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000EC50 File Offset: 0x0000DC50
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000EC64 File Offset: 0x0000DC64
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["ByQtrByApplication"] != null)
				{
					base.Tables.Add(new CounterDataDataSet.ByQtrByApplicationDataTable(dataSet.Tables["ByQtrByApplication"]));
				}
				if (dataSet.Tables["ReportQuery1"] != null)
				{
					base.Tables.Add(new CounterDataDataSet.ReportQuery1DataTable(dataSet.Tables["ReportQuery1"]));
				}
				if (dataSet.Tables["TotalLOC"] != null)
				{
					base.Tables.Add(new CounterDataDataSet.TotalLOCDataTable(dataSet.Tables["TotalLOC"]));
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

		// Token: 0x060000C8 RID: 200 RVA: 0x0000EDC0 File Offset: 0x0000DDC0
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000EDFB File Offset: 0x0000DDFB
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000EE08 File Offset: 0x0000DE08
		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableByQtrByApplication = (CounterDataDataSet.ByQtrByApplicationDataTable)base.Tables["ByQtrByApplication"];
			if (initTable)
			{
				if (this.tableByQtrByApplication != null)
				{
					this.tableByQtrByApplication.InitVars();
				}
			}
			this.tableReportQuery1 = (CounterDataDataSet.ReportQuery1DataTable)base.Tables["ReportQuery1"];
			if (initTable)
			{
				if (this.tableReportQuery1 != null)
				{
					this.tableReportQuery1.InitVars();
				}
			}
			this.tableTotalLOC = (CounterDataDataSet.TotalLOCDataTable)base.Tables["TotalLOC"];
			if (initTable)
			{
				if (this.tableTotalLOC != null)
				{
					this.tableTotalLOC.InitVars();
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000EED8 File Offset: 0x0000DED8
		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "CounterDataDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/CounterDataDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableByQtrByApplication = new CounterDataDataSet.ByQtrByApplicationDataTable();
			base.Tables.Add(this.tableByQtrByApplication);
			this.tableReportQuery1 = new CounterDataDataSet.ReportQuery1DataTable();
			base.Tables.Add(this.tableReportQuery1);
			this.tableTotalLOC = new CounterDataDataSet.TotalLOCDataTable();
			base.Tables.Add(this.tableTotalLOC);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000EF74 File Offset: 0x0000DF74
		[DebuggerNonUserCode]
		private bool ShouldSerializeByQtrByApplication()
		{
			return false;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000EF88 File Offset: 0x0000DF88
		[DebuggerNonUserCode]
		private bool ShouldSerializeReportQuery1()
		{
			return false;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000EF9C File Offset: 0x0000DF9C
		[DebuggerNonUserCode]
		private bool ShouldSerializeTotalLOC()
		{
			return false;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000EFB0 File Offset: 0x0000DFB0
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000EFD8 File Offset: 0x0000DFD8
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			CounterDataDataSet counterDataDataSet = new CounterDataDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			xs.Add(counterDataDataSet.GetSchemaSerializable());
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = counterDataDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			return xmlSchemaComplexType;
		}

		// Token: 0x040000EC RID: 236
		private CounterDataDataSet.ByQtrByApplicationDataTable tableByQtrByApplication;

		// Token: 0x040000ED RID: 237
		private CounterDataDataSet.ReportQuery1DataTable tableReportQuery1;

		// Token: 0x040000EE RID: 238
		private CounterDataDataSet.TotalLOCDataTable tableTotalLOC;

		// Token: 0x040000EF RID: 239
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000D2 RID: 210
		public delegate void ByQtrByApplicationRowChangeEventHandler(object sender, CounterDataDataSet.ByQtrByApplicationRowChangeEvent e);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000D6 RID: 214
		public delegate void ReportQuery1RowChangeEventHandler(object sender, CounterDataDataSet.ReportQuery1RowChangeEvent e);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000DA RID: 218
		public delegate void TotalLOCRowChangeEventHandler(object sender, CounterDataDataSet.TotalLOCRowChangeEvent e);

		// Token: 0x02000017 RID: 23
		[XmlSchemaProvider("GetTypedTableSchema")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class ByQtrByApplicationDataTable : DataTable, IEnumerable
		{
			// Token: 0x060000DD RID: 221 RVA: 0x0000F034 File Offset: 0x0000E034
			[DebuggerNonUserCode]
			public ByQtrByApplicationDataTable()
			{
				base.TableName = "ByQtrByApplication";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060000DE RID: 222 RVA: 0x0000F060 File Offset: 0x0000E060
			[DebuggerNonUserCode]
			internal ByQtrByApplicationDataTable(DataTable table)
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

			// Token: 0x060000DF RID: 223 RVA: 0x0000F125 File Offset: 0x0000E125
			[DebuggerNonUserCode]
			protected ByQtrByApplicationDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000F13C File Offset: 0x0000E13C
			[DebuggerNonUserCode]
			public DataColumn QuarterColumn
			{
				get
				{
					return this.columnQuarter;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000F154 File Offset: 0x0000E154
			[DebuggerNonUserCode]
			public DataColumn ApplicationColumn
			{
				get
				{
					return this.columnApplication;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000F16C File Offset: 0x0000E16C
			[DebuggerNonUserCode]
			public DataColumn _C_Column
			{
				get
				{
					return this._columnC_;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000F184 File Offset: 0x0000E184
			[DebuggerNonUserCode]
			public DataColumn _C__Column
			{
				get
				{
					return this._columnC__;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000F19C File Offset: 0x0000E19C
			[DebuggerNonUserCode]
			public DataColumn SQLColumn
			{
				get
				{
					return this.columnSQL;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000F1B4 File Offset: 0x0000E1B4
			[DebuggerNonUserCode]
			public DataColumn VB_NETColumn
			{
				get
				{
					return this.columnVB_NET;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000F1CC File Offset: 0x0000E1CC
			[DebuggerNonUserCode]
			public DataColumn Web_filesColumn
			{
				get
				{
					return this.columnWeb_files;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000F1E4 File Offset: 0x0000E1E4
			[DebuggerNonUserCode]
			public DataColumn Xml_filesColumn
			{
				get
				{
					return this.columnXml_files;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000F1FC File Offset: 0x0000E1FC
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000018 RID: 24
			[DebuggerNonUserCode]
			public CounterDataDataSet.ByQtrByApplicationRow this[int index]
			{
				get
				{
					return (CounterDataDataSet.ByQtrByApplicationRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x060000EA RID: 234 RVA: 0x0000F23F File Offset: 0x0000E23F
			// (remove) Token: 0x060000EB RID: 235 RVA: 0x0000F258 File Offset: 0x0000E258
			public event CounterDataDataSet.ByQtrByApplicationRowChangeEventHandler ByQtrByApplicationRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x060000EC RID: 236 RVA: 0x0000F271 File Offset: 0x0000E271
			// (remove) Token: 0x060000ED RID: 237 RVA: 0x0000F28A File Offset: 0x0000E28A
			public event CounterDataDataSet.ByQtrByApplicationRowChangeEventHandler ByQtrByApplicationRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x060000EE RID: 238 RVA: 0x0000F2A3 File Offset: 0x0000E2A3
			// (remove) Token: 0x060000EF RID: 239 RVA: 0x0000F2BC File Offset: 0x0000E2BC
			public event CounterDataDataSet.ByQtrByApplicationRowChangeEventHandler ByQtrByApplicationRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060000F0 RID: 240 RVA: 0x0000F2D5 File Offset: 0x0000E2D5
			// (remove) Token: 0x060000F1 RID: 241 RVA: 0x0000F2EE File Offset: 0x0000E2EE
			public event CounterDataDataSet.ByQtrByApplicationRowChangeEventHandler ByQtrByApplicationRowDeleted;

			// Token: 0x060000F2 RID: 242 RVA: 0x0000F307 File Offset: 0x0000E307
			[DebuggerNonUserCode]
			public void AddByQtrByApplicationRow(CounterDataDataSet.ByQtrByApplicationRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x0000F318 File Offset: 0x0000E318
			[DebuggerNonUserCode]
			public CounterDataDataSet.ByQtrByApplicationRow AddByQtrByApplicationRow(string Quarter, string Application, int _C_, int _C__, int SQL, int VB_NET, int Web_files, int Xml_files)
			{
				CounterDataDataSet.ByQtrByApplicationRow byQtrByApplicationRow = (CounterDataDataSet.ByQtrByApplicationRow)base.NewRow();
				byQtrByApplicationRow.ItemArray = new object[]
				{
					Quarter,
					Application,
					_C_,
					_C__,
					SQL,
					VB_NET,
					Web_files,
					Xml_files
				};
				base.Rows.Add(byQtrByApplicationRow);
				return byQtrByApplicationRow;
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x0000F398 File Offset: 0x0000E398
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x0000F3B8 File Offset: 0x0000E3B8
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterDataDataSet.ByQtrByApplicationDataTable byQtrByApplicationDataTable = (CounterDataDataSet.ByQtrByApplicationDataTable)base.Clone();
				byQtrByApplicationDataTable.InitVars();
				return byQtrByApplicationDataTable;
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x0000F3E0 File Offset: 0x0000E3E0
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterDataDataSet.ByQtrByApplicationDataTable();
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x0000F3F8 File Offset: 0x0000E3F8
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnQuarter = base.Columns["Quarter"];
				this.columnApplication = base.Columns["Application"];
				this._columnC_ = base.Columns["C#"];
				this._columnC__ = base.Columns["C++"];
				this.columnSQL = base.Columns["SQL"];
				this.columnVB_NET = base.Columns["VB NET"];
				this.columnWeb_files = base.Columns["Web files"];
				this.columnXml_files = base.Columns["Xml files"];
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x0000F4B8 File Offset: 0x0000E4B8
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnQuarter = new DataColumn("Quarter", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnQuarter);
				this.columnApplication = new DataColumn("Application", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnApplication);
				this._columnC_ = new DataColumn("C#", typeof(int), null, MappingType.Element);
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C_");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C_Column");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC_");
				this._columnC_.ExtendedProperties.Add("Generator_UserColumnName", "C#");
				base.Columns.Add(this._columnC_);
				this._columnC__ = new DataColumn("C++", typeof(int), null, MappingType.Element);
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C__");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C__Column");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC__");
				this._columnC__.ExtendedProperties.Add("Generator_UserColumnName", "C++");
				base.Columns.Add(this._columnC__);
				this.columnSQL = new DataColumn("SQL", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnSQL);
				this.columnVB_NET = new DataColumn("VB NET", typeof(int), null, MappingType.Element);
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "VB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "VB_NETColumn");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnVB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_UserColumnName", "VB NET");
				base.Columns.Add(this.columnVB_NET);
				this.columnWeb_files = new DataColumn("Web files", typeof(int), null, MappingType.Element);
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Web_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Web_filesColumn");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnWeb_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_UserColumnName", "Web files");
				base.Columns.Add(this.columnWeb_files);
				this.columnXml_files = new DataColumn("Xml files", typeof(int), null, MappingType.Element);
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Xml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Xml_filesColumn");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnXml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_UserColumnName", "Xml files");
				base.Columns.Add(this.columnXml_files);
				this.columnQuarter.MaxLength = 50;
				this.columnApplication.MaxLength = 50;
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x0000F870 File Offset: 0x0000E870
			[DebuggerNonUserCode]
			public CounterDataDataSet.ByQtrByApplicationRow NewByQtrByApplicationRow()
			{
				return (CounterDataDataSet.ByQtrByApplicationRow)base.NewRow();
			}

			// Token: 0x060000FA RID: 250 RVA: 0x0000F890 File Offset: 0x0000E890
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterDataDataSet.ByQtrByApplicationRow(builder);
			}

			// Token: 0x060000FB RID: 251 RVA: 0x0000F8A8 File Offset: 0x0000E8A8
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterDataDataSet.ByQtrByApplicationRow);
			}

			// Token: 0x060000FC RID: 252 RVA: 0x0000F8C4 File Offset: 0x0000E8C4
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ByQtrByApplicationRowChanged != null)
				{
					this.ByQtrByApplicationRowChanged(this, new CounterDataDataSet.ByQtrByApplicationRowChangeEvent((CounterDataDataSet.ByQtrByApplicationRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x0000F90C File Offset: 0x0000E90C
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ByQtrByApplicationRowChanging != null)
				{
					this.ByQtrByApplicationRowChanging(this, new CounterDataDataSet.ByQtrByApplicationRowChangeEvent((CounterDataDataSet.ByQtrByApplicationRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FE RID: 254 RVA: 0x0000F954 File Offset: 0x0000E954
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ByQtrByApplicationRowDeleted != null)
				{
					this.ByQtrByApplicationRowDeleted(this, new CounterDataDataSet.ByQtrByApplicationRowChangeEvent((CounterDataDataSet.ByQtrByApplicationRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x0000F99C File Offset: 0x0000E99C
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ByQtrByApplicationRowDeleting != null)
				{
					this.ByQtrByApplicationRowDeleting(this, new CounterDataDataSet.ByQtrByApplicationRowChangeEvent((CounterDataDataSet.ByQtrByApplicationRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000100 RID: 256 RVA: 0x0000F9E4 File Offset: 0x0000E9E4
			[DebuggerNonUserCode]
			public void RemoveByQtrByApplicationRow(CounterDataDataSet.ByQtrByApplicationRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x0000F9F4 File Offset: 0x0000E9F4
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterDataDataSet counterDataDataSet = new CounterDataDataSet();
				xs.Add(counterDataDataSet.GetSchemaSerializable());
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
				xmlSchemaAttribute.FixedValue = counterDataDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ByQtrByApplicationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x040000F0 RID: 240
			private DataColumn columnQuarter;

			// Token: 0x040000F1 RID: 241
			private DataColumn columnApplication;

			// Token: 0x040000F2 RID: 242
			private DataColumn _columnC_;

			// Token: 0x040000F3 RID: 243
			private DataColumn _columnC__;

			// Token: 0x040000F4 RID: 244
			private DataColumn columnSQL;

			// Token: 0x040000F5 RID: 245
			private DataColumn columnVB_NET;

			// Token: 0x040000F6 RID: 246
			private DataColumn columnWeb_files;

			// Token: 0x040000F7 RID: 247
			private DataColumn columnXml_files;
		}

		// Token: 0x02000018 RID: 24
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class ReportQuery1DataTable : DataTable, IEnumerable
		{
			// Token: 0x06000102 RID: 258 RVA: 0x0000FB0D File Offset: 0x0000EB0D
			[DebuggerNonUserCode]
			public ReportQuery1DataTable()
			{
				base.TableName = "ReportQuery1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000103 RID: 259 RVA: 0x0000FB3C File Offset: 0x0000EB3C
			[DebuggerNonUserCode]
			internal ReportQuery1DataTable(DataTable table)
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

			// Token: 0x06000104 RID: 260 RVA: 0x0000FC01 File Offset: 0x0000EC01
			[DebuggerNonUserCode]
			protected ReportQuery1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000105 RID: 261 RVA: 0x0000FC18 File Offset: 0x0000EC18
			[DebuggerNonUserCode]
			public DataColumn CategoryNameColumn
			{
				get
				{
					return this.columnCategoryName;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000106 RID: 262 RVA: 0x0000FC30 File Offset: 0x0000EC30
			[DebuggerNonUserCode]
			public DataColumn _C_Column
			{
				get
				{
					return this._columnC_;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000107 RID: 263 RVA: 0x0000FC48 File Offset: 0x0000EC48
			[DebuggerNonUserCode]
			public DataColumn _C__Column
			{
				get
				{
					return this._columnC__;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000108 RID: 264 RVA: 0x0000FC60 File Offset: 0x0000EC60
			[DebuggerNonUserCode]
			public DataColumn SQLColumn
			{
				get
				{
					return this.columnSQL;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000109 RID: 265 RVA: 0x0000FC78 File Offset: 0x0000EC78
			[DebuggerNonUserCode]
			public DataColumn VB_NETColumn
			{
				get
				{
					return this.columnVB_NET;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600010A RID: 266 RVA: 0x0000FC90 File Offset: 0x0000EC90
			[DebuggerNonUserCode]
			public DataColumn Web_filesColumn
			{
				get
				{
					return this.columnWeb_files;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600010B RID: 267 RVA: 0x0000FCA8 File Offset: 0x0000ECA8
			[DebuggerNonUserCode]
			public DataColumn Xml_filesColumn
			{
				get
				{
					return this.columnXml_files;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600010C RID: 268 RVA: 0x0000FCC0 File Offset: 0x0000ECC0
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000021 RID: 33
			[DebuggerNonUserCode]
			public CounterDataDataSet.ReportQuery1Row this[int index]
			{
				get
				{
					return (CounterDataDataSet.ReportQuery1Row)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x0600010E RID: 270 RVA: 0x0000FD03 File Offset: 0x0000ED03
			// (remove) Token: 0x0600010F RID: 271 RVA: 0x0000FD1C File Offset: 0x0000ED1C
			public event CounterDataDataSet.ReportQuery1RowChangeEventHandler ReportQuery1RowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x06000110 RID: 272 RVA: 0x0000FD35 File Offset: 0x0000ED35
			// (remove) Token: 0x06000111 RID: 273 RVA: 0x0000FD4E File Offset: 0x0000ED4E
			public event CounterDataDataSet.ReportQuery1RowChangeEventHandler ReportQuery1RowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x06000112 RID: 274 RVA: 0x0000FD67 File Offset: 0x0000ED67
			// (remove) Token: 0x06000113 RID: 275 RVA: 0x0000FD80 File Offset: 0x0000ED80
			public event CounterDataDataSet.ReportQuery1RowChangeEventHandler ReportQuery1RowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x06000114 RID: 276 RVA: 0x0000FD99 File Offset: 0x0000ED99
			// (remove) Token: 0x06000115 RID: 277 RVA: 0x0000FDB2 File Offset: 0x0000EDB2
			public event CounterDataDataSet.ReportQuery1RowChangeEventHandler ReportQuery1RowDeleted;

			// Token: 0x06000116 RID: 278 RVA: 0x0000FDCB File Offset: 0x0000EDCB
			[DebuggerNonUserCode]
			public void AddReportQuery1Row(CounterDataDataSet.ReportQuery1Row row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x0000FDDC File Offset: 0x0000EDDC
			[DebuggerNonUserCode]
			public CounterDataDataSet.ReportQuery1Row AddReportQuery1Row(string CategoryName, int _C_, int _C__, int SQL, int VB_NET, int Web_files, int Xml_files)
			{
				CounterDataDataSet.ReportQuery1Row reportQuery1Row = (CounterDataDataSet.ReportQuery1Row)base.NewRow();
				reportQuery1Row.ItemArray = new object[]
				{
					CategoryName,
					_C_,
					_C__,
					SQL,
					VB_NET,
					Web_files,
					Xml_files
				};
				base.Rows.Add(reportQuery1Row);
				return reportQuery1Row;
			}

			// Token: 0x06000118 RID: 280 RVA: 0x0000FE58 File Offset: 0x0000EE58
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000119 RID: 281 RVA: 0x0000FE78 File Offset: 0x0000EE78
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterDataDataSet.ReportQuery1DataTable reportQuery1DataTable = (CounterDataDataSet.ReportQuery1DataTable)base.Clone();
				reportQuery1DataTable.InitVars();
				return reportQuery1DataTable;
			}

			// Token: 0x0600011A RID: 282 RVA: 0x0000FEA0 File Offset: 0x0000EEA0
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterDataDataSet.ReportQuery1DataTable();
			}

			// Token: 0x0600011B RID: 283 RVA: 0x0000FEB8 File Offset: 0x0000EEB8
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnCategoryName = base.Columns["CategoryName"];
				this._columnC_ = base.Columns["C#"];
				this._columnC__ = base.Columns["C++"];
				this.columnSQL = base.Columns["SQL"];
				this.columnVB_NET = base.Columns["VB NET"];
				this.columnWeb_files = base.Columns["Web files"];
				this.columnXml_files = base.Columns["Xml files"];
			}

			// Token: 0x0600011C RID: 284 RVA: 0x0000FF60 File Offset: 0x0000EF60
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnCategoryName = new DataColumn("CategoryName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCategoryName);
				this._columnC_ = new DataColumn("C#", typeof(int), null, MappingType.Element);
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C_");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C_Column");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC_");
				this._columnC_.ExtendedProperties.Add("Generator_UserColumnName", "C#");
				base.Columns.Add(this._columnC_);
				this._columnC__ = new DataColumn("C++", typeof(int), null, MappingType.Element);
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C__");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C__Column");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC__");
				this._columnC__.ExtendedProperties.Add("Generator_UserColumnName", "C++");
				base.Columns.Add(this._columnC__);
				this.columnSQL = new DataColumn("SQL", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnSQL);
				this.columnVB_NET = new DataColumn("VB NET", typeof(int), null, MappingType.Element);
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "VB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "VB_NETColumn");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnVB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_UserColumnName", "VB NET");
				base.Columns.Add(this.columnVB_NET);
				this.columnWeb_files = new DataColumn("Web files", typeof(int), null, MappingType.Element);
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Web_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Web_filesColumn");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnWeb_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_UserColumnName", "Web files");
				base.Columns.Add(this.columnWeb_files);
				this.columnXml_files = new DataColumn("Xml files", typeof(int), null, MappingType.Element);
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Xml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Xml_filesColumn");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnXml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_UserColumnName", "Xml files");
				base.Columns.Add(this.columnXml_files);
				this.columnCategoryName.MaxLength = 50;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x000102DC File Offset: 0x0000F2DC
			[DebuggerNonUserCode]
			public CounterDataDataSet.ReportQuery1Row NewReportQuery1Row()
			{
				return (CounterDataDataSet.ReportQuery1Row)base.NewRow();
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000102FC File Offset: 0x0000F2FC
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterDataDataSet.ReportQuery1Row(builder);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00010314 File Offset: 0x0000F314
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterDataDataSet.ReportQuery1Row);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00010330 File Offset: 0x0000F330
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ReportQuery1RowChanged != null)
				{
					this.ReportQuery1RowChanged(this, new CounterDataDataSet.ReportQuery1RowChangeEvent((CounterDataDataSet.ReportQuery1Row)e.Row, e.Action));
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00010378 File Offset: 0x0000F378
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ReportQuery1RowChanging != null)
				{
					this.ReportQuery1RowChanging(this, new CounterDataDataSet.ReportQuery1RowChangeEvent((CounterDataDataSet.ReportQuery1Row)e.Row, e.Action));
				}
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000103C0 File Offset: 0x0000F3C0
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ReportQuery1RowDeleted != null)
				{
					this.ReportQuery1RowDeleted(this, new CounterDataDataSet.ReportQuery1RowChangeEvent((CounterDataDataSet.ReportQuery1Row)e.Row, e.Action));
				}
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00010408 File Offset: 0x0000F408
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ReportQuery1RowDeleting != null)
				{
					this.ReportQuery1RowDeleting(this, new CounterDataDataSet.ReportQuery1RowChangeEvent((CounterDataDataSet.ReportQuery1Row)e.Row, e.Action));
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00010450 File Offset: 0x0000F450
			[DebuggerNonUserCode]
			public void RemoveReportQuery1Row(CounterDataDataSet.ReportQuery1Row row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00010460 File Offset: 0x0000F460
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterDataDataSet counterDataDataSet = new CounterDataDataSet();
				xs.Add(counterDataDataSet.GetSchemaSerializable());
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
				xmlSchemaAttribute.FixedValue = counterDataDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "ReportQuery1DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x040000FC RID: 252
			private DataColumn columnCategoryName;

			// Token: 0x040000FD RID: 253
			private DataColumn _columnC_;

			// Token: 0x040000FE RID: 254
			private DataColumn _columnC__;

			// Token: 0x040000FF RID: 255
			private DataColumn columnSQL;

			// Token: 0x04000100 RID: 256
			private DataColumn columnVB_NET;

			// Token: 0x04000101 RID: 257
			private DataColumn columnWeb_files;

			// Token: 0x04000102 RID: 258
			private DataColumn columnXml_files;
		}

		// Token: 0x02000019 RID: 25
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class TotalLOCDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000126 RID: 294 RVA: 0x00010579 File Offset: 0x0000F579
			[DebuggerNonUserCode]
			public TotalLOCDataTable()
			{
				base.TableName = "TotalLOC";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000127 RID: 295 RVA: 0x000105A8 File Offset: 0x0000F5A8
			[DebuggerNonUserCode]
			internal TotalLOCDataTable(DataTable table)
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

			// Token: 0x06000128 RID: 296 RVA: 0x0001066D File Offset: 0x0000F66D
			[DebuggerNonUserCode]
			protected TotalLOCDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00010684 File Offset: 0x0000F684
			[DebuggerNonUserCode]
			public DataColumn TotalColumn
			{
				get
				{
					return this.columnTotal;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600012A RID: 298 RVA: 0x0001069C File Offset: 0x0000F69C
			[DebuggerNonUserCode]
			public DataColumn _C_Column
			{
				get
				{
					return this._columnC_;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600012B RID: 299 RVA: 0x000106B4 File Offset: 0x0000F6B4
			[DebuggerNonUserCode]
			public DataColumn _C__Column
			{
				get
				{
					return this._columnC__;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x0600012C RID: 300 RVA: 0x000106CC File Offset: 0x0000F6CC
			[DebuggerNonUserCode]
			public DataColumn SQLColumn
			{
				get
				{
					return this.columnSQL;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600012D RID: 301 RVA: 0x000106E4 File Offset: 0x0000F6E4
			[DebuggerNonUserCode]
			public DataColumn VB_NETColumn
			{
				get
				{
					return this.columnVB_NET;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600012E RID: 302 RVA: 0x000106FC File Offset: 0x0000F6FC
			[DebuggerNonUserCode]
			public DataColumn Web_filesColumn
			{
				get
				{
					return this.columnWeb_files;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00010714 File Offset: 0x0000F714
			[DebuggerNonUserCode]
			public DataColumn Xml_filesColumn
			{
				get
				{
					return this.columnXml_files;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000130 RID: 304 RVA: 0x0001072C File Offset: 0x0000F72C
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700002A RID: 42
			[DebuggerNonUserCode]
			public CounterDataDataSet.TotalLOCRow this[int index]
			{
				get
				{
					return (CounterDataDataSet.TotalLOCRow)base.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x06000132 RID: 306 RVA: 0x0001076F File Offset: 0x0000F76F
			// (remove) Token: 0x06000133 RID: 307 RVA: 0x00010788 File Offset: 0x0000F788
			public event CounterDataDataSet.TotalLOCRowChangeEventHandler TotalLOCRowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x06000134 RID: 308 RVA: 0x000107A1 File Offset: 0x0000F7A1
			// (remove) Token: 0x06000135 RID: 309 RVA: 0x000107BA File Offset: 0x0000F7BA
			public event CounterDataDataSet.TotalLOCRowChangeEventHandler TotalLOCRowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x06000136 RID: 310 RVA: 0x000107D3 File Offset: 0x0000F7D3
			// (remove) Token: 0x06000137 RID: 311 RVA: 0x000107EC File Offset: 0x0000F7EC
			public event CounterDataDataSet.TotalLOCRowChangeEventHandler TotalLOCRowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x06000138 RID: 312 RVA: 0x00010805 File Offset: 0x0000F805
			// (remove) Token: 0x06000139 RID: 313 RVA: 0x0001081E File Offset: 0x0000F81E
			public event CounterDataDataSet.TotalLOCRowChangeEventHandler TotalLOCRowDeleted;

			// Token: 0x0600013A RID: 314 RVA: 0x00010837 File Offset: 0x0000F837
			[DebuggerNonUserCode]
			public void AddTotalLOCRow(CounterDataDataSet.TotalLOCRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00010848 File Offset: 0x0000F848
			[DebuggerNonUserCode]
			public CounterDataDataSet.TotalLOCRow AddTotalLOCRow(string Total, int _C_, int _C__, int SQL, int VB_NET, int Web_files, int Xml_files)
			{
				CounterDataDataSet.TotalLOCRow totalLOCRow = (CounterDataDataSet.TotalLOCRow)base.NewRow();
				totalLOCRow.ItemArray = new object[]
				{
					Total,
					_C_,
					_C__,
					SQL,
					VB_NET,
					Web_files,
					Xml_files
				};
				base.Rows.Add(totalLOCRow);
				return totalLOCRow;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x000108C4 File Offset: 0x0000F8C4
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x0600013D RID: 317 RVA: 0x000108E4 File Offset: 0x0000F8E4
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				CounterDataDataSet.TotalLOCDataTable totalLOCDataTable = (CounterDataDataSet.TotalLOCDataTable)base.Clone();
				totalLOCDataTable.InitVars();
				return totalLOCDataTable;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x0001090C File Offset: 0x0000F90C
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CounterDataDataSet.TotalLOCDataTable();
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00010924 File Offset: 0x0000F924
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnTotal = base.Columns["Total"];
				this._columnC_ = base.Columns["C#"];
				this._columnC__ = base.Columns["C++"];
				this.columnSQL = base.Columns["SQL"];
				this.columnVB_NET = base.Columns["VB NET"];
				this.columnWeb_files = base.Columns["Web files"];
				this.columnXml_files = base.Columns["Xml files"];
			}

			// Token: 0x06000140 RID: 320 RVA: 0x000109CC File Offset: 0x0000F9CC
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnTotal = new DataColumn("Total", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTotal);
				this._columnC_ = new DataColumn("C#", typeof(int), null, MappingType.Element);
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C_");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C_Column");
				this._columnC_.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC_");
				this._columnC_.ExtendedProperties.Add("Generator_UserColumnName", "C#");
				base.Columns.Add(this._columnC_);
				this._columnC__ = new DataColumn("C++", typeof(int), null, MappingType.Element);
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_C__");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_C__Column");
				this._columnC__.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnC__");
				this._columnC__.ExtendedProperties.Add("Generator_UserColumnName", "C++");
				base.Columns.Add(this._columnC__);
				this.columnSQL = new DataColumn("SQL", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnSQL);
				this.columnVB_NET = new DataColumn("VB NET", typeof(int), null, MappingType.Element);
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "VB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "VB_NETColumn");
				this.columnVB_NET.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnVB_NET");
				this.columnVB_NET.ExtendedProperties.Add("Generator_UserColumnName", "VB NET");
				base.Columns.Add(this.columnVB_NET);
				this.columnWeb_files = new DataColumn("Web files", typeof(int), null, MappingType.Element);
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Web_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Web_filesColumn");
				this.columnWeb_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnWeb_files");
				this.columnWeb_files.ExtendedProperties.Add("Generator_UserColumnName", "Web files");
				base.Columns.Add(this.columnWeb_files);
				this.columnXml_files = new DataColumn("Xml files", typeof(int), null, MappingType.Element);
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Xml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "Xml_filesColumn");
				this.columnXml_files.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnXml_files");
				this.columnXml_files.ExtendedProperties.Add("Generator_UserColumnName", "Xml files");
				base.Columns.Add(this.columnXml_files);
				this.columnTotal.ReadOnly = true;
				this.columnTotal.MaxLength = 5;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00010D54 File Offset: 0x0000FD54
			[DebuggerNonUserCode]
			public CounterDataDataSet.TotalLOCRow NewTotalLOCRow()
			{
				return (CounterDataDataSet.TotalLOCRow)base.NewRow();
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00010D74 File Offset: 0x0000FD74
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CounterDataDataSet.TotalLOCRow(builder);
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00010D8C File Offset: 0x0000FD8C
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CounterDataDataSet.TotalLOCRow);
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00010DA8 File Offset: 0x0000FDA8
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TotalLOCRowChanged != null)
				{
					this.TotalLOCRowChanged(this, new CounterDataDataSet.TotalLOCRowChangeEvent((CounterDataDataSet.TotalLOCRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00010DF0 File Offset: 0x0000FDF0
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TotalLOCRowChanging != null)
				{
					this.TotalLOCRowChanging(this, new CounterDataDataSet.TotalLOCRowChangeEvent((CounterDataDataSet.TotalLOCRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00010E38 File Offset: 0x0000FE38
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TotalLOCRowDeleted != null)
				{
					this.TotalLOCRowDeleted(this, new CounterDataDataSet.TotalLOCRowChangeEvent((CounterDataDataSet.TotalLOCRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00010E80 File Offset: 0x0000FE80
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TotalLOCRowDeleting != null)
				{
					this.TotalLOCRowDeleting(this, new CounterDataDataSet.TotalLOCRowChangeEvent((CounterDataDataSet.TotalLOCRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00010EC8 File Offset: 0x0000FEC8
			[DebuggerNonUserCode]
			public void RemoveTotalLOCRow(CounterDataDataSet.TotalLOCRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00010ED8 File Offset: 0x0000FED8
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CounterDataDataSet counterDataDataSet = new CounterDataDataSet();
				xs.Add(counterDataDataSet.GetSchemaSerializable());
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
				xmlSchemaAttribute.FixedValue = counterDataDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "TotalLOCDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				return xmlSchemaComplexType;
			}

			// Token: 0x04000107 RID: 263
			private DataColumn columnTotal;

			// Token: 0x04000108 RID: 264
			private DataColumn _columnC_;

			// Token: 0x04000109 RID: 265
			private DataColumn _columnC__;

			// Token: 0x0400010A RID: 266
			private DataColumn columnSQL;

			// Token: 0x0400010B RID: 267
			private DataColumn columnVB_NET;

			// Token: 0x0400010C RID: 268
			private DataColumn columnWeb_files;

			// Token: 0x0400010D RID: 269
			private DataColumn columnXml_files;
		}

		// Token: 0x0200001A RID: 26
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ByQtrByApplicationRow : DataRow
		{
			// Token: 0x0600014A RID: 330 RVA: 0x00010FF1 File Offset: 0x0000FFF1
			[DebuggerNonUserCode]
			internal ByQtrByApplicationRow(DataRowBuilder rb) : base(rb)
			{
				this.tableByQtrByApplication = (CounterDataDataSet.ByQtrByApplicationDataTable)base.Table;
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600014B RID: 331 RVA: 0x00011010 File Offset: 0x00010010
			// (set) Token: 0x0600014C RID: 332 RVA: 0x00011058 File Offset: 0x00010058
			[DebuggerNonUserCode]
			public string Quarter
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableByQtrByApplication.QuarterColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Quarter' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.QuarterColumn] = value;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600014D RID: 333 RVA: 0x00011070 File Offset: 0x00010070
			// (set) Token: 0x0600014E RID: 334 RVA: 0x000110B8 File Offset: 0x000100B8
			[DebuggerNonUserCode]
			public string Application
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableByQtrByApplication.ApplicationColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Application' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.ApplicationColumn] = value;
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600014F RID: 335 RVA: 0x000110D0 File Offset: 0x000100D0
			// (set) Token: 0x06000150 RID: 336 RVA: 0x00011118 File Offset: 0x00010118
			[DebuggerNonUserCode]
			public int _C_
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication._C_Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C#' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication._C_Column] = value;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000151 RID: 337 RVA: 0x00011134 File Offset: 0x00010134
			// (set) Token: 0x06000152 RID: 338 RVA: 0x0001117C File Offset: 0x0001017C
			[DebuggerNonUserCode]
			public int _C__
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication._C__Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C++' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication._C__Column] = value;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000153 RID: 339 RVA: 0x00011198 File Offset: 0x00010198
			// (set) Token: 0x06000154 RID: 340 RVA: 0x000111E0 File Offset: 0x000101E0
			[DebuggerNonUserCode]
			public int SQL
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication.SQLColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SQL' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.SQLColumn] = value;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000155 RID: 341 RVA: 0x000111FC File Offset: 0x000101FC
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00011244 File Offset: 0x00010244
			[DebuggerNonUserCode]
			public int VB_NET
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication.VB_NETColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'VB NET' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.VB_NETColumn] = value;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00011260 File Offset: 0x00010260
			// (set) Token: 0x06000158 RID: 344 RVA: 0x000112A8 File Offset: 0x000102A8
			[DebuggerNonUserCode]
			public int Web_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication.Web_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Web files' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.Web_filesColumn] = value;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000159 RID: 345 RVA: 0x000112C4 File Offset: 0x000102C4
			// (set) Token: 0x0600015A RID: 346 RVA: 0x0001130C File Offset: 0x0001030C
			[DebuggerNonUserCode]
			public int Xml_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableByQtrByApplication.Xml_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Xml files' in table 'ByQtrByApplication' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableByQtrByApplication.Xml_filesColumn] = value;
				}
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00011328 File Offset: 0x00010328
			[DebuggerNonUserCode]
			public bool IsQuarterNull()
			{
				return base.IsNull(this.tableByQtrByApplication.QuarterColumn);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x0001134B File Offset: 0x0001034B
			[DebuggerNonUserCode]
			public void SetQuarterNull()
			{
				base[this.tableByQtrByApplication.QuarterColumn] = Convert.DBNull;
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00011368 File Offset: 0x00010368
			[DebuggerNonUserCode]
			public bool IsApplicationNull()
			{
				return base.IsNull(this.tableByQtrByApplication.ApplicationColumn);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x0001138B File Offset: 0x0001038B
			[DebuggerNonUserCode]
			public void SetApplicationNull()
			{
				base[this.tableByQtrByApplication.ApplicationColumn] = Convert.DBNull;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x000113A8 File Offset: 0x000103A8
			[DebuggerNonUserCode]
			public bool Is_C_Null()
			{
				return base.IsNull(this.tableByQtrByApplication._C_Column);
			}

			// Token: 0x06000160 RID: 352 RVA: 0x000113CB File Offset: 0x000103CB
			[DebuggerNonUserCode]
			public void Set_C_Null()
			{
				base[this.tableByQtrByApplication._C_Column] = Convert.DBNull;
			}

			// Token: 0x06000161 RID: 353 RVA: 0x000113E8 File Offset: 0x000103E8
			[DebuggerNonUserCode]
			public bool Is_C__Null()
			{
				return base.IsNull(this.tableByQtrByApplication._C__Column);
			}

			// Token: 0x06000162 RID: 354 RVA: 0x0001140B File Offset: 0x0001040B
			[DebuggerNonUserCode]
			public void Set_C__Null()
			{
				base[this.tableByQtrByApplication._C__Column] = Convert.DBNull;
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00011428 File Offset: 0x00010428
			[DebuggerNonUserCode]
			public bool IsSQLNull()
			{
				return base.IsNull(this.tableByQtrByApplication.SQLColumn);
			}

			// Token: 0x06000164 RID: 356 RVA: 0x0001144B File Offset: 0x0001044B
			[DebuggerNonUserCode]
			public void SetSQLNull()
			{
				base[this.tableByQtrByApplication.SQLColumn] = Convert.DBNull;
			}

			// Token: 0x06000165 RID: 357 RVA: 0x00011468 File Offset: 0x00010468
			[DebuggerNonUserCode]
			public bool IsVB_NETNull()
			{
				return base.IsNull(this.tableByQtrByApplication.VB_NETColumn);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x0001148B File Offset: 0x0001048B
			[DebuggerNonUserCode]
			public void SetVB_NETNull()
			{
				base[this.tableByQtrByApplication.VB_NETColumn] = Convert.DBNull;
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000114A8 File Offset: 0x000104A8
			[DebuggerNonUserCode]
			public bool IsWeb_filesNull()
			{
				return base.IsNull(this.tableByQtrByApplication.Web_filesColumn);
			}

			// Token: 0x06000168 RID: 360 RVA: 0x000114CB File Offset: 0x000104CB
			[DebuggerNonUserCode]
			public void SetWeb_filesNull()
			{
				base[this.tableByQtrByApplication.Web_filesColumn] = Convert.DBNull;
			}

			// Token: 0x06000169 RID: 361 RVA: 0x000114E8 File Offset: 0x000104E8
			[DebuggerNonUserCode]
			public bool IsXml_filesNull()
			{
				return base.IsNull(this.tableByQtrByApplication.Xml_filesColumn);
			}

			// Token: 0x0600016A RID: 362 RVA: 0x0001150B File Offset: 0x0001050B
			[DebuggerNonUserCode]
			public void SetXml_filesNull()
			{
				base[this.tableByQtrByApplication.Xml_filesColumn] = Convert.DBNull;
			}

			// Token: 0x04000112 RID: 274
			private CounterDataDataSet.ByQtrByApplicationDataTable tableByQtrByApplication;
		}

		// Token: 0x0200001B RID: 27
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ReportQuery1Row : DataRow
		{
			// Token: 0x0600016B RID: 363 RVA: 0x00011525 File Offset: 0x00010525
			[DebuggerNonUserCode]
			internal ReportQuery1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableReportQuery1 = (CounterDataDataSet.ReportQuery1DataTable)base.Table;
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00011544 File Offset: 0x00010544
			// (set) Token: 0x0600016D RID: 365 RVA: 0x0001158C File Offset: 0x0001058C
			[DebuggerNonUserCode]
			public string CategoryName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableReportQuery1.CategoryNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CategoryName' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1.CategoryNameColumn] = value;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x0600016E RID: 366 RVA: 0x000115A4 File Offset: 0x000105A4
			// (set) Token: 0x0600016F RID: 367 RVA: 0x000115EC File Offset: 0x000105EC
			[DebuggerNonUserCode]
			public int _C_
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1._C_Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C#' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1._C_Column] = value;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000170 RID: 368 RVA: 0x00011608 File Offset: 0x00010608
			// (set) Token: 0x06000171 RID: 369 RVA: 0x00011650 File Offset: 0x00010650
			[DebuggerNonUserCode]
			public int _C__
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1._C__Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C++' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1._C__Column] = value;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000172 RID: 370 RVA: 0x0001166C File Offset: 0x0001066C
			// (set) Token: 0x06000173 RID: 371 RVA: 0x000116B4 File Offset: 0x000106B4
			[DebuggerNonUserCode]
			public int SQL
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1.SQLColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SQL' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1.SQLColumn] = value;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000174 RID: 372 RVA: 0x000116D0 File Offset: 0x000106D0
			// (set) Token: 0x06000175 RID: 373 RVA: 0x00011718 File Offset: 0x00010718
			[DebuggerNonUserCode]
			public int VB_NET
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1.VB_NETColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'VB NET' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1.VB_NETColumn] = value;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000176 RID: 374 RVA: 0x00011734 File Offset: 0x00010734
			// (set) Token: 0x06000177 RID: 375 RVA: 0x0001177C File Offset: 0x0001077C
			[DebuggerNonUserCode]
			public int Web_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1.Web_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Web files' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1.Web_filesColumn] = value;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000178 RID: 376 RVA: 0x00011798 File Offset: 0x00010798
			// (set) Token: 0x06000179 RID: 377 RVA: 0x000117E0 File Offset: 0x000107E0
			[DebuggerNonUserCode]
			public int Xml_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableReportQuery1.Xml_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Xml files' in table 'ReportQuery1' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableReportQuery1.Xml_filesColumn] = value;
				}
			}

			// Token: 0x0600017A RID: 378 RVA: 0x000117FC File Offset: 0x000107FC
			[DebuggerNonUserCode]
			public bool IsCategoryNameNull()
			{
				return base.IsNull(this.tableReportQuery1.CategoryNameColumn);
			}

			// Token: 0x0600017B RID: 379 RVA: 0x0001181F File Offset: 0x0001081F
			[DebuggerNonUserCode]
			public void SetCategoryNameNull()
			{
				base[this.tableReportQuery1.CategoryNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600017C RID: 380 RVA: 0x0001183C File Offset: 0x0001083C
			[DebuggerNonUserCode]
			public bool Is_C_Null()
			{
				return base.IsNull(this.tableReportQuery1._C_Column);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x0001185F File Offset: 0x0001085F
			[DebuggerNonUserCode]
			public void Set_C_Null()
			{
				base[this.tableReportQuery1._C_Column] = Convert.DBNull;
			}

			// Token: 0x0600017E RID: 382 RVA: 0x0001187C File Offset: 0x0001087C
			[DebuggerNonUserCode]
			public bool Is_C__Null()
			{
				return base.IsNull(this.tableReportQuery1._C__Column);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x0001189F File Offset: 0x0001089F
			[DebuggerNonUserCode]
			public void Set_C__Null()
			{
				base[this.tableReportQuery1._C__Column] = Convert.DBNull;
			}

			// Token: 0x06000180 RID: 384 RVA: 0x000118BC File Offset: 0x000108BC
			[DebuggerNonUserCode]
			public bool IsSQLNull()
			{
				return base.IsNull(this.tableReportQuery1.SQLColumn);
			}

			// Token: 0x06000181 RID: 385 RVA: 0x000118DF File Offset: 0x000108DF
			[DebuggerNonUserCode]
			public void SetSQLNull()
			{
				base[this.tableReportQuery1.SQLColumn] = Convert.DBNull;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x000118FC File Offset: 0x000108FC
			[DebuggerNonUserCode]
			public bool IsVB_NETNull()
			{
				return base.IsNull(this.tableReportQuery1.VB_NETColumn);
			}

			// Token: 0x06000183 RID: 387 RVA: 0x0001191F File Offset: 0x0001091F
			[DebuggerNonUserCode]
			public void SetVB_NETNull()
			{
				base[this.tableReportQuery1.VB_NETColumn] = Convert.DBNull;
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0001193C File Offset: 0x0001093C
			[DebuggerNonUserCode]
			public bool IsWeb_filesNull()
			{
				return base.IsNull(this.tableReportQuery1.Web_filesColumn);
			}

			// Token: 0x06000185 RID: 389 RVA: 0x0001195F File Offset: 0x0001095F
			[DebuggerNonUserCode]
			public void SetWeb_filesNull()
			{
				base[this.tableReportQuery1.Web_filesColumn] = Convert.DBNull;
			}

			// Token: 0x06000186 RID: 390 RVA: 0x0001197C File Offset: 0x0001097C
			[DebuggerNonUserCode]
			public bool IsXml_filesNull()
			{
				return base.IsNull(this.tableReportQuery1.Xml_filesColumn);
			}

			// Token: 0x06000187 RID: 391 RVA: 0x0001199F File Offset: 0x0001099F
			[DebuggerNonUserCode]
			public void SetXml_filesNull()
			{
				base[this.tableReportQuery1.Xml_filesColumn] = Convert.DBNull;
			}

			// Token: 0x04000113 RID: 275
			private CounterDataDataSet.ReportQuery1DataTable tableReportQuery1;
		}

		// Token: 0x0200001C RID: 28
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TotalLOCRow : DataRow
		{
			// Token: 0x06000188 RID: 392 RVA: 0x000119B9 File Offset: 0x000109B9
			[DebuggerNonUserCode]
			internal TotalLOCRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTotalLOC = (CounterDataDataSet.TotalLOCDataTable)base.Table;
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000189 RID: 393 RVA: 0x000119D8 File Offset: 0x000109D8
			// (set) Token: 0x0600018A RID: 394 RVA: 0x00011A20 File Offset: 0x00010A20
			[DebuggerNonUserCode]
			public string Total
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableTotalLOC.TotalColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Total' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC.TotalColumn] = value;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00011A38 File Offset: 0x00010A38
			// (set) Token: 0x0600018C RID: 396 RVA: 0x00011A80 File Offset: 0x00010A80
			[DebuggerNonUserCode]
			public int _C_
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC._C_Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C#' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC._C_Column] = value;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00011A9C File Offset: 0x00010A9C
			// (set) Token: 0x0600018E RID: 398 RVA: 0x00011AE4 File Offset: 0x00010AE4
			[DebuggerNonUserCode]
			public int _C__
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC._C__Column];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'C++' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC._C__Column] = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600018F RID: 399 RVA: 0x00011B00 File Offset: 0x00010B00
			// (set) Token: 0x06000190 RID: 400 RVA: 0x00011B48 File Offset: 0x00010B48
			[DebuggerNonUserCode]
			public int SQL
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC.SQLColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SQL' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC.SQLColumn] = value;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000191 RID: 401 RVA: 0x00011B64 File Offset: 0x00010B64
			// (set) Token: 0x06000192 RID: 402 RVA: 0x00011BAC File Offset: 0x00010BAC
			[DebuggerNonUserCode]
			public int VB_NET
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC.VB_NETColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'VB NET' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC.VB_NETColumn] = value;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000193 RID: 403 RVA: 0x00011BC8 File Offset: 0x00010BC8
			// (set) Token: 0x06000194 RID: 404 RVA: 0x00011C10 File Offset: 0x00010C10
			[DebuggerNonUserCode]
			public int Web_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC.Web_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Web files' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC.Web_filesColumn] = value;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000195 RID: 405 RVA: 0x00011C2C File Offset: 0x00010C2C
			// (set) Token: 0x06000196 RID: 406 RVA: 0x00011C74 File Offset: 0x00010C74
			[DebuggerNonUserCode]
			public int Xml_files
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tableTotalLOC.Xml_filesColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Xml files' in table 'TotalLOC' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tableTotalLOC.Xml_filesColumn] = value;
				}
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00011C90 File Offset: 0x00010C90
			[DebuggerNonUserCode]
			public bool IsTotalNull()
			{
				return base.IsNull(this.tableTotalLOC.TotalColumn);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00011CB3 File Offset: 0x00010CB3
			[DebuggerNonUserCode]
			public void SetTotalNull()
			{
				base[this.tableTotalLOC.TotalColumn] = Convert.DBNull;
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00011CD0 File Offset: 0x00010CD0
			[DebuggerNonUserCode]
			public bool Is_C_Null()
			{
				return base.IsNull(this.tableTotalLOC._C_Column);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00011CF3 File Offset: 0x00010CF3
			[DebuggerNonUserCode]
			public void Set_C_Null()
			{
				base[this.tableTotalLOC._C_Column] = Convert.DBNull;
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00011D10 File Offset: 0x00010D10
			[DebuggerNonUserCode]
			public bool Is_C__Null()
			{
				return base.IsNull(this.tableTotalLOC._C__Column);
			}

			// Token: 0x0600019C RID: 412 RVA: 0x00011D33 File Offset: 0x00010D33
			[DebuggerNonUserCode]
			public void Set_C__Null()
			{
				base[this.tableTotalLOC._C__Column] = Convert.DBNull;
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00011D50 File Offset: 0x00010D50
			[DebuggerNonUserCode]
			public bool IsSQLNull()
			{
				return base.IsNull(this.tableTotalLOC.SQLColumn);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00011D73 File Offset: 0x00010D73
			[DebuggerNonUserCode]
			public void SetSQLNull()
			{
				base[this.tableTotalLOC.SQLColumn] = Convert.DBNull;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00011D90 File Offset: 0x00010D90
			[DebuggerNonUserCode]
			public bool IsVB_NETNull()
			{
				return base.IsNull(this.tableTotalLOC.VB_NETColumn);
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00011DB3 File Offset: 0x00010DB3
			[DebuggerNonUserCode]
			public void SetVB_NETNull()
			{
				base[this.tableTotalLOC.VB_NETColumn] = Convert.DBNull;
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00011DD0 File Offset: 0x00010DD0
			[DebuggerNonUserCode]
			public bool IsWeb_filesNull()
			{
				return base.IsNull(this.tableTotalLOC.Web_filesColumn);
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x00011DF3 File Offset: 0x00010DF3
			[DebuggerNonUserCode]
			public void SetWeb_filesNull()
			{
				base[this.tableTotalLOC.Web_filesColumn] = Convert.DBNull;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00011E10 File Offset: 0x00010E10
			[DebuggerNonUserCode]
			public bool IsXml_filesNull()
			{
				return base.IsNull(this.tableTotalLOC.Xml_filesColumn);
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00011E33 File Offset: 0x00010E33
			[DebuggerNonUserCode]
			public void SetXml_filesNull()
			{
				base[this.tableTotalLOC.Xml_filesColumn] = Convert.DBNull;
			}

			// Token: 0x04000114 RID: 276
			private CounterDataDataSet.TotalLOCDataTable tableTotalLOC;
		}

		// Token: 0x0200001D RID: 29
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ByQtrByApplicationRowChangeEvent : EventArgs
		{
			// Token: 0x060001A5 RID: 421 RVA: 0x00011E4D File Offset: 0x00010E4D
			[DebuggerNonUserCode]
			public ByQtrByApplicationRowChangeEvent(CounterDataDataSet.ByQtrByApplicationRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x00011E68 File Offset: 0x00010E68
			[DebuggerNonUserCode]
			public CounterDataDataSet.ByQtrByApplicationRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x00011E80 File Offset: 0x00010E80
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000115 RID: 277
			private CounterDataDataSet.ByQtrByApplicationRow eventRow;

			// Token: 0x04000116 RID: 278
			private DataRowAction eventAction;
		}

		// Token: 0x0200001E RID: 30
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class ReportQuery1RowChangeEvent : EventArgs
		{
			// Token: 0x060001A8 RID: 424 RVA: 0x00011E98 File Offset: 0x00010E98
			[DebuggerNonUserCode]
			public ReportQuery1RowChangeEvent(CounterDataDataSet.ReportQuery1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060001A9 RID: 425 RVA: 0x00011EB4 File Offset: 0x00010EB4
			[DebuggerNonUserCode]
			public CounterDataDataSet.ReportQuery1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060001AA RID: 426 RVA: 0x00011ECC File Offset: 0x00010ECC
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000117 RID: 279
			private CounterDataDataSet.ReportQuery1Row eventRow;

			// Token: 0x04000118 RID: 280
			private DataRowAction eventAction;
		}

		// Token: 0x0200001F RID: 31
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TotalLOCRowChangeEvent : EventArgs
		{
			// Token: 0x060001AB RID: 427 RVA: 0x00011EE4 File Offset: 0x00010EE4
			[DebuggerNonUserCode]
			public TotalLOCRowChangeEvent(CounterDataDataSet.TotalLOCRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060001AC RID: 428 RVA: 0x00011F00 File Offset: 0x00010F00
			[DebuggerNonUserCode]
			public CounterDataDataSet.TotalLOCRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060001AD RID: 429 RVA: 0x00011F18 File Offset: 0x00010F18
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000119 RID: 281
			private CounterDataDataSet.TotalLOCRow eventRow;

			// Token: 0x0400011A RID: 282
			private DataRowAction eventAction;
		}
	}
}
