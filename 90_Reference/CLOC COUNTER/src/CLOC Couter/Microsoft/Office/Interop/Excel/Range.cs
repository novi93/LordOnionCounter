using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	[InterfaceType(2)]
	[Guid("00020846-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface Range
	{
		// Token: 0x0600016C RID: 364
		void _VtblGap1_32();

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600016D RID: 365
		// (set) Token: 0x0600016E RID: 366
		[DispId(242)]
		object ColumnWidth { [DispId(242)] [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(242)] [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }

		// Token: 0x0600016F RID: 367
		void _VtblGap2_11();

		// Token: 0x1700007E RID: 126
		[DispId(0)]
		[IndexerName("_Default")]
		object this[[MarshalAs(UnmanagedType.Struct)] [In] [Optional] object RowIndex, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object ColumnIndex]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[DispId(0)]
			[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
			[param: MarshalAs(UnmanagedType.Struct)]
			[param: In]
			[param: Optional]
			set;
		}
	}
}
