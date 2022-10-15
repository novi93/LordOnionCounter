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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class frmResultDiff : Form
	{
		// Token: 0x06000124 RID: 292 RVA: 0x0000B1EC File Offset: 0x000093EC
		public frmResultDiff()
		{
			base.Load += this.frmResultDiff_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000C2CA File Offset: 0x0000A4CA
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		internal virtual BindingSource CompareFileBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000C2DD File Offset: 0x0000A4DD
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000C2E7 File Offset: 0x0000A4E7
		internal virtual BindingSource ViewTableLOCBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000C2FA File Offset: 0x0000A4FA
		internal virtual BindingSource CompareFileBindingSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000C303 File Offset: 0x0000A503
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000C30D File Offset: 0x0000A50D
		internal virtual DataGridViewTextBoxColumn FilenameDataGridViewTextBoxColumn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000C316 File Offset: 0x0000A516
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000C320 File Offset: 0x0000A520
		internal virtual DataGridViewTextBoxColumn BaseLocDataGridViewTextBoxColumn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000C329 File Offset: 0x0000A529
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000C333 File Offset: 0x0000A533
		internal virtual DataGridViewTextBoxColumn CreateEditDataGridViewTextBoxColumn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000C33C File Offset: 0x0000A53C
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000C346 File Offset: 0x0000A546
		internal virtual DataGridViewTextBoxColumn RemovedDataGridViewTextBoxColumn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000C34F File Offset: 0x0000A54F
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000C359 File Offset: 0x0000A559
		internal virtual BindingSource CompareFileBindingSource2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000C362 File Offset: 0x0000A562
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000C36C File Offset: 0x0000A56C
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C375 File Offset: 0x0000A575
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000C380 File Offset: 0x0000A580
		internal virtual ComboBox txtHeSodiff
		{
			[CompilerGenerated]
			get
			{
				return this._txtHeSodiff;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtHeSoBase_SelectedIndexChanged);
				ComboBox txtHeSodiff = this._txtHeSodiff;
				if (txtHeSodiff != null)
				{
					txtHeSodiff.SelectedIndexChanged -= value2;
				}
				this._txtHeSodiff = value;
				txtHeSodiff = this._txtHeSodiff;
				if (txtHeSodiff != null)
				{
					txtHeSodiff.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000C3CD File Offset: 0x0000A5CD
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C3D6 File Offset: 0x0000A5D6
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		internal virtual TextBox txtDesignLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000C3E9 File Offset: 0x0000A5E9
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000C3F3 File Offset: 0x0000A5F3
		internal virtual TextBox txtNewEditLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000C406 File Offset: 0x0000A606
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000C40F File Offset: 0x0000A60F
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000C419 File Offset: 0x0000A619
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000C422 File Offset: 0x0000A622
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000C42C File Offset: 0x0000A62C
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000C435 File Offset: 0x0000A635
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000C43F File Offset: 0x0000A63F
		internal virtual TextBox txtTotalNewEditLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000C448 File Offset: 0x0000A648
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000C454 File Offset: 0x0000A654
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000C497 File Offset: 0x0000A697
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000C4AA File Offset: 0x0000A6AA
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000C4BD File Offset: 0x0000A6BD
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
		internal virtual TextBox txtTotalBaseLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000C4DA File Offset: 0x0000A6DA
		internal virtual TextBox txtBaseDesign { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000C4E3 File Offset: 0x0000A6E3
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000C4ED File Offset: 0x0000A6ED
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000C4F6 File Offset: 0x0000A6F6
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000C500 File Offset: 0x0000A700
		internal virtual TextBox txtBaseLOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000C509 File Offset: 0x0000A709
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000C513 File Offset: 0x0000A713
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000C51C File Offset: 0x0000A71C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000C526 File Offset: 0x0000A726
		internal virtual DataGridView grdResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000C52F File Offset: 0x0000A72F
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000C539 File Offset: 0x0000A739
		public string path { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000C542 File Offset: 0x0000A742
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000C54C File Offset: 0x0000A74C
		public string dataDesign { get; set; }

		// Token: 0x0600015F RID: 351 RVA: 0x0000C555 File Offset: 0x0000A755
		private void frmResultDiff_Load(object sender, EventArgs e)
		{
			this.importDiff(this.path, this.dataDesign);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000C56C File Offset: 0x0000A76C
		private void importDiff(string FileName, string dataDesign)
		{
			checked
			{
				try
				{
					List<string> list = File.ReadAllLines(FileName, Encoding.GetEncoding("shift-jis")).ToList<string>();
					List<CompareFile> list2 = new List<CompareFile>();
					List<CompareFile> list3 = new List<CompareFile>();
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					int num5 = list.Count - 1;
					for (int i = 1; i <= num5; i++)
					{
						string[] array = list[i].Split(new char[]
						{
							','
						});
						bool flag = dataDesign.Length > 0;
						if (flag)
						{
							bool flag2 = false;
							string[] array2 = dataDesign.Split(new char[]
							{
								','
							});
							ArrayList arrayList = new ArrayList();
							int num6 = array2.Length - 1;
							for (int j = 0; j <= num6; j++)
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
									bool flag4 = Strings.InStrRev(Strings.UCase(array[0]), Strings.UCase(value2), -1, CompareMethod.Binary) != 0;
									if (flag4)
									{
										list2.Add(unchecked(new CompareFile
										{
											Filename = array[0],
											Base = (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12])).ToString("N0"),
											Create_Edit = (Conversion.Val(array[10]) + Conversion.Val(array[11])).ToString("N0"),
											Removed = Conversion.Val(array[12]).ToString("N0")
										}));
										num3 = (int)Math.Round(unchecked((double)num3 + (Conversion.Val(array[10]) + Conversion.Val(array[11]))));
										num4 = (int)Math.Round(unchecked((double)num4 + (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12]))));
										flag2 = true;
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
							bool flag5 = !flag2;
							if (flag5)
							{
								num = (int)Math.Round(unchecked((double)num + (Conversion.Val(array[10]) + Conversion.Val(array[11]))));
								num2 = (int)Math.Round(unchecked((double)num2 + (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12]))));
								list3.Add(unchecked(new CompareFile
								{
									Filename = array[0],
									Base = (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12])).ToString("N0"),
									Create_Edit = (Conversion.Val(array[10]) + Conversion.Val(array[11])).ToString("N0"),
									Removed = Conversion.Val(array[12]).ToString("N0")
								}));
							}
						}
						else
						{
							num = (int)Math.Round(unchecked((double)num + (Conversion.Val(array[10]) + Conversion.Val(array[11]))));
							num2 = (int)Math.Round(unchecked((double)num2 + (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12]))));
							list2.Add(unchecked(new CompareFile
							{
								Filename = array[0],
								Base = (Conversion.Val(array[9]) + Conversion.Val(array[10]) + Conversion.Val(array[12])).ToString("N0"),
								Create_Edit = (Conversion.Val(array[10]) + Conversion.Val(array[11])).ToString("N0"),
								Removed = Conversion.Val(array[12]).ToString("N0")
							}));
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
					grdResult.Columns[0].Width = 570;
					grdResult.Columns[0].HeaderCell.Value = "Tên tập tin";
					grdResult.Columns[1].HeaderCell.Value = "LOC mẫu";
					grdResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					grdResult.Columns[2].HeaderCell.Value = "LOC tạo mới/chỉnh sửa";
					grdResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					grdResult.Columns[3].HeaderCell.Value = "LOC xóa";
					grdResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					this.txtNewEditLOC.Text = num.ToString("N0");
					this.txtDesignLOC.Text = num3.ToString("N0");
					int num7 = (int)Math.Round(unchecked((double)num + Math.Round((double)num3 * 0.35, 0, MidpointRounding.AwayFromZero)));
					this.txtTotalNewEditLoc.Text = num7.ToString("N0");
					this.txtBaseLOC.Text = num2.ToString("N0");
					this.txtBaseDesign.Text = num4.ToString("N0");
					int num8 = (int)Math.Round(unchecked((double)num2 + Math.Round((double)num4 * 0.35, 0, MidpointRounding.AwayFromZero)));
					this.txtTotalBaseLoc.Text = num8.ToString("N0");
					this.txtHeSodiff.Text = Conversions.ToString(35);
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		private void txtHeSoBase_SelectedIndexChanged(object sender, EventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(unchecked(Conversions.ToDouble(this.txtBaseLOC.Text) + Math.Round(Conversions.ToDouble(this.txtHeSodiff.Text) / 100.0 * Conversions.ToDouble(this.txtBaseDesign.Text), 0, MidpointRounding.AwayFromZero)));
				bool flag = num == 0;
				if (flag)
				{
					this.txtTotalBaseLoc.Text = Conversions.ToString(0);
				}
				else
				{
					this.txtTotalBaseLoc.Text = num.ToString("N0");
				}
				int num2 = (int)Math.Round(unchecked(Conversions.ToDouble(this.txtNewEditLOC.Text) + Math.Round(Conversions.ToDouble(this.txtHeSodiff.Text) / 100.0 * Conversions.ToDouble(this.txtDesignLOC.Text), 0, MidpointRounding.AwayFromZero)));
				bool flag2 = num2 == 0;
				if (flag2)
				{
					this.txtTotalNewEditLoc.Text = Conversions.ToString(0);
				}
				else
				{
					this.txtTotalNewEditLoc.Text = num2.ToString("N0");
				}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000CCD8 File Offset: 0x0000AED8
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
	}
}
