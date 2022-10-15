using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter.My.Resources
{
	// Token: 0x02000005 RID: 5
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002198 File Offset: 0x00000398
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("CLOC_Couter.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021E0 File Offset: 0x000003E0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021F7 File Offset: 0x000003F7
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002200 File Offset: 0x00000400
		internal static byte[] cloc
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("cloc", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002234 File Offset: 0x00000434
		internal static string Config
		{
			get
			{
				return Resources.ResourceManager.GetString("Config", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000225C File Offset: 0x0000045C
		internal static string RuleCounter
		{
			get
			{
				return Resources.ResourceManager.GetString("RuleCounter", Resources.resourceCulture);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002284 File Offset: 0x00000484
		internal static Bitmap timg11
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("timg11", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x04000006 RID: 6
		private static ResourceManager resourceMan;

		// Token: 0x04000007 RID: 7
		private static CultureInfo resourceCulture;
	}
}
