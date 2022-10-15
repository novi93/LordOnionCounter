using System;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x0200000B RID: 11
	public class PspMetricCounterData
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000034E8 File Offset: 0x000024E8
		internal PspMetricCounterData()
		{
			this._endLine = 0;
			this._itemCount = 0;
			this._PspExistType = 0;
			this._PspExistType = 1;
			this._meetEnd = false;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000351D File Offset: 0x0000251D
		internal PspMetricCounterData(int value)
		{
			this._itemCount = 0;
			this._endLine = value;
			this._PspExistType = 1;
			this._meetEnd = false;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000354C File Offset: 0x0000254C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00003564 File Offset: 0x00002564
		public int startPositionFlat
		{
			get
			{
				return this._startPositionFlat;
			}
			set
			{
				this._startPositionFlat = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003570 File Offset: 0x00002570
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00003588 File Offset: 0x00002588
		public string Name
		{
			get
			{
				return this._PspMetricName;
			}
			set
			{
				this._PspMetricName = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003594 File Offset: 0x00002594
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000035AC File Offset: 0x000025AC
		public string PspMetricTypeName
		{
			get
			{
				return this._PspMetricTypeName;
			}
			set
			{
				this._PspMetricTypeName = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000035B8 File Offset: 0x000025B8
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000035D0 File Offset: 0x000025D0
		public string NewName
		{
			get
			{
				return this._PspMetricNewName;
			}
			set
			{
				this._PspMetricNewName = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000035DC File Offset: 0x000025DC
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000035F4 File Offset: 0x000025F4
		public string PspMetricObjectType
		{
			get
			{
				return this._PspMetricObjectType;
			}
			set
			{
				this._PspMetricObjectType = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003600 File Offset: 0x00002600
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00003618 File Offset: 0x00002618
		public string PspMetricNewObjectType
		{
			get
			{
				return this._PspMetricNewObjectType;
			}
			set
			{
				this._PspMetricNewObjectType = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003624 File Offset: 0x00002624
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000363C File Offset: 0x0000263C
		public int startLine
		{
			get
			{
				return this._startLine;
			}
			set
			{
				this._startLine = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003648 File Offset: 0x00002648
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00003660 File Offset: 0x00002660
		public int startLineNew
		{
			get
			{
				return this._startLineNew;
			}
			set
			{
				this._startLineNew = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000366C File Offset: 0x0000266C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003684 File Offset: 0x00002684
		public int PspExistType
		{
			get
			{
				return this._PspExistType;
			}
			set
			{
				this._PspExistType = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003690 File Offset: 0x00002690
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000036A8 File Offset: 0x000026A8
		public int endLine
		{
			get
			{
				return this._endLine;
			}
			set
			{
				this._endLine = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000036B4 File Offset: 0x000026B4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000036CC File Offset: 0x000026CC
		public int endLineNew
		{
			get
			{
				return this._endLineNew;
			}
			set
			{
				this._endLineNew = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000036D8 File Offset: 0x000026D8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000036F0 File Offset: 0x000026F0
		public bool meetEnd
		{
			get
			{
				return this._meetEnd;
			}
			set
			{
				this._meetEnd = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000036FC File Offset: 0x000026FC
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00003714 File Offset: 0x00002714
		public int totalLine
		{
			get
			{
				return this._totalLine;
			}
			set
			{
				this._totalLine = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003720 File Offset: 0x00002720
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00003738 File Offset: 0x00002738
		public int totalLineNew
		{
			get
			{
				return this._totalLineNew;
			}
			set
			{
				this._totalLineNew = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003744 File Offset: 0x00002744
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000375C File Offset: 0x0000275C
		public int addedLine
		{
			get
			{
				return this._addedLine;
			}
			set
			{
				this._addedLine = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003768 File Offset: 0x00002768
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00003780 File Offset: 0x00002780
		public int baseLine
		{
			get
			{
				return this._baseLine;
			}
			set
			{
				this._baseLine = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000378C File Offset: 0x0000278C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000037A4 File Offset: 0x000027A4
		public int deleteLine
		{
			get
			{
				return this._deleteLine;
			}
			set
			{
				this._deleteLine = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000037B0 File Offset: 0x000027B0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000037C8 File Offset: 0x000027C8
		public int modifyLine
		{
			get
			{
				return this._modifyLine;
			}
			set
			{
				this._modifyLine = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000037D4 File Offset: 0x000027D4
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000037EC File Offset: 0x000027EC
		public int itemCount
		{
			get
			{
				return this._itemCount;
			}
			set
			{
				this._itemCount = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000037F8 File Offset: 0x000027F8
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00003810 File Offset: 0x00002810
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000381C File Offset: 0x0000281C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00003834 File Offset: 0x00002834
		public int parentId
		{
			get
			{
				return this._parentId;
			}
			set
			{
				this._parentId = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003840 File Offset: 0x00002840
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003858 File Offset: 0x00002858
		public string parentString
		{
			get
			{
				return this._parentString;
			}
			set
			{
				this._parentString = value;
			}
		}

		// Token: 0x04000020 RID: 32
		private int _startPositionFlat;

		// Token: 0x04000021 RID: 33
		private string _PspMetricName;

		// Token: 0x04000022 RID: 34
		private string _PspMetricTypeName;

		// Token: 0x04000023 RID: 35
		private string _PspMetricNewName;

		// Token: 0x04000024 RID: 36
		private string _PspMetricObjectType;

		// Token: 0x04000025 RID: 37
		private string _PspMetricNewObjectType;

		// Token: 0x04000026 RID: 38
		private int _startLine;

		// Token: 0x04000027 RID: 39
		private int _startLineNew;

		// Token: 0x04000028 RID: 40
		private int _PspExistType = 1;

		// Token: 0x04000029 RID: 41
		private int _endLine;

		// Token: 0x0400002A RID: 42
		private int _endLineNew;

		// Token: 0x0400002B RID: 43
		private bool _meetEnd;

		// Token: 0x0400002C RID: 44
		private int _totalLine;

		// Token: 0x0400002D RID: 45
		private int _totalLineNew;

		// Token: 0x0400002E RID: 46
		private int _addedLine;

		// Token: 0x0400002F RID: 47
		private int _baseLine;

		// Token: 0x04000030 RID: 48
		private int _deleteLine;

		// Token: 0x04000031 RID: 49
		private int _modifyLine;

		// Token: 0x04000032 RID: 50
		private int _itemCount;

		// Token: 0x04000033 RID: 51
		private int _id;

		// Token: 0x04000034 RID: 52
		private int _parentId;

		// Token: 0x04000035 RID: 53
		private string _parentString;
	}
}
