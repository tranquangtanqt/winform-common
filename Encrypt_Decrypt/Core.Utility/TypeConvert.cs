using System;
using System.Globalization;

namespace Common.Core.Utility
{
	public static class TypeConvert
	{
		public static string ToString(object value)
		{
			if (value is double)
			{
				return ((double)value).ToString("0.##############################");
			}
			return Convert.ToString(value);
		}

		public static int ToInt32(object value)
		{
			if (value is string)
			{
				return int.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands);
			}
			return Convert.ToInt32(value);
		}

		public static int ToInt32(object value, IFormatProvider formatProvider)
		{
			if (value is string)
			{
				return int.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands, formatProvider);
			}
			return Convert.ToInt32(value, formatProvider);
		}

		public static bool TryToInt32(string value, out int result)
		{
			return int.TryParse(value, out result);
		}

		public static bool TryToDouble(string value, out double result)
		{
			return double.TryParse(value, out result);
		}

		public static double ToDouble(object value)
		{
			if (value is string)
			{
				return double.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent);
			}
			return Convert.ToDouble(value);
		}

		public static double ToDouble(object value, IFormatProvider formatProvider)
		{
			if (value is string)
			{
				return double.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, formatProvider);
			}
			return Convert.ToDouble(value, formatProvider);
		}

		public static decimal ToDecimal(object value)
		{
			if (value is string)
			{
				return decimal.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent);
			}
			return Convert.ToDecimal(value);
		}

		public static decimal ToDecimal(object value, IFormatProvider formatProvider)
		{
			if (value is string)
			{
				return decimal.Parse((string)value, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, formatProvider);
			}
			return Convert.ToDecimal(value, formatProvider);
		}

		public static decimal ToDecimalWithInvariant(string value, decimal defVal)
		{
			decimal result = 0m;
			if (decimal.TryParse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out result))
			{
				return result;
			}
			return defVal;
		}

		public static double ToDoubleWithInvariant(string value, double defVal)
		{
			double result = 0.0;
			if (double.TryParse(value, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out result))
			{
				return result;
			}
			return defVal;
		}

		public static string ToStringWithInvariant(decimal value)
		{
			return Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		public static string ToStringWithInvariant(double value)
		{
			return Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		public static object ToExcelDateTime(DateTime dateTime)
		{
			if (dateTime == DateTime.MinValue)
			{
				return null;
			}
			return dateTime;
		}

		public static DateTime? ToNullableDate(DateTime date)
		{
			if (date == DateTime.MinValue)
			{
				return null;
			}
			return new DateTime?(date);
		}

		public static DateTime NullableToDate(DateTime? date)
		{
			if (date != null)
			{
				return date.Value;
			}
			return DateTime.MinValue;
		}

		public static DateTime StringToDate(string strDate)
		{
			if (string.IsNullOrEmpty(strDate))
			{
				return DateTime.MinValue;
			}
			return DateTime.Parse(strDate);
		}

		public static DateTime StringToDate(string strDate, string shortDatePattern)
		{
			if (string.IsNullOrEmpty(strDate))
			{
				return DateTime.MinValue;
			}
			return DateTime.Parse(strDate, new DateTimeFormatInfo
			{
				ShortDatePattern = shortDatePattern
			});
		}

		public static string DateToString(DateTime ctlDate)
		{
			if (ctlDate == DateTime.MinValue)
			{
				return string.Empty;
			}
			return ctlDate.ToString("yyyy/MM/dd");
		}

		public static bool StringToBool(string value)
		{
			bool result = false;
			int num;
			if (string.IsNullOrEmpty(value) || value == "0")
			{
				result = false;
			}
			else if (!bool.TryParse(value, out result) && int.TryParse(value, out num))
			{
				result = true;
			}
			return result;
		}

		public static string BoolToString(bool value)
		{
			if (value)
			{
				return "1";
			}
			return "0";
		}
	}
}
