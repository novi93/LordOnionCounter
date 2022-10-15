using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace CLOC_Couter
{
	// Token: 0x0200000E RID: 14
	public class Main
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public static void Main(string[] Args)
		{
			bool flag = Args.Length == 0;
			if (flag)
			{
				frmCounterLOC frmCounterLOC = new frmCounterLOC();
				frmCounterLOC.ShowDialog();
			}
			else
			{
				foreach (string text in Args)
				{
					string text2 = text.Substring(0, Strings.InStr(1, text, ":", CompareMethod.Binary));
					string left = Strings.Trim(text2);
					if (Operators.CompareString(left, "/Listfile:", false) == 0)
					{
						Interaction.MsgBox(text.Substring(text2.Length, checked(text.Length - text2.Length)), MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}
	}
}
