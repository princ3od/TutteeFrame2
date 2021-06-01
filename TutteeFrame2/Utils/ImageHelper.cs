using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace TutteeFrame2.Utils
{
    static class ImageHelper
    {
        public static Bitmap CropCircle(Image img)
        {
            var roundedImage = new Bitmap(img.Width, img.Height, img.PixelFormat);

            using (var g = Graphics.FromImage(roundedImage))
            using (var gp = new GraphicsPath())
            {
                g.Clear(Color.White);

                g.SmoothingMode = SmoothingMode.HighQuality;

                Brush brush = new TextureBrush(img);
                gp.AddEllipse(1, 1, img.Width - 2, img.Height - 2);
                g.FillPath(brush, gp);
                g.DrawPath(new Pen(Brushes.Black), gp);
            }

            return roundedImage;
        }
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
