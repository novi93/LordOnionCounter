using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x0200001C RID: 28
	[CompilerGenerated]
	[Guid("000208DA-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface _Workbook
	{
		// Token: 0x06000181 RID: 385
		void _VtblGap1_97();

		// Token: 0x06000182 RID: 386
		[DispId(175)]
		[LCIDConversion(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SaveCopyAs([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Filename);

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000183 RID: 387
		// (set) Token: 0x06000184 RID: 388
		[DispId(298)]
		bool Saved { [DispId(298)] [LCIDConversion(0)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(298)] [LCIDConversion(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}
}
