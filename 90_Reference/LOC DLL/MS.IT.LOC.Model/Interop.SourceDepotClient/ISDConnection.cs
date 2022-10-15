using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000004 RID: 4
	[TypeLibType(4160)]
	[Guid("BD4E7E4C-5B10-4293-93C1-426A44D816BB")]
	[ComImport]
	public interface ISDConnection
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000022 RID: 34
		// (set) Token: 0x06000023 RID: 35
		[DispId(700)]
		string Port { [DispId(700)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(700)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000024 RID: 36
		// (set) Token: 0x06000025 RID: 37
		[DispId(701)]
		string User { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000026 RID: 38
		// (set) Token: 0x06000027 RID: 39
		[DispId(702)]
		string Password { [DispId(702)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(702)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000028 RID: 40
		// (set) Token: 0x06000029 RID: 41
		[DispId(703)]
		string Client { [DispId(703)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(703)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42
		// (set) Token: 0x0600002B RID: 43
		[DispId(704)]
		string Host { [DispId(704)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(704)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002C RID: 44
		// (set) Token: 0x0600002D RID: 45
		[DispId(705)]
		string Auth { [DispId(705)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(705)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001A RID: 26
		// (set) Token: 0x0600002E RID: 46
		[DispId(706)]
		string DefinePort { [DispId(706)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001B RID: 27
		// (set) Token: 0x0600002F RID: 47
		[DispId(707)]
		string DefineUser { [DispId(707)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001C RID: 28
		// (set) Token: 0x06000030 RID: 48
		[DispId(708)]
		string DefinePassword { [DispId(708)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001D RID: 29
		// (set) Token: 0x06000031 RID: 49
		[DispId(709)]
		string DefineClient { [DispId(709)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001E RID: 30
		// (set) Token: 0x06000032 RID: 50
		[DispId(710)]
		string DefineHost { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700001F RID: 31
		// (set) Token: 0x06000033 RID: 51
		[DispId(711)]
		string DefineAuth { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000034 RID: 52
		[DispId(712)]
		string Diff { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000035 RID: 53
		[DispId(713)]
		string FileEditor { [DispId(713)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000036 RID: 54
		[DispId(714)]
		string FormEditor { [DispId(714)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000037 RID: 55
		[DispId(715)]
		string Merge { [DispId(715)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000038 RID: 56
		[DispId(716)]
		string Pager { [DispId(716)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000039 RID: 57
		[DispId(717)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SDConnection Clone();

		// Token: 0x0600003A RID: 58
		[DispId(718)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void LoadIniFile([MarshalAs(UnmanagedType.BStr)] [In] string bstrFilename = "", [In] bool varfReset = false);

		// Token: 0x0600003B RID: 59
		[DispId(720)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddArg([MarshalAs(UnmanagedType.BStr)] [In] string bstrNewArg);

		// Token: 0x0600003C RID: 60
		[DispId(721)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SDResults Run([MarshalAs(UnmanagedType.BStr)] [In] string bstrFunc, [In] bool varfStructured = false, [In] bool varfNewResultsCollection = false);

		// Token: 0x0600003D RID: 61
		[DispId(722)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Disconnect();

		// Token: 0x0600003E RID: 62
		[DispId(723)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void CancelCommand();

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600003F RID: 63
		[DispId(724)]
		bool Connected { [DispId(724)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000040 RID: 64
		// (set) Token: 0x06000041 RID: 65
		[DispId(725)]
		object SpecData { [DispId(725)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(725)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }
	}
}
