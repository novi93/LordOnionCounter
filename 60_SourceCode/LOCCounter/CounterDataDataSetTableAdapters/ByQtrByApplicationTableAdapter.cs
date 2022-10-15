using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MS.IT.LOC.UI.CounterDataDataSetTableAdapters
{
	// Token: 0x02000020 RID: 32
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	public class ByQtrByApplicationTableAdapter : Component
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00011F30 File Offset: 0x00010F30
		[DebuggerNonUserCode]
		public ByQtrByApplicationTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00011F44 File Offset: 0x00010F44
		[DebuggerNonUserCode]
		private SqlDataAdapter Adapter
		{
			get
			{
				if (this._adapter == null)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00011F78 File Offset: 0x00010F78
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00011FAC File Offset: 0x00010FAC
		[DebuggerNonUserCode]
		internal SqlConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				if (this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				if (this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				if (this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < this.CommandCollection.Length; i++)
				{
					if (this.CommandCollection[i] != null)
					{
						this.CommandCollection[i].Connection = value;
					}
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001206C File Offset: 0x0001106C
		[DebuggerNonUserCode]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				if (this._commandCollection == null)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000120A0 File Offset: 0x000110A0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000120B8 File Offset: 0x000110B8
		[DebuggerNonUserCode]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000120C4 File Offset: 0x000110C4
		[DebuggerNonUserCode]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ByQtrByApplication";
			dataTableMapping.ColumnMappings.Add("Quarter", "Quarter");
			dataTableMapping.ColumnMappings.Add("Application", "Application");
			dataTableMapping.ColumnMappings.Add("C#", "C#");
			dataTableMapping.ColumnMappings.Add("C++", "C++");
			dataTableMapping.ColumnMappings.Add("SQL", "SQL");
			dataTableMapping.ColumnMappings.Add("VB NET", "VB NET");
			dataTableMapping.ColumnMappings.Add("Web files", "Web files");
			dataTableMapping.ColumnMappings.Add("Xml files", "Xml files");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000121BD File Offset: 0x000111BD
		[DebuggerNonUserCode]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = "Data Source=RNOOEMDEVSQL03;Initial Catalog=LOC;Integrated Security=True";
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000121DC File Offset: 0x000111DC
		[DebuggerNonUserCode]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT Quarter, Application, C#, [C++], SQL, [VB NET], [Web files], [Xml files] FROM dbo.ByQtrByApplication";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001223C File Offset: 0x0001123C
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CounterDataDataSet.ByQtrByApplicationDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00012288 File Offset: 0x00011288
		[HelpKeyword("vs.data.TableAdapter")]
		[DebuggerNonUserCode]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual CounterDataDataSet.ByQtrByApplicationDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CounterDataDataSet.ByQtrByApplicationDataTable byQtrByApplicationDataTable = new CounterDataDataSet.ByQtrByApplicationDataTable();
			this.Adapter.Fill(byQtrByApplicationDataTable);
			return byQtrByApplicationDataTable;
		}

		// Token: 0x0400011B RID: 283
		private SqlDataAdapter _adapter;

		// Token: 0x0400011C RID: 284
		private SqlConnection _connection;

		// Token: 0x0400011D RID: 285
		private SqlCommand[] _commandCollection;

		// Token: 0x0400011E RID: 286
		private bool _clearBeforeFill;
	}
}
