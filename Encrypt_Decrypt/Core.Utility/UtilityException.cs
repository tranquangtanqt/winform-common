using System;

namespace Common.Core.Utility
{
    public class UtilityException : ApplicationException
	{
		public UtilityException(string message) : base(message)
		{
		}

		public UtilityException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
