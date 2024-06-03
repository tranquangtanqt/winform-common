using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common.Core.Utility.Security
{
    public class SymmetricAlgorithmHelper
	{
		public static string Encrypt(SymmetricAlgorithmType type, string key, string plainText)
		{
			SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithmHelper.GetSymmetricAlgorithm(type, key);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			StreamWriter streamWriter = new StreamWriter(cryptoStream, Encoding.UTF8);
			streamWriter.Write(plainText);
			streamWriter.Close();
			cryptoStream.Close();
			byte[] inArray = memoryStream.ToArray();
			memoryStream.Close();
			return Convert.ToBase64String(inArray);
		}

		public static string Decrypt(SymmetricAlgorithmType type, string key, string cypherText)
		{
			SymmetricAlgorithm symmetricAlgorithm = SymmetricAlgorithmHelper.GetSymmetricAlgorithm(type, key);
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cypherText));
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
			StreamReader streamReader = new StreamReader(cryptoStream, Encoding.UTF8);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			cryptoStream.Close();
			memoryStream.Close();
			return result;
		}

		private static SymmetricAlgorithm GetSymmetricAlgorithm(SymmetricAlgorithmType type, string key)
		{
			SymmetricAlgorithm result;
			switch (type)
			{
				case SymmetricAlgorithmType.DES:
					result = SymmetricAlgorithmHelper.DES(key);
					break;
				case SymmetricAlgorithmType.AES128:
					result = SymmetricAlgorithmHelper.AES128(key);
					break;
				case SymmetricAlgorithmType.AES256:
					result = SymmetricAlgorithmHelper.AES256(key);
					break;
				default:
					result = SymmetricAlgorithmHelper.DES(key);
					break;
			}
			return result;
		}

		private static SymmetricAlgorithm DES(string key)
		{
			byte[][] keyAndIV = SymmetricAlgorithmHelper.GetKeyAndIV(key, 8, 8);
			return new DESCryptoServiceProvider
			{
				Key = keyAndIV[0],
				IV = keyAndIV[1]
			};
		}

		private static SymmetricAlgorithm AES128(string key)
		{
			byte[][] keyAndIV = SymmetricAlgorithmHelper.GetKeyAndIV(key, 16, 16);
			return new AesManaged
			{
				Key = keyAndIV[0],
				IV = keyAndIV[1]
			};
		}

		private static SymmetricAlgorithm AES256(string key)
		{
			byte[][] keyAndIV = SymmetricAlgorithmHelper.GetKeyAndIV(key, 32, 16);
			return new AesManaged
			{
				KeySize = 256,
				Key = keyAndIV[0],
				IV = keyAndIV[1]
			};
		}

		private static byte[][] GetKeyAndIV(string key, int keySize, int ivSize)
		{
			int num = keySize + ivSize;
			byte[] hash;
			if (num != 16)
			{
				if (num != 32)
				{
					if (num != 48)
					{
						hash = HashAlgorithmHelper.GetHash(HashAlgorithmType.SHA512, key);
					}
					else
					{
						hash = HashAlgorithmHelper.GetHash(HashAlgorithmType.SHA384, key);
					}
				}
				else
				{
					hash = HashAlgorithmHelper.GetHash(HashAlgorithmType.SHA256, key);
				}
			}
			else
			{
				hash = HashAlgorithmHelper.GetHash(HashAlgorithmType.MD5, key);
			}
			byte[][] array = new byte[][]
			{
				new byte[keySize],
				new byte[ivSize]
			};
			for (int i = 0; i < keySize; i++)
			{
				array[0][i] = hash[i];
				if (i < ivSize)
				{
					array[1][i] = hash[i + keySize];
				}
			}
			return array;
		}
	}
}
