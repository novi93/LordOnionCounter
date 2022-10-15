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
	// Token: 0x02000022 RID: 34
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class TotalLOCTableAdapter : Component
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00012642 File Offset: 0x00011642
		[DebuggerNonUserCode]
		public TotalLOCTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00012658 File Offset: 0x00011658
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001268C File Offset: 0x0001168C
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000126C0 File Offset: 0x000116C0
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00012780 File Offset: 0x00011780
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000127B4 File Offset: 0x000117B4
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000127CC File Offset: 0x000117CC
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

		// Token: 0x060001CD RID: 461 RVA: 0x000127D8 File Offset: 0x000117D8
		[DebuggerNonUserCode]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "TotalLOC";
			dataTableMapping.ColumnMappings.Add("Total", "Total");
			dataTableMapping.ColumnMappings.Add("C#", "C#");
			dataTableMapping.ColumnMappings.Add("C++", "C++");
			dataTableMapping.ColumnMappings.Add("SQL", "SQL");
			dataTableMapping.ColumnMappings.Add("VB NET", "VB NET");
			dataTableMapping.ColumnMappings.Add("Web files", "Web files");
			dataTableMapping.ColumnMappings.Add("Xml files", "Xml files");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000128BB File Offset: 0x000118BB
		[DebuggerNonUserCode]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = "Data Source=RNOOEMDEVSQL03;Initial Catalog=LOC;Integrated Security=True";
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000128DC File Offset: 0x000118DC
		[DebuggerNonUserCode]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT Total, C#, [C++], SQL, [VB NET], [Web files], [Xml files] FROM dbo.TotalLOC";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001293C File Offset: 0x0001193C
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CounterDataDataSet.TotalLOCDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00012988 File Offset: 0x00011988
		[DebuggerNonUserCode]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual CounterDataDataSet.TotalLOCDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CounterDataDataSet.TotalLOCDataTable totalLOCDataTable = new CounterDataDataSet.TotalLOCDataTable();
			this.Adapter.Fill(totalLOCDataTable);
			return totalLOCDataTable;
		}

		// Token: 0x04000123 RID: 291
		private SqlDataAdapter _adapter;

		// Token: 0x04000124 RID: 292
		private SqlConnection _connection;

		// Token: 0x04000125 RID: 293
		private SqlCommand[] _commandCollection;

		// Token: 0x04000126 RID: 294
		private bool _clearBeforeFill;
	}
}
