using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000008 RID: 8
	[Guid("2B34362F-CEB2-4A47-BB10-7E4598668ADD")]
	[TypeLibType(4160)]
	[ComImport]
	public interface ISDCommandOutput
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000050 RID: 80
		[DispId(400)]
		SDCB_CALLBACKTYPE Type { [DispId(400)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000051 RID: 81
		[DispId(401)]
		int Length { [DispId(401)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000052 RID: 82
		[DispId(402)]
		string Message { [DispId(402)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000053 RID: 83
		[DispId(403)]
		object Data { [DispId(403)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000054 RID: 84
		[DispId(404)]
		SDVariables Variables { [DispId(404)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
