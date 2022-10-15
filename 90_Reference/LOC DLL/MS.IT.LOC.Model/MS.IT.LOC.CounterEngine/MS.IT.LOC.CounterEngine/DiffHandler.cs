using System;
using System.Collections;
using System.IO;

namespace MS.IT.LOC.CounterEngine
{
	// Token: 0x0200000E RID: 14
	internal class DiffHandler
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00003CE8 File Offset: 0x00002CE8
		internal DiffHandler()
		{
			this.fileName = "";
			this.diffLines = new ArrayList();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003D78 File Offset: 0x00002D78
		internal DiffHandler(string sFileName)
		{
			if (File.Exists(sFileName))
			{
				this.fileName = sFileName;
				this.diffLines.Clear();
				this.loadFile();
			}
			else
			{
				this.fileName = "";
				this.diffLines.Clear();
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003E30 File Offset: 0x00002E30
		private void loadFile()
		{
			try
			{
				using (StreamReader streamReader = File.OpenText(this.fileName))
				{
					int num = 2;
					int num2 = 0;
					string text = streamReader.ReadLine();
					while (text != null)
					{
						if (num2 >= num)
						{
							this.diffLines.Add(text);
						}
						text = streamReader.ReadLine();
						num2++;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003EC8 File Offset: 0x00002EC8
		public string FileName
		{
			get
			{
				return this.fileName;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003EE0 File Offset: 0x00002EE0
		public ArrayList GetLinesAt(int lineNumber, out FileChangeType type, out ArrayList baseChangeList)
		{
			type = FileChangeType.NoChange;
			bool flag = false;
			ArrayList arrayList = new ArrayList();
			baseChangeList = new ArrayList();
			foreach (object obj in this.diffLines)
			{
				string text = (string)obj;
				if (((type == FileChangeType.Deleted) ? this.ignoreCharactersForDeleted : this.ignoreCharacters).IndexOf(text.Substring(0, 1).ToUpper()) < 0)
				{
					if (!(text.Substring(0, 1) == "\\"))
					{
						if (flag)
						{
							if (text.Trim().IndexOf(this.acceptChar) == 0)
							{
								arrayList.Add(text.Trim().Substring(1));
							}
							else if (type == FileChangeType.Deleted && text.Trim().IndexOf(this.acceptCharForDeleted) == 0)
							{
								baseChangeList.Add(text.Trim().Substring(1));
							}
							else
							{
								if (type != FileChangeType.Modified || text.Trim().IndexOf(this.acceptCharForDeleted) != 0)
								{
									break;
								}
								baseChangeList.Add(text.Trim().Substring(1));
							}
						}
						else if (char.IsDigit(text, 0))
						{
							if (text.IndexOfAny(this.validChars) > 0)
							{
								string[] array = text.Substring(0, text.IndexOfAny(this.validChars)).Split(this.separator);
								int num = int.Parse(array[0]);
								int num2 = -1;
								if (array.Length > 1)
								{
									num2 = int.Parse(array[1]);
								}
								if (num > lineNumber)
								{
									break;
								}
								if (num < lineNumber)
								{
									if (lineNumber != 1 || num != 0)
									{
										if (lineNumber > num2)
										{
											continue;
										}
									}
								}
								string text2 = text.Substring(text.IndexOfAny(this.validChars), 1);
								if (text2 != null)
								{
									if (!(text2 == "a"))
									{
										if (!(text2 == "c"))
										{
											if (text2 == "d")
											{
												type = FileChangeType.Deleted;
											}
										}
										else
										{
											type = FileChangeType.Modified;
										}
									}
									else
									{
										type = FileChangeType.Added;
									}
								}
								flag = true;
								if (lineNumber <= num2 && lineNumber > num)
								{
									break;
								}
							}
						}
					}
				}
			}
			return arrayList;
		}

		// Token: 0x04000043 RID: 67
		private string fileName;

		// Token: 0x04000044 RID: 68
		private ArrayList diffLines = new ArrayList();

		// Token: 0x04000045 RID: 69
		private string ignoreCharacters = "-=ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		// Token: 0x04000046 RID: 70
		private string ignoreCharactersForDeleted = ">-=ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		// Token: 0x04000047 RID: 71
		private char[] validChars = new char[]
		{
			'a',
			'c',
			'd'
		};

		// Token: 0x04000048 RID: 72
		private char[] separator = new char[]
		{
			','
		};

		// Token: 0x04000049 RID: 73
		private char acceptChar = '>';

		// Token: 0x0400004A RID: 74
		private char acceptCharForDeleted = '<';
	}
}
