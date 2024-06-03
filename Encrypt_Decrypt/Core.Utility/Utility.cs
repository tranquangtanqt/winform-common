using System;
using System.Text;

namespace Common.Core.Utility
{
    public class Utility : ApplicationException
	{
		public static bool IsEqualsWithIgnoreCase(string value1, string value2)
		{
			string a = value1 ?? "";
			string b = value2 ?? "";
			return string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
		}

		public static string String2Json(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			char[] array = s.ToCharArray();
			int i = 0;
			while (i < array.Length)
			{
				char c = array[i];
				char c2 = c;
				if (c2 <= '"')
				{
					switch (c2)
					{
						case '\b':
							stringBuilder.Append("\\b");
							break;
						case '\t':
							stringBuilder.Append("\\t");
							break;
						case '\n':
							stringBuilder.Append("\\n");
							break;
						case '\v':
							goto IL_E9;
						case '\f':
							stringBuilder.Append("\\f");
							break;
						case '\r':
							stringBuilder.Append("\\r");
							break;
						default:
							if (c2 != '"')
							{
								goto IL_E9;
							}
							stringBuilder.Append("\\\"");
							break;
					}
				}
				else if (c2 != '\'')
				{
					if (c2 != '/')
					{
						if (c2 != '\\')
						{
							goto IL_E9;
						}
						stringBuilder.Append("\\\\");
					}
					else
					{
						stringBuilder.Append("\\/");
					}
				}
				else
				{
					stringBuilder.Append("\\'");
				}
				IL_F1:
				i++;
				continue;
				IL_E9:
				stringBuilder.Append(c);
				goto IL_F1;
			}
			return stringBuilder.ToString();
		}
	}
}
