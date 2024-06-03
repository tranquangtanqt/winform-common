using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Utility
{
	public static class SerializationHelper
	{
		public static byte[] Serialize(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, obj);
			return memoryStream.GetBuffer();
		}

		public static object Deserialize(byte[] buffer)
		{
			if (buffer == null)
			{
				return null;
			}
			MemoryStream serializationStream = new MemoryStream(buffer);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			return binaryFormatter.Deserialize(serializationStream);
		}
	}
}
