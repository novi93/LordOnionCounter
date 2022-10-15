using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[DefaultMember("_Default")]
	[Guid("000208D5-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface _Application
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000176 RID: 374
		[DispId(148)]
		Application Application { [DispId(148)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000177 RID: 375
		void _VtblGap1_10();

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000178 RID: 376
		[DispId(308)]
		Workbook ActiveWorkbook { [DispId(308)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000179 RID: 377
		void _VtblGap2_3();

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600017A RID: 378
		[DispId(238)]
		Range Cells { [DispId(238)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600017B RID: 379
		void _VtblGap3_1();

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600017C RID: 380
		[DispId(241)]
		Range Columns { [DispId(241)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600017D RID: 381
		void _VtblGap4_27();

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600017E RID: 382
		[DispId(572)]
		Workbooks Workbooks { [DispId(572)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600017F RID: 383
		void _VtblGap5_60();

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000180 RID: 384
		[DispId(0)]
		[IndexerName("_Default")]
		string _Default { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
