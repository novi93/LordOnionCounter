using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000F RID: 15
	[Guid("8A3F9EDF-2346-4E8A-B725-A66C2E124DE8")]
	[TypeLibType(4160)]
	[ComImport]
	public interface ISDUtilities
	{
		// Token: 0x0600006D RID: 109
		[DispId(800)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool CheckMarkers([MarshalAs(UnmanagedType.Interface)] [In] SDVariables pVariables);

		// Token: 0x0600006E RID: 110
		[DispId(801)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SDResults Resolve3([MarshalAs(UnmanagedType.BStr)] [In] string bstrBase, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTheirs, [MarshalAs(UnmanagedType.BStr)] [In] string bstrYours, [MarshalAs(UnmanagedType.BStr)] [In] string bstrResult, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAflags = "", [MarshalAs(UnmanagedType.BStr)] [In] string bstrDflags = "", [In] bool varfNewResultsCollection = false);

		// Token: 0x0600006F RID: 111
		[DispId(802)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SDVariables Diff([MarshalAs(UnmanagedType.BStr)] [In] string bstrLeft, [MarshalAs(UnmanagedType.BStr)] [In] string bstrRight, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFlags = "", [In] SDTT_TEXTTYPE eForceTextual = SDTT_TEXTTYPE.SDTT_NONTEXT);

		// Token: 0x06000070 RID: 112
		[DispId(803)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void DetectType([MarshalAs(UnmanagedType.BStr)] [In] string bstrFile, [MarshalAs(UnmanagedType.Struct)] out object pvarTextual, [MarshalAs(UnmanagedType.Struct)] out object pvarType);

		// Token: 0x06000071 RID: 113
		[DispId(804)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Set([MarshalAs(UnmanagedType.BStr)] [In] string bstrVar, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue = "", [In] bool varfMachine = false, [MarshalAs(UnmanagedType.BStr)] [In] string bstrService = "");

		// Token: 0x06000072 RID: 114
		[DispId(805)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SDVariables QuerySettings([MarshalAs(UnmanagedType.BStr)] [In] string bstrVar = "", [MarshalAs(UnmanagedType.BStr)] [In] string bstrService = "");
	}
}
