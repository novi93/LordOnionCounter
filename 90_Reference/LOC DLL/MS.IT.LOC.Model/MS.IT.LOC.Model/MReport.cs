using System;

namespace MS.IT.LOC.Model
{
	// Token: 0x0200000F RID: 15
	public class MReport
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000038A8 File Offset: 0x000028A8
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000389C File Offset: 0x0000289C
		public double M1
		{
			get
			{
				return this._M1;
			}
			set
			{
				this._M1 = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000038CC File Offset: 0x000028CC
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000038C0 File Offset: 0x000028C0
		public double M2
		{
			get
			{
				return this._M2;
			}
			set
			{
				this._M2 = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000038F0 File Offset: 0x000028F0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000038E4 File Offset: 0x000028E4
		public double M3
		{
			get
			{
				return this._M3;
			}
			set
			{
				this._M3 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003914 File Offset: 0x00002914
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00003908 File Offset: 0x00002908
		public double M4
		{
			get
			{
				return this._M4;
			}
			set
			{
				this._M4 = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003938 File Offset: 0x00002938
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000392C File Offset: 0x0000292C
		public double M5
		{
			get
			{
				return this._M5;
			}
			set
			{
				this._M5 = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000395C File Offset: 0x0000295C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00003950 File Offset: 0x00002950
		public double M6
		{
			get
			{
				return this._M6;
			}
			set
			{
				this._M6 = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003980 File Offset: 0x00002980
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00003974 File Offset: 0x00002974
		public double M7
		{
			get
			{
				return this._M7;
			}
			set
			{
				this._M7 = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000039A4 File Offset: 0x000029A4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00003998 File Offset: 0x00002998
		public double M8
		{
			get
			{
				return this._M8;
			}
			set
			{
				this._M8 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000039BC File Offset: 0x000029BC
		public double DefectDensity
		{
			get
			{
				double result;
				if (this._M1 == -1.7976931348623157E+308 || this._M2 == -1.7976931348623157E+308 || this._M3 == -1.7976931348623157E+308 || this._M4 == -1.7976931348623157E+308 || this._M5 == -1.7976931348623157E+308 || this._M6 == -1.7976931348623157E+308 || this._M7 == -1.7976931348623157E+308 || this._M8 == -1.7976931348623157E+308)
				{
					result = 0.0;
				}
				else
				{
					double num = -0.216 + 15.063 * this._M1 + 85.77 * this._M2 + 4.939 * this._M3 + 0.17 * this._M4 + -1.293 * this._M5 + -0.001 * this._M6 + 0.0005 * this._M7 + -0.017 * this._M8;
					if (num < 0.0)
					{
						result = 0.0;
					}
					else
					{
						result = num;
					}
				}
				return result;
			}
		}

		// Token: 0x04000057 RID: 87
		private const double constantsV = -0.216;

		// Token: 0x04000058 RID: 88
		private const double a1 = 15.063;

		// Token: 0x04000059 RID: 89
		private const double a2 = 85.77;

		// Token: 0x0400005A RID: 90
		private const double a3 = 4.939;

		// Token: 0x0400005B RID: 91
		private const double a4 = 0.17;

		// Token: 0x0400005C RID: 92
		private const double a5 = -1.293;

		// Token: 0x0400005D RID: 93
		private const double a6 = -0.001;

		// Token: 0x0400005E RID: 94
		private const double a7 = 0.0005;

		// Token: 0x0400005F RID: 95
		private const double a8 = -0.017;

		// Token: 0x04000060 RID: 96
		private double _M1 = 0.0;

		// Token: 0x04000061 RID: 97
		private double _M2 = 0.0;

		// Token: 0x04000062 RID: 98
		private double _M3 = 0.0;

		// Token: 0x04000063 RID: 99
		private double _M4 = 0.0;

		// Token: 0x04000064 RID: 100
		private double _M5 = 0.0;

		// Token: 0x04000065 RID: 101
		private double _M6 = 0.0;

		// Token: 0x04000066 RID: 102
		private double _M7 = 0.0;

		// Token: 0x04000067 RID: 103
		private double _M8 = 0.0;
	}
}
