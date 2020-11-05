using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Controlador
{
    public static class Tools
    {
        public static double GetPeso(Image img)
        {
            long tamanoImagen = 0;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                tamanoImagen = ms.Length;
            }
            //El tamaño está en bytes.
            return tamanoImagen;
        }
        public static Image ResizeImage(Image srcImage, int newWidth)
        {
            int newHeight = 9 * (newWidth / 16);
            using (Bitmap imagenBitmap =
               new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(
                   Convert.ToInt32(srcImage.HorizontalResolution),
                   Convert.ToInt32(srcImage.HorizontalResolution));

                using (Graphics imagenGraphics =
                        Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode =
                       SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode =
                       InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode =
                       PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage,
                       new Rectangle(0, 0, newWidth, newHeight),
                       new Rectangle(0, 0, srcImage.Width, srcImage.Height),
                       GraphicsUnit.Pixel);
                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
                    srcImage = Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImage;
        }
        public static Bitmap CortarImagen(Image img, Rectangle area)
        {
            Bitmap bmp = new Bitmap(area.Width, area.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(img, 0, 0, area, GraphicsUnit.Pixel);

            return bmp;
        }
    }
}
