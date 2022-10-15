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
using System.Xml.Linq;
using CLOC_Couter.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SharpSvn.UI;

namespace CLOC_Couter
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class frmCounterLOC : Form
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public frmCounterLOC()
		{
			base.Load += this.frmCounterLOC_Load;
			base.FormClosed += delegate(object a0, FormClosedEventArgs a1)
			{
				this.Form_Closed();
			};
			this.strfileName = "Config.xml";
			this.strRuleCounter = "RuleCounter.txt";
			this.strPathHead = "Head";
			this.xmlFile = new XmlDocument();
			this.InitializeComponent();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004F95 File Offset: 0x00003195
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004FA0 File Offset: 0x000031A0
		internal virtual Button btnCount
		{
			[CompilerGenerated]
			get
			{
				return this._btnCount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCount_Click);
				Button btnCount = this._btnCount;
				if (btnCount != null)
				{
					btnCount.Click -= value2;
				}
				this._btnCount = value;
				btnCount = this._btnCount;
				if (btnCount != null)
				{
					btnCount.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004FE3 File Offset: 0x000031E3
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00004FED File Offset: 0x000031ED
		internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004FF6 File Offset: 0x000031F6
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00005000 File Offset: 0x00003200
		internal virtual RadioButton optSVN
		{
			[CompilerGenerated]
			get
			{
				return this._optSVN;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.optSVN_CheckedChanged);
				RadioButton optSVN = this._optSVN;
				if (optSVN != null)
				{
					optSVN.CheckedChanged -= value2;
				}
				this._optSVN = value;
				optSVN = this._optSVN;
				if (optSVN != null)
				{
					optSVN.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005043 File Offset: 0x00003243
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00005050 File Offset: 0x00003250
		internal virtual RadioButton optFileSystem
		{
			[CompilerGenerated]
			get
			{
				return this._optFileSystem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.optFileSystem_CheckedChanged);
				RadioButton optFileSystem = this._optFileSystem;
				if (optFileSystem != null)
				{
					optFileSystem.CheckedChanged -= value2;
				}
				this._optFileSystem = value;
				optFileSystem = this._optFileSystem;
				if (optFileSystem != null)
				{
					optFileSystem.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005093 File Offset: 0x00003293
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000509D File Offset: 0x0000329D
		internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000050A6 File Offset: 0x000032A6
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000050B0 File Offset: 0x000032B0
		internal virtual ComboBox cboTypeSource
		{
			[CompilerGenerated]
			get
			{
				return this._cboTypeSource;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cboTypeSource_SelectedIndexChanged);
				ComboBox cboTypeSource = this._cboTypeSource;
				if (cboTypeSource != null)
				{
					cboTypeSource.SelectedIndexChanged -= value2;
				}
				this._cboTypeSource = value;
				cboTypeSource = this._cboTypeSource;
				if (cboTypeSource != null)
				{
					cboTypeSource.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000050F3 File Offset: 0x000032F3
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000050FD File Offset: 0x000032FD
		internal virtual GroupBox Design { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005106 File Offset: 0x00003306
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005110 File Offset: 0x00003310
		internal virtual CheckedListBox txtDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005119 File Offset: 0x00003319
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005124 File Offset: 0x00003324
		internal virtual Button btnAddDes
		{
			[CompilerGenerated]
			get
			{
				return this._btnAddDes;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AddDesign);
				Button btnAddDes = this._btnAddDes;
				if (btnAddDes != null)
				{
					btnAddDes.Click -= value2;
				}
				this._btnAddDes = value;
				btnAddDes = this._btnAddDes;
				if (btnAddDes != null)
				{
					btnAddDes.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005167 File Offset: 0x00003367
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005171 File Offset: 0x00003371
		internal virtual TextBox txtAddDes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000517A File Offset: 0x0000337A
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005184 File Offset: 0x00003384
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000518D File Offset: 0x0000338D
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005197 File Offset: 0x00003397
		internal virtual CheckedListBox txtExt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000051A0 File Offset: 0x000033A0
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000051AA File Offset: 0x000033AA
		internal virtual TextBox txtAddExt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000051B3 File Offset: 0x000033B3
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000051C0 File Offset: 0x000033C0
		internal virtual Button btnAddExt
		{
			[CompilerGenerated]
			get
			{
				return this._btnAddExt;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAddExt_Click);
				Button btnAddExt = this._btnAddExt;
				if (btnAddExt != null)
				{
					btnAddExt.Click -= value2;
				}
				this._btnAddExt = value;
				btnAddExt = this._btnAddExt;
				if (btnAddExt != null)
				{
					btnAddExt.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005203 File Offset: 0x00003403
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000520D File Offset: 0x0000340D
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005216 File Offset: 0x00003416
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005220 File Offset: 0x00003420
		internal virtual CheckBox chkCodeAuto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005229 File Offset: 0x00003429
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005234 File Offset: 0x00003434
		internal virtual RadioButton optListCounter
		{
			[CompilerGenerated]
			get
			{
				return this._optListCounter;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.optListCounter_CheckedChanged);
				RadioButton optListCounter = this._optListCounter;
				if (optListCounter != null)
				{
					optListCounter.CheckedChanged -= value2;
				}
				this._optListCounter = value;
				optListCounter = this._optListCounter;
				if (optListCounter != null)
				{
					optListCounter.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005277 File Offset: 0x00003477
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00005284 File Offset: 0x00003484
		internal virtual Button btnSelectFolderFile
		{
			[CompilerGenerated]
			get
			{
				return this._btnSelectFolderFile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnSelectFolderFile_Click);
				Button btnSelectFolderFile = this._btnSelectFolderFile;
				if (btnSelectFolderFile != null)
				{
					btnSelectFolderFile.Click -= value2;
				}
				this._btnSelectFolderFile = value;
				btnSelectFolderFile = this._btnSelectFolderFile;
				if (btnSelectFolderFile != null)
				{
					btnSelectFolderFile.Click += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000052C7 File Offset: 0x000034C7
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000052D4 File Offset: 0x000034D4
		internal virtual RadioButton optDiff
		{
			[CompilerGenerated]
			get
			{
				return this._optDiff;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.optDiff_CheckedChanged);
				RadioButton optDiff = this._optDiff;
				if (optDiff != null)
				{
					optDiff.CheckedChanged -= value2;
				}
				this._optDiff = value;
				optDiff = this._optDiff;
				if (optDiff != null)
				{
					optDiff.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00005317 File Offset: 0x00003517
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00005321 File Offset: 0x00003521
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000532A File Offset: 0x0000352A
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005334 File Offset: 0x00003534
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000533D File Offset: 0x0000353D
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00005347 File Offset: 0x00003547
		internal virtual TextBox txtBasefolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00005350 File Offset: 0x00003550
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000535C File Offset: 0x0000355C
		internal virtual TextBox txtDifffolder
		{
			[CompilerGenerated]
			get
			{
				return this._txtDifffolder;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDifffolder_TextChanged);
				TextBox txtDifffolder = this._txtDifffolder;
				if (txtDifffolder != null)
				{
					txtDifffolder.TextChanged -= value2;
				}
				this._txtDifffolder = value;
				txtDifffolder = this._txtDifffolder;
				if (txtDifffolder != null)
				{
					txtDifffolder.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000539F File Offset: 0x0000359F
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000053AC File Offset: 0x000035AC
		internal virtual Button btnBase
		{
			[CompilerGenerated]
			get
			{
				return this._btnBase;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnBase_Click);
				Button btnBase = this._btnBase;
				if (btnBase != null)
				{
					btnBase.Click -= value2;
				}
				this._btnBase = value;
				btnBase = this._btnBase;
				if (btnBase != null)
				{
					btnBase.Click += value2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000053EF File Offset: 0x000035EF
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000053FC File Offset: 0x000035FC
		internal virtual Button btndiff
		{
			[CompilerGenerated]
			get
			{
				return this._btndiff;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btndiff_Click);
				Button btndiff = this._btndiff;
				if (btndiff != null)
				{
					btndiff.Click -= value2;
				}
				this._btndiff = value;
				btndiff = this._btndiff;
				if (btndiff != null)
				{
					btndiff.Click += value2;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000543F File Offset: 0x0000363F
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0000544C File Offset: 0x0000364C
		internal virtual Button btnDelete
		{
			[CompilerGenerated]
			get
			{
				return this._btnDelete;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDelete_Click);
				Button btnDelete = this._btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click -= value2;
				}
				this._btnDelete = value;
				btnDelete = this._btnDelete;
				if (btnDelete != null)
				{
					btnDelete.Click += value2;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000548F File Offset: 0x0000368F
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000549C File Offset: 0x0000369C
		internal virtual ListBox lstFolderFile
		{
			[CompilerGenerated]
			get
			{
				return this._lstFolderFile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.lstFolderFile_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.lstFolderFile_DragEnter);
				ListBox lstFolderFile = this._lstFolderFile;
				if (lstFolderFile != null)
				{
					lstFolderFile.DragDrop -= value2;
					lstFolderFile.DragEnter -= value3;
				}
				this._lstFolderFile = value;
				lstFolderFile = this._lstFolderFile;
				if (lstFolderFile != null)
				{
					lstFolderFile.DragDrop += value2;
					lstFolderFile.DragEnter += value3;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000054FA File Offset: 0x000036FA
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00005504 File Offset: 0x00003704
		internal virtual ListBox lstFileDiff { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000550D File Offset: 0x0000370D
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005518 File Offset: 0x00003718
		internal virtual Button btnFile
		{
			[CompilerGenerated]
			get
			{
				return this._btnFile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnFile_Click);
				Button btnFile = this._btnFile;
				if (btnFile != null)
				{
					btnFile.Click -= value2;
				}
				this._btnFile = value;
				btnFile = this._btnFile;
				if (btnFile != null)
				{
					btnFile.Click += value2;
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000555B File Offset: 0x0000375B
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00005568 File Offset: 0x00003768
		internal virtual CheckBox chkDiff
		{
			[CompilerGenerated]
			get
			{
				return this._chkDiff;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkDiff_CheckedChanged);
				CheckBox chkDiff = this._chkDiff;
				if (chkDiff != null)
				{
					chkDiff.CheckedChanged -= value2;
				}
				this._chkDiff = value;
				chkDiff = this._chkDiff;
				if (chkDiff != null)
				{
					chkDiff.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000055AB File Offset: 0x000037AB
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000055B8 File Offset: 0x000037B8
		internal virtual Button btnDeleteFile
		{
			[CompilerGenerated]
			get
			{
				return this._btnDeleteFile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDeleteFile_Click);
				Button btnDeleteFile = this._btnDeleteFile;
				if (btnDeleteFile != null)
				{
					btnDeleteFile.Click -= value2;
				}
				this._btnDeleteFile = value;
				btnDeleteFile = this._btnDeleteFile;
				if (btnDeleteFile != null)
				{
					btnDeleteFile.Click += value2;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000055FB File Offset: 0x000037FB
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00005605 File Offset: 0x00003805
		internal virtual Label lblRepository { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000560E File Offset: 0x0000380E
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00005618 File Offset: 0x00003818
		internal virtual TextBox txtRepository
		{
			[CompilerGenerated]
			get
			{
				return this._txtRepository;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = delegate(object a0, EventArgs a1)
				{
					this.txtRepository_TextChanged();
				};
				EventHandler value3 = new EventHandler(this.txtRepository_LostFocus);
				TextBox txtRepository = this._txtRepository;
				if (txtRepository != null)
				{
					txtRepository.TextChanged -= value2;
					txtRepository.LostFocus -= value3;
				}
				this._txtRepository = value;
				txtRepository = this._txtRepository;
				if (txtRepository != null)
				{
					txtRepository.TextChanged += value2;
					txtRepository.LostFocus += value3;
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005676 File Offset: 0x00003876
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005680 File Offset: 0x00003880
		internal virtual RadioButton optDiffVersion
		{
			[CompilerGenerated]
			get
			{
				return this._optDiffVersion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.optDiffVersion_CheckedChanged);
				RadioButton optDiffVersion = this._optDiffVersion;
				if (optDiffVersion != null)
				{
					optDiffVersion.CheckedChanged -= value2;
				}
				this._optDiffVersion = value;
				optDiffVersion = this._optDiffVersion;
				if (optDiffVersion != null)
				{
					optDiffVersion.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000056C3 File Offset: 0x000038C3
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000056CD File Offset: 0x000038CD
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000056D6 File Offset: 0x000038D6
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000056E0 File Offset: 0x000038E0
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000056E9 File Offset: 0x000038E9
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000056F4 File Offset: 0x000038F4
		internal virtual TextBox txtBase
		{
			[CompilerGenerated]
			get
			{
				return this._txtBase;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBase_LostFocus);
				TextBox txtBase = this._txtBase;
				if (txtBase != null)
				{
					txtBase.LostFocus -= value2;
				}
				this._txtBase = value;
				txtBase = this._txtBase;
				if (txtBase != null)
				{
					txtBase.LostFocus += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005737 File Offset: 0x00003937
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005744 File Offset: 0x00003944
		internal virtual TextBox txtDiff
		{
			[CompilerGenerated]
			get
			{
				return this._txtDiff;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDiff_LostFocus);
				TextBox txtDiff = this._txtDiff;
				if (txtDiff != null)
				{
					txtDiff.LostFocus -= value2;
				}
				this._txtDiff = value;
				txtDiff = this._txtDiff;
				if (txtDiff != null)
				{
					txtDiff.LostFocus += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005787 File Offset: 0x00003987
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00005794 File Offset: 0x00003994
		internal virtual CheckBox chkHead
		{
			[CompilerGenerated]
			get
			{
				return this._chkHead;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkHead_CheckedChanged);
				CheckBox chkHead = this._chkHead;
				if (chkHead != null)
				{
					chkHead.CheckedChanged -= value2;
				}
				this._chkHead = value;
				chkHead = this._chkHead;
				if (chkHead != null)
				{
					chkHead.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000057D7 File Offset: 0x000039D7
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000057E1 File Offset: 0x000039E1
		internal virtual Label lblpathfile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000057EA File Offset: 0x000039EA
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000057F4 File Offset: 0x000039F4
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000057FD File Offset: 0x000039FD
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00005808 File Offset: 0x00003A08
		internal virtual Button btnRefVersion
		{
			[CompilerGenerated]
			get
			{
				return this._btnRefVersion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnRefVersion_Click);
				Button btnRefVersion = this._btnRefVersion;
				if (btnRefVersion != null)
				{
					btnRefVersion.Click -= value2;
				}
				this._btnRefVersion = value;
				btnRefVersion = this._btnRefVersion;
				if (btnRefVersion != null)
				{
					btnRefVersion.Click += value2;
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000584B File Offset: 0x00003A4B
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00005855 File Offset: 0x00003A55
		public string pathFileConnect { get; set; }

		// Token: 0x06000086 RID: 134 RVA: 0x00005860 File Offset: 0x00003A60
		private void enableoptFilesystem(bool check)
		{
			this.optListCounter.Enabled = check;
			this.optListCounter.Checked = check;
			this.optDiff.Enabled = check;
			this.optDiffVersion.Enabled = !check;
			this.cboTypeSource.Text = "";
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000058B8 File Offset: 0x00003AB8
		private void enableoptSVN(bool check)
		{
			this.lblpathfile.Text = "";
			this.optListCounter.Enabled = check;
			this.optListCounter.Checked = check;
			this.txtRepository.Enabled = check;
			this.optDiff.Enabled = !check;
			this.optDiffVersion.Enabled = check;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000591C File Offset: 0x00003B1C
		private void ReadFileSource(bool checkFile)
		{
			this.xmlFile.Load(this.strfileName);
			XmlNodeList xmlNodeList = this.xmlFile.DocumentElement.SelectNodes("/class/source/information");
			object objectValue = RuntimeHelpers.GetObjectValue(new object());
			try
			{
				try
				{
					foreach (object obj in xmlNodeList)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string innerText = xmlNode.SelectSingleNode("NameInfo").InnerText;
						if (checkFile)
						{
							innerText = xmlNode.SelectSingleNode("NameInfo").InnerText;
							this.cboTypeSource.Items.Add(innerText);
						}
						else
						{
							bool flag = Operators.ConditionalCompareObjectEqual(this.cboTypeSource.SelectedItem, xmlNode.SelectSingleNode("NameInfo").InnerText, false);
							if (flag)
							{
								bool @checked = this.optFileSystem.Checked;
								if (@checked)
								{
									bool flag2 = Conversions.ToDouble(xmlNode.SelectSingleNode("keyInfo").InnerText) == 0.0;
									if (flag2)
									{
										this.optListCounter.Enabled = true;
										this.optListCounter.Checked = true;
										this.optDiff.Enabled = false;
									}
									else
									{
										bool flag3 = Conversions.ToDouble(xmlNode.SelectSingleNode("keyInfo").InnerText) == 1.0;
										if (flag3)
										{
											this.optDiff.Enabled = true;
											this.optDiff.Checked = true;
											this.optListCounter.Enabled = false;
										}
										else
										{
											this.optListCounter.Enabled = true;
											this.optListCounter.Checked = true;
											this.optDiff.Enabled = true;
										}
									}
									break;
								}
								bool checked2 = this.optSVN.Checked;
								if (checked2)
								{
									bool flag4 = Conversions.ToDouble(xmlNode.SelectSingleNode("keyInfo").InnerText) == 0.0;
									if (flag4)
									{
										this.optListCounter.Enabled = true;
										this.optListCounter.Checked = true;
										this.optDiffVersion.Enabled = false;
									}
									else
									{
										bool flag5 = Conversions.ToDouble(xmlNode.SelectSingleNode("keyInfo").InnerText) == 1.0;
										if (flag5)
										{
											this.optDiffVersion.Enabled = true;
											this.optDiffVersion.Checked = true;
											this.optListCounter.Enabled = false;
										}
										else
										{
											this.optListCounter.Enabled = true;
											this.optListCounter.Checked = true;
											this.optDiffVersion.Enabled = true;
										}
									}
									break;
								}
							}
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
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005C34 File Offset: 0x00003E34
		private object ReadFileXml(string name)
		{
			this.xmlFile.Load(this.strfileName);
			object result;
			try
			{
				bool flag = Operators.CompareString(name, "Config", false) == 0;
				if (flag)
				{
					XmlNodeList xmlNodeList = this.xmlFile.DocumentElement.SelectNodes("/class/config");
					string text = "";
					try
					{
						foreach (object obj in xmlNodeList)
						{
							XmlNode xmlNode = (XmlNode)obj;
							text = xmlNode.SelectSingleNode("configName").InnerText;
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
					result = text;
				}
				else
				{
					bool flag2 = Operators.CompareString(name, "NotCodeAuto", false) == 0;
					if (flag2)
					{
						XmlNodeList xmlNodeList2 = this.xmlFile.DocumentElement.SelectNodes("/class/codeAuto");
						string text2 = "";
						try
						{
							foreach (object obj2 in xmlNodeList2)
							{
								XmlNode xmlNode2 = (XmlNode)obj2;
								text2 = xmlNode2.SelectSingleNode("codeName").InnerText;
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						result = text2;
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005DD8 File Offset: 0x00003FD8
		private bool Docfile(bool txtcheck)
		{
			this.xmlFile.Load(this.strfileName);
			try
			{
				if (txtcheck)
				{
					XmlNodeList xmlNodeList = this.xmlFile.DocumentElement.SelectNodes("/class/extension/ext");
					try
					{
						foreach (object obj in xmlNodeList)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string innerText = xmlNode.SelectSingleNode("extName").InnerText;
							this.txtExt.Items.Add(innerText);
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
				}
				else
				{
					bool flag = !txtcheck;
					if (flag)
					{
						XmlNodeList xmlNodeList2 = this.xmlFile.DocumentElement.SelectNodes("/class/design/des");
						try
						{
							foreach (object obj2 in xmlNodeList2)
							{
								XmlNode xmlNode2 = (XmlNode)obj2;
								string innerText2 = xmlNode2.SelectSingleNode("desName").InnerText;
								this.txtDes.Items.Add(innerText2);
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005F80 File Offset: 0x00004180
		private bool Ghifile(bool checkWrite)
		{
			XDocument xdocument = XDocument.Load(this.strfileName);
			int num = 0;
			checked
			{
				try
				{
					if (checkWrite)
					{
						XElement content = new XElement("ext", new XElement("extName", this.txtAddExt.Text));
						xdocument.Element("class").Element("extension").Add(content);
						bool flag = this.txtExt.Items.Count > 0;
						if (flag)
						{
							try
							{
								foreach (object value in this.txtExt.Items)
								{
									string str = Conversions.ToString(value);
									bool flag2 = Operators.CompareString(Strings.StrConv(this.txtAddExt.Text, VbStrConv.Lowercase, 0), Strings.StrConv(str, VbStrConv.Lowercase, 0), false) == 0;
									if (flag2)
									{
										num++;
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
							bool flag3 = num > 0;
							if (flag3)
							{
								Interaction.MsgBox("Dữ liệu đã tồn tại", MsgBoxStyle.OkOnly, null);
								num = 0;
							}
							else
							{
								xdocument.Save(this.strfileName);
							}
						}
						else
						{
							xdocument.Save(this.strfileName);
						}
						this.txtAddExt.Text = "";
					}
					else
					{
						XElement content2 = new XElement("des", new XElement("desName", this.txtAddDes.Text));
						xdocument.Element("class").Element("design").Add(content2);
						bool flag4 = this.txtDes.Items.Count > 0;
						if (flag4)
						{
							try
							{
								foreach (object value2 in this.txtDes.Items)
								{
									string str2 = Conversions.ToString(value2);
									bool flag5 = Operators.CompareString(Strings.StrConv(this.txtAddDes.Text, VbStrConv.Lowercase, 0), Strings.StrConv(str2, VbStrConv.Lowercase, 0), false) == 0;
									if (flag5)
									{
										num++;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							bool flag6 = num > 0;
							if (flag6)
							{
								Interaction.MsgBox("Dữ liệu đã tồn tại", MsgBoxStyle.OkOnly, null);
								num = 0;
							}
							else
							{
								xdocument.Save(this.strfileName);
							}
						}
						else
						{
							xdocument.Save(this.strfileName);
						}
						this.txtAddDes.Text = "";
					}
				}
				catch (Exception ex)
				{
					return false;
				}
				return true;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006294 File Offset: 0x00004494
		private void frmCounterLOC_Load(object sender, EventArgs e)
		{
			this.lstFileDiff.BackColor = Color.WhiteSmoke;
			this.pathtemp = Path.GetTempPath() + "CLOC";
			bool flag = !Directory.Exists(this.pathtemp);
			if (flag)
			{
				Directory.CreateDirectory(this.pathtemp);
			}
			string path = this.pathtemp + "\\cloc.exe";
			using (FileStream fileStream = new FileStream(path, FileMode.Create))
			{
				fileStream.Write(Resources.cloc, 0, Resources.cloc.Length);
			}
			string path2 = this.pathtemp + "\\" + this.strRuleCounter;
			bool flag2 = !File.Exists(path2);
			if (flag2)
			{
				File.WriteAllText(this.pathtemp + "\\" + this.strRuleCounter, Resources.RuleCounter);
			}
			this.strRuleCounter = path2;
			string path3 = this.pathtemp + "\\" + this.strfileName;
			bool flag3 = !File.Exists(path3);
			if (flag3)
			{
				File.WriteAllText(this.pathtemp + "\\" + this.strfileName, Resources.Config);
			}
			this.strfileName = path3;
			this.Docfile(true);
			this.Docfile(false);
			this.ReadFileSource(true);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000063F0 File Offset: 0x000045F0
		private void ChangeValueCombobox(object sender, EventArgs e)
		{
			this.ReadFileSource(false);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000063FC File Offset: 0x000045FC
		private void CallFormSelect(string pathFile)
		{
			try
			{
				frmSelectFileorFolder frmSelectFileorFolder = new frmSelectFileorFolder();
				bool flag = this.lstFileDiff.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object value in this.lstFileDiff.Items)
						{
							string item = Conversions.ToString(value);
							frmSelectFileorFolder.returnListfile.Add(item);
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
				}
				frmSelectFileorFolder.pathNewDiff = pathFile;
				frmSelectFileorFolder.checkDiff = true;
				frmSelectFileorFolder.ShowDialog();
				bool flag2 = frmSelectFileorFolder.returnListfile != null;
				if (flag2)
				{
					this.lstFileDiff.Items.Clear();
					try
					{
						foreach (string text in frmSelectFileorFolder.returnListfile)
						{
							bool flag3 = !this.lstFileDiff.Items.Contains(text);
							if (flag3)
							{
								this.lstFileDiff.Items.Add(text);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006590 File Offset: 0x00004790
		private void GetSourceSVN(string pathBase, string pathDiff, string strLinkSVN)
		{
			try
			{
				bool flag = !Directory.Exists(pathBase) & !Directory.Exists(pathDiff);
				if (flag)
				{
					this.CreateFolderDiffSVN(pathBase, pathDiff, strLinkSVN, true);
					this.CreateFolderDiffSVN(pathBase, pathDiff, strLinkSVN, false);
				}
				else
				{
					bool flag2 = !Directory.Exists(pathBase) & Directory.Exists(pathDiff);
					if (flag2)
					{
						this.CreateFolderDiffSVN(pathBase, pathDiff, strLinkSVN, true);
					}
					else
					{
						bool flag3 = Directory.Exists(pathBase) & !Directory.Exists(pathDiff);
						if (flag3)
						{
							this.CreateFolderDiffSVN(pathBase, pathDiff, strLinkSVN, false);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006644 File Offset: 0x00004844
		private void CreateFolderDiffSVN(string pathBase, string pathDiff, string strLinkSVN, bool checkDiffSVN)
		{
			string text = "/c svn";
			if (checkDiffSVN)
			{
				text = string.Concat(new string[]
				{
					text,
					" export -r \"",
					this.txtBase.Text,
					"\" \"",
					strLinkSVN,
					"\" \"",
					pathBase,
					"\""
				});
			}
			else
			{
				bool @checked = this.chkHead.Checked;
				if (@checked)
				{
					text = string.Concat(new string[]
					{
						text,
						" export \"",
						strLinkSVN,
						"\" \"",
						pathDiff,
						"\""
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						text,
						" export -r \"",
						this.txtDiff.Text,
						"\" \"",
						strLinkSVN,
						"\" \"",
						pathDiff,
						"\""
					});
				}
			}
			Common.ProcessCommandline(text);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006740 File Offset: 0x00004940
		private void txtRepository_TextChanged()
		{
			this.DeleteFolder();
			this.lstFolderFile.Items.Clear();
			this.lstFileDiff.Items.Clear();
			this.lblpathfile.Text = "";
			this.txtBasefolder.Text = "";
			this.txtDifffolder.Text = "";
			this.txtDiff.Text = "";
			this.txtBase.Text = "";
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000067CC File Offset: 0x000049CC
		private object match_file()
		{
			string text = "";
			object result;
			try
			{
				try
				{
					foreach (object value in this.lstFileDiff.Items)
					{
						string text2 = Conversions.ToString(value);
						bool flag = !Directory.Exists(text2);
						if (flag)
						{
							string str = text2.Substring(checked(text2.LastIndexOf("\\") + 1));
							text = text + "^" + str + "|";
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
				result = text;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000068A8 File Offset: 0x00004AA8
		private void CreateFile(ref string filename)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.GetEncoding("shift-jis"));
				try
				{
					foreach (object value in this.lstFolderFile.Items)
					{
						string value2 = Conversions.ToString(value);
						streamWriter.WriteLine(value2);
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
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006958 File Offset: 0x00004B58
		private void Base_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006994 File Offset: 0x00004B94
		private void Diff_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000069CE File Offset: 0x00004BCE
		private void Form_Closed()
		{
			this.DeleteFolder();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000069D8 File Offset: 0x00004BD8
		private void DeleteFolder()
		{
			bool flag = Directory.Exists(this.strPathHead);
			if (flag)
			{
				Directory.Delete(this.strPathHead, true);
			}
			bool flag2 = Directory.Exists(this.txtBase.Text);
			if (flag2)
			{
				Directory.Delete(this.txtBase.Text, true);
			}
			bool flag3 = Directory.Exists(this.txtDiff.Text);
			if (flag3)
			{
				Directory.Delete(this.txtDiff.Text, true);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006A54 File Offset: 0x00004C54
		private bool checkInput()
		{
			bool @checked = this.optFileSystem.Checked;
			if (@checked)
			{
				bool flag = this.optListCounter.Checked & !this.optDiff.Checked;
				if (flag)
				{
					bool flag2 = this.lstFolderFile.Items.Count == 0;
					if (flag2)
					{
						Interaction.MsgBox("Chưa chọn thư mục hoặc tập tin cần tính", MsgBoxStyle.OkOnly, null);
						return false;
					}
				}
				else
				{
					bool flag3 = !this.optListCounter.Checked & this.optDiff.Checked;
					if (flag3)
					{
						bool flag4 = Strings.Trim(this.txtBasefolder.Text).Length == 0;
						if (flag4)
						{
							this.showMessageBox(this.txtBasefolder, "Thư mục cũ chưa được nhập.");
							return false;
						}
						bool flag5 = Strings.Trim(this.txtDifffolder.Text).Length == 0;
						if (flag5)
						{
							this.showMessageBox(this.txtDifffolder, "Thư mục mới chưa được nhập.");
							return false;
						}
					}
				}
			}
			else
			{
				bool checked2 = this.optSVN.Checked;
				if (checked2)
				{
					bool flag6 = this.txtRepository.Text.Length == 0;
					if (flag6)
					{
						this.showMessageBox(this.txtRepository, "Chưa nhập Repository SVN.");
						return false;
					}
					bool flag7 = this.optListCounter.Checked & !this.optDiffVersion.Checked;
					if (flag7)
					{
						bool flag8 = this.lstFolderFile.Items.Count == 0;
						if (flag8)
						{
							Interaction.MsgBox("Chưa chọn thư mục hoặc tập tin cần tính", MsgBoxStyle.OkOnly, null);
							return false;
						}
					}
					else
					{
						bool flag9 = !this.optListCounter.Checked & this.optDiffVersion.Checked;
						if (flag9)
						{
							bool flag10 = Strings.Trim(this.txtBase.Text).Length == 0;
							if (flag10)
							{
								this.showMessageBox(this.txtBase, "Thư mục cũ chưa được nhập.");
								return false;
							}
							bool flag11 = !this.chkHead.Checked;
							if (flag11)
							{
								bool flag12 = Strings.Trim(this.txtDiff.Text).Length == 0;
								if (flag12)
								{
									this.showMessageBox(this.txtDiff, "Thư mục mới chưa được nhập.");
									return false;
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006C9C File Offset: 0x00004E9C
		private void optFileSystem_CheckedChanged(object sender, EventArgs e)
		{
			this.enableoptFilesystem(this.optFileSystem.Checked);
			this.cboTypeSource.Text = "";
			this.txtRepository_TextChanged();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006CCC File Offset: 0x00004ECC
		private void optSVN_CheckedChanged(object sender, EventArgs e)
		{
			this.cboTypeSource.Enabled = true;
			this.enableoptSVN(this.optSVN.Checked);
			this.txtRepository.Text = "";
			this.txtRepository_TextChanged();
			SvnUIBindArgs svnUIBindArgs = new SvnUIBindArgs();
			SvnUI.Bind(Common.client, svnUIBindArgs);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006D24 File Offset: 0x00004F24
		private void optListCounter_CheckedChanged(object sender, EventArgs e)
		{
			this.lstFolderFile.Enabled = this.optListCounter.Checked;
			this.btnSelectFolderFile.Enabled = this.optListCounter.Checked;
			this.btnDelete.Enabled = this.optListCounter.Checked;
			bool @checked = this.optListCounter.Checked;
			if (@checked)
			{
				this.lstFolderFile.BackColor = Color.White;
				bool flag = this.lstFolderFile.Items.Count > 0;
				if (flag)
				{
					this.lstFolderFile.SelectedIndex = 0;
				}
			}
			else
			{
				this.lstFolderFile.BackColor = Color.WhiteSmoke;
				this.lstFolderFile.ClearSelected();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006DE0 File Offset: 0x00004FE0
		private void optDiffVersion_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.optDiffVersion.Checked;
			if (@checked)
			{
				bool flag = this.txtRepository.Text.Length == 0;
				if (flag)
				{
					this.showMessageBox(this.txtRepository, "Chưa nhập Repository SVN.");
				}
				this.txtDiff.Enabled = false;
			}
			else
			{
				this.chkHead.Checked = this.optDiffVersion.Checked;
			}
			this.txtBase.Enabled = this.optDiffVersion.Checked;
			this.chkHead.Enabled = this.optDiffVersion.Checked;
			this.chkDiff.Enabled = this.optDiffVersion.Checked;
			this.txtDiff.Enabled = this.optDiffVersion.Checked;
			this.btnRefVersion.Enabled = this.optDiffVersion.Checked;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006EC4 File Offset: 0x000050C4
		private void optDiff_CheckedChanged(object sender, EventArgs e)
		{
			this.txtBasefolder.Enabled = this.optDiff.Checked;
			this.txtDifffolder.Enabled = this.optDiff.Checked;
			this.btnBase.Enabled = this.optDiff.Checked;
			this.btndiff.Enabled = this.optDiff.Checked;
			this.chkDiff.Enabled = this.optDiff.Checked;
			bool flag = !this.optDiff.Checked;
			if (flag)
			{
				this.chkDiff.Checked = this.optDiff.Checked;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006F70 File Offset: 0x00005170
		private void btnSelectFolderFile_Click(object sender, EventArgs e)
		{
			frmSelectFileorFolder frmSelectFileorFolder = new frmSelectFileorFolder();
			List<string> list = new List<string>();
			try
			{
				bool @checked = this.optSVN.Checked;
				if (@checked)
				{
					bool checked2 = this.optListCounter.Checked;
					if (checked2)
					{
						bool flag = this.txtRepository.Text.Length > 0;
						if (!flag)
						{
							this.showMessageBox(this.txtRepository, "Chưa nhập Repository SVN.");
							return;
						}
						frmSelectFileRepository frmSelectFileRepository = new frmSelectFileRepository();
						frmSelectFileRepository.svnUrl = this.txtRepository.Text;
						frmSelectFileRepository.revision = "Head";
						frmSelectFileRepository.ShowDialog();
						bool flag2 = frmSelectFileRepository.listfile != null;
						if (flag2)
						{
							try
							{
								foreach (string text in frmSelectFileRepository.listfile)
								{
									string item = text.Substring(this.txtRepository.Text.Length, checked(text.Length - this.txtRepository.Text.Length));
									list.Add(item);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				else
				{
					frmSelectFileorFolder.pathNewDiff = this.lblpathfile.Text;
					bool flag3 = this.lstFolderFile.Items.Count > 0;
					if (flag3)
					{
						try
						{
							foreach (object value in this.lstFolderFile.Items)
							{
								string item2 = Conversions.ToString(value);
								frmSelectFileorFolder.returnListfile.Add(item2);
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					frmSelectFileorFolder.ShowDialog();
					bool flag4 = frmSelectFileorFolder.returnListfile != null;
					if (flag4)
					{
						list.AddRange(frmSelectFileorFolder.returnListfile);
					}
				}
				bool flag5 = list != null;
				if (flag5)
				{
					try
					{
						foreach (string text2 in list)
						{
							bool flag6 = !this.lstFolderFile.Items.Contains(text2);
							if (flag6)
							{
								this.lstFolderFile.Items.Add(text2);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					bool flag7 = this.lstFolderFile.Items.Count > 0;
					if (flag7)
					{
						this.lstFolderFile.SelectedIndex = 0;
					}
				}
				bool flag8 = Operators.CompareString(frmSelectFileorFolder.ListCheckValue, "", false) != 0;
				if (flag8)
				{
					this.lblpathfile.Text = frmSelectFileorFolder.ListCheckValue;
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000072A4 File Offset: 0x000054A4
		private void btnDelete_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = this.lstFolderFile.SelectedItems.Count > 0;
					if (flag)
					{
						int num = this.lstFolderFile.SelectedItems.Count - 1;
						for (int i = num; i >= 0; i += -1)
						{
							this.lstFolderFile.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstFolderFile.SelectedItems[i]));
						}
					}
					bool flag2 = this.lstFolderFile.Items.Count > 0;
					if (flag2)
					{
						this.lstFolderFile.SelectedIndex = 0;
					}
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000736C File Offset: 0x0000556C
		private void chkHead_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkHead.Checked;
			if (@checked)
			{
				this.txtDiff.Enabled = false;
			}
			else
			{
				this.txtDiff.Enabled = true;
			}
			this.lstFileDiff.Items.Clear();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000073BC File Offset: 0x000055BC
		private void btnBase_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txtBasefolder.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000073F4 File Offset: 0x000055F4
		private void btndiff_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txtDifffolder.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000742C File Offset: 0x0000562C
		private void chkDiff_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkDiff.Checked;
			if (@checked)
			{
				bool checked2 = this.optSVN.Checked;
				if (checked2)
				{
					bool flag = this.txtRepository.Text.Length == 0;
					if (flag)
					{
						this.showMessageBox(this.txtRepository, "Chưa nhập Repository SVN.");
						this.chkDiff.Checked = false;
						return;
					}
					bool flag2 = Strings.Trim(this.txtBase.Text).Length == 0;
					if (flag2)
					{
						this.showMessageBox(this.txtBase, "Phiên bản cũ chưa được nhập! ");
						this.chkDiff.Checked = false;
						return;
					}
					bool flag3 = !this.chkHead.Checked;
					if (flag3)
					{
						bool flag4 = Strings.Trim(this.txtDiff.Text).Length == 0;
						if (flag4)
						{
							this.showMessageBox(this.txtDiff, "Phiên bản mới chưa được nhập! ");
							this.chkDiff.Checked = false;
							return;
						}
					}
				}
				this.lstFileDiff.BackColor = Color.White;
			}
			else
			{
				this.lstFileDiff.BackColor = Color.WhiteSmoke;
				this.lstFileDiff.Items.Clear();
			}
			this.lstFileDiff.Enabled = this.chkDiff.Checked;
			this.btnFile.Enabled = this.chkDiff.Checked;
			this.btnDeleteFile.Enabled = this.chkDiff.Checked;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000075B4 File Offset: 0x000057B4
		private void btnDeleteFile_Click(object sender, EventArgs e)
		{
			bool flag = this.lstFileDiff.SelectedItems.Count > 0;
			checked
			{
				if (flag)
				{
					int num = this.lstFileDiff.SelectedItems.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						this.lstFileDiff.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstFileDiff.SelectedItems[i]));
					}
				}
				bool flag2 = this.lstFileDiff.Items.Count > 0;
				if (flag2)
				{
					this.lstFileDiff.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007648 File Offset: 0x00005848
		private void btnCount_Click(object sender, EventArgs e)
		{
			bool flag = this.checkInput();
			checked
			{
				if (flag)
				{
					string text = "";
					string text2 = "";
					string text3 = "/c " + this.pathtemp + "\\cloc.exe";
					string str = "FileCounter" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
					string text4 = this.pathtemp + "\\" + str;
					string text5 = this.pathtemp + "\\LOCCounter" + DateAndTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
					try
					{
						bool @checked = this.optFileSystem.Checked;
						if (@checked)
						{
							bool checked2 = this.optListCounter.Checked;
							if (checked2)
							{
								List<string> list = new List<string>();
								this.CreateFile(ref text4);
								text3 = text3 + " --list-file=\"" + text4 + "\"";
							}
							bool checked3 = this.optDiff.Checked;
							if (checked3)
							{
								bool checked4 = this.chkDiff.Checked;
								if (checked4)
								{
									bool flag2 = this.lstFileDiff.Items.Count > 0;
									if (flag2)
									{
										string text6 = Conversions.ToString(this.match_file());
										text6 = text6.Substring(0, text6.Length - 1);
										text3 = text3 + " --match-f=\"" + text6 + "\"";
									}
								}
								text3 = string.Concat(new string[]
								{
									text3,
									" --Diff \"",
									this.txtBasefolder.Text,
									"\" \"",
									this.txtDifffolder.Text,
									"\""
								});
							}
						}
						bool checked5 = this.optSVN.Checked;
						if (checked5)
						{
							bool checked6 = this.optListCounter.Checked;
							if (checked6)
							{
								bool flag3 = this.txtRepository.Text.Length > 0;
								if (flag3)
								{
									List<string> list2 = new List<string>();
									try
									{
										foreach (object value in this.lstFolderFile.Items)
										{
											string str2 = Conversions.ToString(value);
											list2.Add(this.txtRepository.Text + str2);
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
									Common.DownloadSVNToLocal(this.pathtemp + "\\" + this.strPathHead, list2, text4);
									text3 = text3 + " --list-file=\"" + text4 + "\"";
								}
							}
							bool checked7 = this.optDiffVersion.Checked;
							if (checked7)
							{
								bool flag4 = this.txtBase.Text.Length > 0;
								if (flag4)
								{
									text2 = this.pathtemp + "\\" + this.txtBase.Text;
								}
								bool checked8 = this.chkHead.Checked;
								string text7;
								if (checked8)
								{
									text7 = this.pathtemp + "\\" + this.strPathHead;
								}
								else
								{
									text7 = this.pathtemp + "\\" + this.txtDiff.Text;
								}
								List<string> lstfiledownload = new List<string>();
								bool checked9 = this.chkDiff.Checked;
								if (checked9)
								{
									bool flag5 = this.lstFileDiff.Items.Count > 0;
									if (flag5)
									{
										string text6 = Conversions.ToString(this.match_file());
										text6 = text6.Substring(0, text6.Length - 1);
										text3 = text3 + " --match-f=\"" + text6 + "\"";
									}
								}
								Common.DownloadSVNDiffToLocal(this.txtRepository.Text, this.pathtemp, Conversions.ToLong(this.txtBase.Text), Conversions.ToLong(this.txtDiff.Text), lstfiledownload);
								text3 = string.Concat(new string[]
								{
									text3,
									" --Diff \"",
									text2,
									"\" \"",
									text7,
									"\""
								});
							}
						}
						bool flag6 = this.txtExt.CheckedItems.Count > 0;
						if (flag6)
						{
							int num = this.txtExt.CheckedItems.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								string str3 = Conversions.ToString(NewLateBinding.LateGet(this.txtExt.CheckedItems[i], null, "Replace", new object[]
								{
									" ",
									""
								}, null, null, null));
								text = text + str3 + ",";
							}
							text = text.Substring(0, text.Length - 1);
							text3 = text3 + " --exclude-ext=" + text;
						}
						text3 = text3 + " --unicode --ignore-case-ext --skip-win-hidden --skip-uniqueness --by-file --csv --out=\"" + text5 + "\"";
						Common.ProcessCommandline(text3);
						string text8 = "";
						bool flag7 = this.txtDes.CheckedItems.Count > 0;
						if (flag7)
						{
							int num2 = this.txtDes.CheckedItems.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								string[] array = (string[])NewLateBinding.LateGet(this.txtDes.CheckedItems[j], null, "Split", new object[]
								{
									","
								}, null, null, null);
								int num3 = array.Count<string>() - 1;
								for (int k = 0; k <= num3; k++)
								{
									string text9 = Strings.Trim(array[k]);
									bool flag8 = text9.Length > 0;
									if (flag8)
									{
										text8 = text8 + "." + text9 + ",";
									}
								}
							}
							text8 = text8.Substring(0, text8.Length - 1);
						}
						bool flag9 = File.Exists(text5);
						if (flag9)
						{
							bool checked10 = this.optListCounter.Checked;
							if (checked10)
							{
								new frmResultCountFile
								{
									path = text5,
									dataCountFile = text8
								}.ShowDialog();
							}
							else
							{
								bool flag10 = this.optDiff.Checked | this.optDiffVersion.Checked;
								if (flag10)
								{
									new frmResultDiff
									{
										path = text5,
										dataDesign = text8
									}.ShowDialog();
								}
							}
						}
						else
						{
							Interaction.MsgBox("Tập tin đang chọn chưa được hỗ trợ để tính LOC", MsgBoxStyle.OkOnly, null);
						}
						File.Delete(text4);
						File.Delete(text5);
						Common.DeleteDirectory(this.pathtemp);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007D24 File Offset: 0x00005F24
		private void AddDesign(object sender, EventArgs e)
		{
			bool flag = this.txtAddDes.Text.Length == 0;
			if (flag)
			{
				Interaction.MsgBox("Bạn chưa nhập Design.", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = this.Ghifile(false);
				if (flag2)
				{
					this.txtDes.Items.Clear();
					bool flag3 = !this.Docfile(false);
					if (flag3)
					{
						Interaction.MsgBox("Đọc file bị lỗi.", MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					Interaction.MsgBox("Lưu dữ liệu bị lỗi.", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007DA8 File Offset: 0x00005FA8
		private void btnAddExt_Click(object sender, EventArgs e)
		{
			bool flag = this.txtAddExt.Text.Length == 0;
			if (flag)
			{
				Interaction.MsgBox("Bạn chưa nhập Extension.", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = this.Ghifile(true);
				if (flag2)
				{
					this.txtExt.Items.Clear();
					bool flag3 = !this.Docfile(true);
					if (flag3)
					{
						Interaction.MsgBox("Đọc file bị lỗi.", MsgBoxStyle.OkOnly, null);
					}
				}
				else
				{
					Interaction.MsgBox("Lưu dữ liệu bị lỗi.", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007E2C File Offset: 0x0000602C
		private void btnFile_Click(object sender, EventArgs e)
		{
			bool @checked = this.optFileSystem.Checked;
			if (@checked)
			{
				bool flag = Strings.Trim(this.txtBasefolder.Text).Length == 0;
				if (flag)
				{
					this.showMessageBox(this.txtBasefolder, "Thư mục cũ chưa được nhập.");
				}
				else
				{
					bool flag2 = Strings.Trim(this.txtDifffolder.Text).Length == 0;
					if (flag2)
					{
						this.showMessageBox(this.txtDifffolder, "Thư mục mới chưa được nhập.");
					}
					else
					{
						bool flag3 = Directory.Exists(this.txtDifffolder.Text);
						if (flag3)
						{
							this.CallFormSelect(this.txtDifffolder.Text);
						}
						else
						{
							this.showMessageBox(this.txtDifffolder, "Thư mục mới không phải là thư mục.");
						}
					}
				}
			}
			else
			{
				frmSelectFileRepository frmSelectFileRepository = new frmSelectFileRepository();
				frmSelectFileRepository.svnUrl = this.txtRepository.Text;
				bool checked2 = this.chkHead.Checked;
				if (checked2)
				{
					frmSelectFileRepository.revision = "Head";
				}
				else
				{
					frmSelectFileRepository.revision = this.txtDiff.Text;
				}
				frmSelectFileRepository.ShowDialog();
				bool flag4 = frmSelectFileRepository.listfile != null;
				if (flag4)
				{
					try
					{
						foreach (string text in frmSelectFileRepository.listfile)
						{
							bool flag5 = !this.lstFileDiff.Items.Contains(text);
							if (flag5)
							{
								this.lstFileDiff.Items.Add(text);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007FE0 File Offset: 0x000061E0
		private void lstFolderFile_DragDrop(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
				foreach (string item in array)
				{
					this.lstFolderFile.Items.Add(item);
				}
			}
			bool flag = this.lstFolderFile.Items.Count > 0;
			if (flag)
			{
				this.lstFolderFile.SelectedIndex = 0;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008074 File Offset: 0x00006274
		private void lstFolderFile_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000080AB File Offset: 0x000062AB
		private void txtDifffolder_TextChanged(object sender, EventArgs e)
		{
			this.lstFileDiff.Items.Clear();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000063F0 File Offset: 0x000045F0
		private void cboTypeSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ReadFileSource(false);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000080C0 File Offset: 0x000062C0
		private void btnRefVersion_Click(object sender, EventArgs e)
		{
			bool flag = Strings.Trim(this.txtRepository.Text).Length == 0;
			if (flag)
			{
				this.showMessageBox(this.txtRepository, "Chưa nhập Repository SVN.");
			}
			else
			{
				string text = "/c TortoiseProc.exe";
				text = string.Concat(new string[]
				{
					text,
					text,
					" /command:log /path:\"",
					this.txtRepository.Text,
					"\""
				});
				new Process
				{
					StartInfo = 
					{
						FileName = "CMD.exe",
						Arguments = text,
						WindowStyle = ProcessWindowStyle.Hidden
					}
				}.Start();
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008178 File Offset: 0x00006378
		private void txtBase_LostFocus(object sender, EventArgs e)
		{
			bool flag = Strings.Trim(this.txtRepository.Text).Length == 0;
			if (!flag)
			{
				bool flag2 = this.txtBase.TextLength > 0;
				if (flag2)
				{
					bool flag3 = !Common.CheckRevision(Common.client, this.txtRepository.Text, this.txtBase.Text);
					if (flag3)
					{
						this.showMessageBox(this.txtBase, "Phiên bản không tồn tại, hãy nhập lại! ");
					}
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000081F4 File Offset: 0x000063F4
		private void txtDiff_LostFocus(object sender, EventArgs e)
		{
			bool flag = Strings.Trim(this.txtRepository.Text).Length == 0;
			if (!flag)
			{
				bool flag2 = this.txtDiff.TextLength > 0;
				if (flag2)
				{
					bool flag3 = !Common.CheckRevision(Common.client, this.txtRepository.Text, this.txtDiff.Text);
					if (flag3)
					{
						this.showMessageBox(this.txtDiff, "Phiên bản không tồn tại, hãy nhập lại! ");
					}
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008270 File Offset: 0x00006470
		private void txtRepository_LostFocus(object sender, EventArgs e)
		{
			bool flag = !Common.CheckRepos(this.txtRepository.Text);
			if (flag)
			{
				this.showMessageBox(this.txtRepository, "Repository SVN không tồn tại, hãy nhập lại.");
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000082A9 File Offset: 0x000064A9
		private void showMessageBox(TextBox controlTextBox, string msg)
		{
			Interaction.MsgBox(msg, MsgBoxStyle.OkOnly, null);
			controlTextBox.Focus();
			controlTextBox.SelectAll();
		}

		// Token: 0x04000047 RID: 71
		private int IntSumLOC;

		// Token: 0x04000048 RID: 72
		private string strfileName;

		// Token: 0x04000049 RID: 73
		private string strRuleCounter;

		// Token: 0x0400004A RID: 74
		private string strPathHead;

		// Token: 0x0400004B RID: 75
		private string pathtemp;

		// Token: 0x0400004C RID: 76
		private XmlDocument xmlFile;
	}
}
