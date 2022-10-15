using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000C RID: 12
	[Guid("539AF630-DFD7-48C4-AB0A-7464D3FA284B")]
	[TypeLibType(4160)]
	[ComImport]
	public interface ISDSpecData
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000061 RID: 97
		[DispId(200)]
		SDVariables Schema { [DispId(200)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06000062 RID: 98
		[DispId(201)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ParseSpec([MarshalAs(UnmanagedType.BStr)] [In] string bstrSpec);

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000063 RID: 99
		[DispId(202)]
		string FormattedSpec { [DispId(202)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000045 RID: 69
		[DispId(0)]
		object this[[MarshalAs(UnmanagedType.BStr)] [In] string bstrName]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: MarshalAs(UnmanagedType.Struct)]
			[param: In]
			set;
		}
	}
}
