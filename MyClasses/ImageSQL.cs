using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace MyClassesLibrary
{
	public class ImageSQL
	{
		public static byte[] ImageToByteArray(Image imageIn)
		{
			var ms = new MemoryStream();
			imageIn.Save(ms, ImageFormat.Png);
			return ms.ToArray();
		}

		public static Image ByteArrayToImage(byte[] bytesArr)
		{
			var memstr = new MemoryStream(bytesArr);
			var img = Image.FromStream(memstr);
			return img;
		}
	}
}
