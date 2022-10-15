using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000D RID: 13
	[Guid("E7E66D47-2367-47BC-A2F0-7F6D807FE08A")]
	[TypeLibType(2)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport]
	public class SDUtilitiesClass : ISDUtilities, SDUtilities
	{
		// Token: 0x06000066 RID: 102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern SDUtilitiesClass();

		// Token: 0x06000067 RID: 103
		[DispId(800)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern bool CheckMarkers([MarshalAs(UnmanagedType.Interface)] [In] SDVariables pVariables);

		// Token: 0x06000068 RID: 104
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern SDResults Resolve3([MarshalAs(UnmanagedType.BStr)] [In] string bstrBase, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTheirs, [MarshalAs(UnmanagedType.BStr)] [In] string bstrYours, [MarshalAs(UnmanagedType.BStr)] [In] string bstrResult, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAflags = "", [MarshalAs(UnmanagedType.BStr)] [In] string bstrDflags = "", [In] bool varfNewResultsCollection = false);

		// Token: 0x06000069 RID: 105
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern SDVariables Diff([MarshalAs(UnmanagedType.BStr)] [In] string bstrLeft, [MarshalAs(UnmanagedType.BStr)] [In] string bstrRight, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFlags = "", [In] SDTT_TEXTTYPE eForceTextual = SDTT_TEXTTYPE.SDTT_NONTEXT);

		// Token: 0x0600006A RID: 106
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void DetectType([MarshalAs(UnmanagedType.BStr)] [In] string bstrFile, [MarshalAs(UnmanagedType.Struct)] out object pvarTextual, [MarshalAs(UnmanagedType.Struct)] out object pvarType);

		// Token: 0x0600006B RID: 107
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Set([MarshalAs(UnmanagedType.BStr)] [In] string bstrVar, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue = "", [In] bool varfMachine = false, [MarshalAs(UnmanagedType.BStr)] [In] string bstrService = "");

		// Token: 0x0600006C RID: 108
		[DispId(805)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern SDVariables QuerySettings([MarshalAs(UnmanagedType.BStr)] [In] string bstrVar = "", [MarshalAs(UnmanagedType.BStr)] [In] string bstrService = "");
	}
}
