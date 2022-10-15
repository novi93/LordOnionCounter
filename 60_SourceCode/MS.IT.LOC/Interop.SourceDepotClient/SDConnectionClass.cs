using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SourceDepotClient
{
	// Token: 0x02000002 RID: 2
	[Guid("877AA945-1CB2-411C-ACD7-C70B1F9E2E32")]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(2)]
	[ComImport]
	public class SDConnectionClass : ISDConnection, SDConnection
	{
		// Token: 0x06000001 RID: 1
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern SDConnectionClass();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2
		// (set) Token: 0x06000003 RID: 3
		[DispId(700)]
		public virtual extern string Port { [DispId(700)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(700)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		// (set) Token: 0x06000005 RID: 5
		[DispId(701)]
		public virtual extern string User { [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(701)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		[DispId(702)]
		public virtual extern string Password { [DispId(702)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(702)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8
		// (set) Token: 0x06000009 RID: 9
		[DispId(703)]
		public virtual extern string Client { [DispId(703)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(703)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10
		// (set) Token: 0x0600000B RID: 11
		[DispId(704)]
		public virtual extern string Host { [DispId(704)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(704)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000D RID: 13
		[DispId(705)]
		public virtual extern string Auth { [DispId(705)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(705)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600000E RID: 14
		[DispId(706)]
		public virtual extern string DefinePort { [DispId(706)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600000F RID: 15
		[DispId(707)]
		public virtual extern string DefineUser { [DispId(707)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000010 RID: 16
		[DispId(708)]
		public virtual extern string DefinePassword { [DispId(708)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000011 RID: 17
		[DispId(709)]
		public virtual extern string DefineClient { [DispId(709)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000012 RID: 18
		[DispId(710)]
		public virtual extern string DefineHost { [DispId(710)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000013 RID: 19
		[DispId(711)]
		public virtual extern string DefineAuth { [DispId(711)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000014 RID: 20
		[DispId(712)]
		public virtual extern string Diff { [DispId(712)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000015 RID: 21
		[DispId(713)]
		public virtual extern string FileEditor { [DispId(713)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000016 RID: 22
		[DispId(714)]
		public virtual extern string FormEditor { [DispId(714)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000017 RID: 23
		[DispId(715)]
		public virtual extern string Merge { [DispId(715)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000018 RID: 24
		[DispId(716)]
		public virtual extern string Pager { [DispId(716)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000019 RID: 25
		[DispId(717)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern SDConnection Clone();

		// Token: 0x0600001A RID: 26
		[DispId(718)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void LoadIniFile([MarshalAs(UnmanagedType.BStr)] [In] string bstrFilename = "", [In] bool varfReset = false);

		// Token: 0x0600001B RID: 27
		[DispId(720)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void AddArg([MarshalAs(UnmanagedType.BStr)] [In] string bstrNewArg);

		// Token: 0x0600001C RID: 28
		[DispId(721)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern SDResults Run([MarshalAs(UnmanagedType.BStr)] [In] string bstrFunc, [In] bool varfStructured = false, [In] bool varfNewResultsCollection = false);

		// Token: 0x0600001D RID: 29
		[DispId(722)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Disconnect();

		// Token: 0x0600001E RID: 30
		[DispId(723)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void CancelCommand();

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001F RID: 31
		[DispId(724)]
		public virtual extern bool Connected { [DispId(724)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000020 RID: 32
		// (set) Token: 0x06000021 RID: 33
		[DispId(725)]
		public virtual extern object SpecData { [DispId(725)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(725)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Struct)] [param: In] set; }
	}
}
