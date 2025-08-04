using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BasicFacebookFeatures
{
	internal static class Cloner
	{
		public static T DeepClone<T>(this T i_ToClone) where T : class
		{
			using(MemoryStream stream = new MemoryStream())
			{
				BinaryFormatter formatter = new BinaryFormatter();

				formatter.Serialize(stream, i_ToClone);
				stream.Flush();
				stream.Seek(0, SeekOrigin.Begin);
				T clonedT = formatter.Deserialize(stream) as T;

				return clonedT;
			}
		}
	}
}