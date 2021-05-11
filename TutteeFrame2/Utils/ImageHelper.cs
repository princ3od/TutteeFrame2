using System.Drawing;
using System.IO;
using System.Linq;

namespace TutteeFrame2.Utils
{
    static class ImageHelper
    {
        public static Image BytesToImage(byte[] _data)
        {
            try
            {
                MemoryStream stream = new MemoryStream(_data);
                return Image.FromStream(stream);
            }
            catch
            {
                return null;
            }
        }
        public static byte[] ImageToBytes(Image _image)
        {
            if (_image == null)
                return null;

            try
            {
                using (var ms = new MemoryStream())
                {
                    _image.Save(ms, _image.RawFormat);
                    return ms.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool IsSameImage(Image _img1, Image _img2)
        {
            return ImageToBytes(_img1).SequenceEqual(ImageToBytes(_img2));
        }
    }
}
