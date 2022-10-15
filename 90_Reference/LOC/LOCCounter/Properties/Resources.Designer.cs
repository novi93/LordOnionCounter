using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MS.IT.LOC.UI.Properties
{
	// Token: 0x0200002A RID: 42
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00021F91 File Offset: 0x00020F91
		internal Resources()
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00021F9C File Offset: 0x00020F9C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("MS.IT.LOC.UI.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00021FE8 File Offset: 0x00020FE8
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00021FFF File Offset: 0x00020FFF
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00022008 File Offset: 0x00021008
		internal static Bitmap ErrorPic
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("ErrorPic", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040001F1 RID: 497
		private static ResourceManager resourceMan;

		// Token: 0x040001F2 RID: 498
		private static CultureInfo resourceCulture;
	}
}
