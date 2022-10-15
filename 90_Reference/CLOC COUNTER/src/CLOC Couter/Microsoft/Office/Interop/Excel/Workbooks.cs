using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x0200001A RID: 26
	[CompilerGenerated]
	[Guid("000208DB-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface Workbooks : IEnumerable
	{
		// Token: 0x06000172 RID: 370
		void _VtblGap1_3();

		// Token: 0x06000173 RID: 371
		[LCIDConversion(1)]
		[DispId(181)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Workbook Add([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Template);

		// Token: 0x06000174 RID: 372
		void _VtblGap2_6();

		// Token: 0x1700007F RID: 127
		[DispId(0)]
		[IndexerName("_Default")]
		Workbook this[[MarshalAs(UnmanagedType.Struct)] [In] object Index]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
	}
}
