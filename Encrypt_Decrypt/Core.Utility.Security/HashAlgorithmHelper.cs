using System;
using System.Security.Cryptography;
using System.Text;

namespace Common.Core.Utility.Security
{
    public class HashAlgorithmHelper
	{
		public static byte[] GetHash(HashAlgorithmType hashTpye, string input)
		{
			HashAlgorithm hashAlgorithm;
			switch (hashTpye)
			{
				case HashAlgorithmType.MD5:
					hashAlgorithm = HashAlgorithmHelper.MD5();
					break;
				case HashAlgorithmType.SHA1:
					hashAlgorithm = HashAlgorithmHelper.SHA1();
					break;
				case HashAlgorithmType.SHA256:
					hashAlgorithm = HashAlgorithmHelper.SHA256();
					break;
				case HashAlgorithmType.SHA384:
					hashAlgorithm = HashAlgorithmHelper.SHA384();
					break;
				case HashAlgorithmType.SHA512:
					hashAlgorithm = HashAlgorithmHelper.SHA512();
					break;
				default:
					hashAlgorithm = HashAlgorithmHelper.MD5();
					break;
			}
			return hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
		}

		public static string GetHashBase64String(HashAlgorithmType type, string input)
		{
			return Convert.ToBase64String(HashAlgorithmHelper.GetHash(type, input));
		}

		public static string GetHashHexString(HashAlgorithmType type, string input)
		{
			return EncodingHelper.ToHexString(HashAlgorithmHelper.GetHash(type, input));
		}

		private static HashAlgorithm MD5()
		{
			return new MD5CryptoServiceProvider();
		}

		private static HashAlgorithm SHA1()
		{
			return new SHA1Managed();
		}

		private static HashAlgorithm SHA256()
		{
			return new SHA256Managed();
		}

		private static HashAlgorithm SHA384()
		{
			return new SHA384Managed();
		}

		private static HashAlgorithm SHA512()
		{
			return new SHA512Managed();
		}
	}
}
