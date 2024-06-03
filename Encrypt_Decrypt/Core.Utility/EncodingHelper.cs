namespace Common.Core.Utility
{
    public static class EncodingHelper
	{
		public static bool ContainSBC(string value)
		{
			char[] array = value.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < ' ' || array[i] > '~')
				{
					return true;
				}
			}
			return false;
		}

		public static string ToSBC(string value)
		{
			char[] array = value.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == ' ')
				{
					array[i] = '\u3000';
				}
				else if (array[i] < '\u007f')
				{
					array[i] += 'ﻠ';
				}
			}
			return new string(array);
		}

		public static string ToDBC(string value)
		{
			char[] array = value.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == '\u3000')
				{
					array[i] = ' ';
				}
				else if (array[i] > '＀' && array[i] < '｟')
				{
					array[i] -= 'ﻠ';
				}
			}
			return new string(array);
		}

		public static string ToHexString(byte[] bytes)
		{
			char[] array = new char[]
			{
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'a',
				'b',
				'c',
				'd',
				'e',
				'f'
			};
			char[] array2 = new char[bytes.Length * 2];
			for (int i = 0; i < bytes.Length; i++)
			{
				int num = (int)bytes[i];
				array2[i * 2] = array[num >> 4];
				array2[i * 2 + 1] = array[num & 15];
			}
			return new string(array2);
		}

		public static string LeftFillCharacters(this string value, char character, int length)
		{
			if (value.Length >= length)
			{
				return value;
			}
			return new string(character, length - value.Length) + value;
		}

		public static string RightFillCharacters(this string value, char character, int length)
		{
			if (value.Length >= length)
			{
				return value;
			}
			return value + new string(character, length - value.Length);
		}

		public static string LeftFillSpaces(this string value, int length)
		{
			return value.LeftFillCharacters(' ', length);
		}

		public static string RightFillSpaces(this string value, int length)
		{
			return value.RightFillCharacters(' ', length);
		}
	}
}
