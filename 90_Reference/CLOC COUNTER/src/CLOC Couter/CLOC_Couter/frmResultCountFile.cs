using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class frmResultCountFile : Form
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00009E5C File Offset: 0x0000805C
		public frmResultCountFile()
		{
			base.Load += this.frmResultCountFile_Load;
			base.Closed += this.frmResultCountFile_Closed;
			this.strfileName = "Config.xml";
			this.xmlFile = new XmlDocument();
			this.InitializeComponent();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000A945 File Offset: 0x00008B45
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000A94F File Offset: 0x00008B4F
		internal virtual BindingSource InformationBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000A958 File Offset: 0x00008B58
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000A962 File Offset: 0x00008B62
		internal virtual TextBox txtDesignLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000A96B File Offset: 0x00008B6B
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000A975 File Offset: 0x00008B75
		internal virtual TextBox txtTotalLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000A97E File Offset: 0x00008B7E
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000A988 File Offset: 0x00008B88
		internal virtual TextBox txtNewLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000A991 File Offset: 0x00008B91
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000A99B File Offset: 0x00008B9B
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000A9AE File Offset: 0x00008BAE
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000A9B7 File Offset: 0x00008BB7
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000A9C1 File Offset: 0x00008BC1
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000A9CA File Offset: 0x00008BCA
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000A9DD File Offset: 0x00008BDD
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		internal virtual ComboBox txtHeSo
		{
			[CompilerGenerated]
			get
			{
				return this._txtHeSo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtHeSo_SelectedIndexChanged);
				ComboBox txtHeSo = this._txtHeSo;
				if (txtHeSo != null)
				{
					txtHeSo.SelectedIndexChanged -= value2;
				}
				this._txtHeSo = value;
				txtHeSo = this._txtHeSo;
				if (txtHeSo != null)
				{
					txtHeSo.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000AA2B File Offset: 0x00008C2B
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000AA38 File Offset: 0x00008C38
		internal virtual Button btnExport
		{
			[CompilerGenerated]
			get
			{
				return this._btnExport;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnExport_Click);
				Button btnExport = this._btnExport;
				if (btnExport != null)
				{
					btnExport.Click -= value2;
				}
				this._btnExport = value;
				btnExport = this._btnExport;
				if (btnExport != null)
				{
					btnExport.Click += value2;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000AA7B File Offset: 0x00008C7B
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000AA85 File Offset: 0x00008C85
		internal virtual DataGridView grdResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000AA8E File Offset: 0x00008C8E
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000AA98 File Offset: 0x00008C98
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000AAAB File Offset: 0x00008CAB
		public string path { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000AABE File Offset: 0x00008CBE
		public string dataCountFile { get; set; }

		// Token: 0x0600011E RID: 286 RVA: 0x0000AAC7 File Offset: 0x00008CC7
		private void frmResultCountFile_Load(object sender, EventArgs e)
		{
			this.importCountFile(this.path, this.dataCountFile);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		public int ResultCountLOC
		{
			get
			{
				return Conversions.ToInteger(this.importCountFile(this.path, this.dataCountFile));
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000AB0C File Offset: 0x00008D0C
		private object importCountFile(string FileName, string CountFile)
		{
			checked
			{
				object result;
				try
				{
					List<string> list = File.ReadAllLines(FileName, Encoding.GetEncoding("shift-jis")).ToList<string>();
					List<information> list2 = new List<information>();
					List<information> list3 = new List<information>();
					int num = 0;
					int num2 = 0;
					int num3 = list.Count - 2;
					for (int i = 1; i <= num3; i++)
					{
						bool flag = false;
						string[] array = list[i].Split(new char[]
						{
							','
						});
						bool flag2 = CountFile.Length > 0;
						if (flag2)
						{
							string[] array2 = CountFile.Split(new char[]
							{
								','
							});
							ArrayList arrayList = new ArrayList();
							int num4 = array2.Length - 1;
							for (int j = 0; j <= num4; j++)
							{
								bool flag3 = !arrayList.Contains(array2[j]);
								if (flag3)
								{
									arrayList.Add(array2[j]);
								}
							}
							try
							{
								foreach (object value in arrayList)
								{
									string value2 = Conversions.ToString(value);
									bool flag4 = Strings.InStrRev(Strings.UCase(array[1]), Strings.UCase(value2), -1, CompareMethod.Binary) > 0;
									if (flag4)
									{
										list2.Add(new information
										{
											language = array[0],
											filename = array[1],
											blank = Conversion.Val(array[2]).ToString("N0"),
											comment = Conversion.Val(array[3]).ToString("N0"),
											code = Conversion.Val(array[4]).ToString("N0")
										});
										num = (int)Math.Round(unchecked((double)num + Conversions.ToDouble(Conversion.Val(array[4]).ToString("N0"))));
										flag = true;
										break;
									}
								}
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							bool flag5 = !flag;
							if (flag5)
							{
								list3.Add(new information
								{
									language = array[0],
									filename = array[1],
									blank = Conversion.Val(array[2]).ToString("N0"),
									comment = Conversion.Val(array[3]).ToString("N0"),
									code = Conversion.Val(array[4]).ToString("N0")
								});
								num2 = (int)Math.Round(unchecked((double)num2 + Conversions.ToDouble(Conversion.Val(array[4]).ToString("N0"))));
							}
						}
						else
						{
							list2.Add(new information
							{
								language = array[0],
								filename = array[1],
								blank = Conversion.Val(array[2]).ToString("N0"),
								comment = Conversion.Val(array[3]).ToString("N0"),
								code = Conversion.Val(array[4]).ToString("N0")
							});
							num2 = (int)Math.Round(unchecked((double)num2 + Conversions.ToDouble(Conversion.Val(array[4]).ToString("N0"))));
						}
					}
					bool flag6 = list3.Count > 0;
					if (flag6)
					{
						list2.AddRange(list3);
					}
					this.grdResult.DataSource = list2;
					DataGridView grdResult = this.grdResult;
					grdResult.RowHeadersVisible = false;
					grdResult.Columns[0].HeaderCell.Value = "Ngôn ngữ";
					grdResult.Columns[1].Width = 450;
					grdResult.Columns[1].HeaderCell.Value = "Tên tập tin";
					grdResult.Columns[2].HeaderCell.Value = "Dòng trống";
					grdResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					grdResult.Columns[3].HeaderCell.Value = "Dòng ghi chú";
					grdResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					grdResult.Columns[4].HeaderCell.Value = "Dòng tạo mới/chỉnh sửa";
					grdResult.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.txtHeSo.Text = Conversions.ToString(35);
					this.txtNewLOC.Text = num2.ToString("N0");
					this.txtDesignLOC.Text = num.ToString("N0");
					int num5 = (int)Math.Round(unchecked((double)num2 + Math.Round(0.35 * (double)num, 0, MidpointRounding.AwayFromZero)));
					this.txtTotalLOC.Text = num5.ToString("N0");
					result = num5;
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
				}
				return result;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000B06C File Offset: 0x0000926C
		private void txtHeSo_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.txtNewLOC.Text.Length != 0 & this.txtDesignLOC.Text.Length != 0;
			int num;
			if (flag)
			{
				num = checked((int)Math.Round(unchecked(Conversions.ToDouble(this.txtNewLOC.Text) + Math.Round(Conversions.ToDouble(this.txtDesignLOC.Text) * (Conversions.ToDouble(this.txtHeSo.Text) / 100.0), 0, MidpointRounding.AwayFromZero))));
			}
			this.txtTotalLOC.Text = num.ToString("N0");
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000B10C File Offset: 0x0000930C
		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "\\LOCCounter" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					Common.ExportToExcel(this.grdResult, folderBrowserDialog.SelectedPath + text);
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox("Export thành công", MsgBoxStyle.OkOnly, null);
					Process.Start("Excel.exe", "\"" + folderBrowserDialog.SelectedPath + text + "\"");
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Export thất bại", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000B1D4 File Offset: 0x000093D4
		private void frmResultCountFile_Closed(object sender, EventArgs e)
		{
			Common.DeleteDirectory(Path.GetTempPath() + "CLOC");
		}

		// Token: 0x04000074 RID: 116
		private string strfileName;

		// Token: 0x04000075 RID: 117
		private XmlDocument xmlFile;
	}
}
