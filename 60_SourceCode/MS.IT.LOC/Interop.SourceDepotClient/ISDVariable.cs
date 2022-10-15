using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x0200000B RID: 11
	[Guid("175F36F5-E3AB-4C85-93EA-2488E9228E41")]
	[TypeLibType(4160)]
	[DefaultMember("Value")]
	[ComImport]
	public interface ISDVariable
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600005C RID: 92
		[DispId(0)]
		//[IndexerName("Value")] TODO
		string Value { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600005D RID: 93
		[DispId(100)]
		string Name { [DispId(100)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600005E RID: 94
		[DispId(101)]
		int Length { [DispId(101)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600005F RID: 95
		[DispId(102)]
		object SourceValue { [DispId(102)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000060 RID: 96
		[DispId(103)]
		bool IsUnicode { [DispId(103)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
