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
	// Token: 0x02000021 RID: 33
	[HelpKeyword("vs.data.TableAdapter")]
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DataObject(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	public class ReportQuery1TableAdapter : Component
	{
		// Token: 0x060001BA RID: 442 RVA: 0x000122C2 File Offset: 0x000112C2
		[DebuggerNonUserCode]
		public ReportQuery1TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000122D8 File Offset: 0x000112D8
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0001230C File Offset: 0x0001130C
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00012340 File Offset: 0x00011340
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

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00012400 File Offset: 0x00011400
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00012434 File Offset: 0x00011434
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0001244C File Offset: 0x0001144C
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

		// Token: 0x060001C1 RID: 449 RVA: 0x00012458 File Offset: 0x00011458
		[DebuggerNonUserCode]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ReportQuery1";
			dataTableMapping.ColumnMappings.Add("CategoryName", "CategoryName");
			dataTableMapping.ColumnMappings.Add("C#", "C#");
			dataTableMapping.ColumnMappings.Add("C++", "C++");
			dataTableMapping.ColumnMappings.Add("SQL", "SQL");
			dataTableMapping.ColumnMappings.Add("VB NET", "VB NET");
			dataTableMapping.ColumnMappings.Add("Web files", "Web files");
			dataTableMapping.ColumnMappings.Add("Xml files", "Xml files");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001253B File Offset: 0x0001153B
		[DebuggerNonUserCode]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = "Data Source=RNOOEMDEVSQL03;Initial Catalog=LOC;Integrated Security=True";
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001255C File Offset: 0x0001155C
		[DebuggerNonUserCode]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT CategoryName, C#, [C++], SQL, [VB NET], [Web files], [Xml files] FROM dbo.ReportQuery1";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000125BC File Offset: 0x000115BC
		[DebuggerNonUserCode]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CounterDataDataSet.ReportQuery1DataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00012608 File Offset: 0x00011608
		[DebuggerNonUserCode]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual CounterDataDataSet.ReportQuery1DataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CounterDataDataSet.ReportQuery1DataTable reportQuery1DataTable = new CounterDataDataSet.ReportQuery1DataTable();
			this.Adapter.Fill(reportQuery1DataTable);
			return reportQuery1DataTable;
		}

		// Token: 0x0400011F RID: 287
		private SqlDataAdapter _adapter;

		// Token: 0x04000120 RID: 288
		private SqlConnection _connection;

		// Token: 0x04000121 RID: 289
		private SqlCommand[] _commandCollection;

		// Token: 0x04000122 RID: 290
		private bool _clearBeforeFill;
	}
}
