using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace PA.PersianUtils.ImageUtils
{
    public static class Imaging
    {
        public static byte[] ToByte(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            try
            {
                int len = (int)fs.Length;
                byte[] imageData = new byte[len];
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = null;
                    try
                    {
                        fs.Read(imageData, 0, len);
                    }
                    finally
                    {
                        try
                        {
                            ms.Write(imageData, 0, len);
                        }
                        finally
                        {

                            img = Image.FromStream(ms);
                            imageData = ms.ToArray();
                        }
                        ms.Flush();
                        ms.Close();
                    }
                    return imageData;
                }
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        public static Image FromFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                int len = (int)fs.Length;
                byte[] imageData = new byte[len];
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = null;
                    try
                    {
                        fs.Read(imageData, 0, len);
                    }
                    finally
                    {
                        try
                        {
                            ms.Write(imageData, 0, len);
                        }
                        finally
                        {
                            img = Image.FromStream(ms);
                        }
                        ms.Flush();
                        ms.Close();
                    }


                    return img;
                }
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
        public static byte[] ToByte(Image image)
        {
            ImageConverter imageConverter = new ImageConverter();
            return (Byte[])imageConverter.ConvertTo(image, typeof(Byte[]));
        }
        public static byte[] ToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            ImageConverter imageConverter = new ImageConverter();
            return (Byte[])imageConverter.ConvertTo(image, typeof(Byte[]));
        }
        public static Image FromByteArray(byte[] buffer)
        {
            if (buffer == null)
                return null;
            System.Drawing.ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(buffer);
            return img;
        }
        public static Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBitmap =
            new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBitmap);
            ColorMatrix colorMatrix = new ColorMatrix(
            new float[][]
            {
            new float[] { .3f, .3f, .3f, 0, 0 },
            new float[] { .59f, .59f, .59f, 0, 0 },
            new float[] { .11f, .11f, .11f, 0, 0 },
            new float[] { 0, 0, 0, 1, 0 },
            new float[] { 0, 0, 0, 0, 1 }
            }
            );
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);
            g.DrawImage(original,
            new Rectangle(0, 0, original.Width, original.Height),
            0, 0, original.Width, original.Height,
            GraphicsUnit.Pixel, attributes);
            g.Dispose();
            return newBitmap;
        }
        public static Image ConvertImageToARGB(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(img, 0, 0);

            return bmp;
        }
        public static Image ZoomImage(Image input, Rectangle zoomArea, Rectangle sourceArea)
        {
            Bitmap newBmp = new Bitmap(sourceArea.Width, sourceArea.Height);

            using (Graphics g = Graphics.FromImage(newBmp))
            {
                //high interpolation
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(input, sourceArea, zoomArea, GraphicsUnit.Pixel);
            }

            return newBmp;
        }
        public static Image MarkImage(Image input, Rectangle selectedArea, Color selectColor)
        {
            Bitmap newImg = new Bitmap(input.Width, input.Height);

            using (Graphics g = Graphics.FromImage(newImg))
            {
                //Prevent using images internal thumbnail
                input.RotateFlip(RotateFlipType.Rotate180FlipNone);
                input.RotateFlip(RotateFlipType.Rotate180FlipNone);

                g.DrawImage(input, 0, 0);

                //Draw the selection rect
                using (Pen p = new Pen(selectColor))
                    g.DrawRectangle(p, selectedArea);
            }

            return (Image)newImg;
        }
        public static Image ResizeImage(Image input, Size newSize, InterpolationMode interpolation)
        {
            Bitmap newImg = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics g = Graphics.FromImage(newImg))
            {
                //Prevent using images internal thumbnail
                input.RotateFlip(RotateFlipType.Rotate180FlipNone);
                input.RotateFlip(RotateFlipType.Rotate180FlipNone);

                //Interpolation
                g.InterpolationMode = interpolation;

                //Draw the image with the new dimensions
                g.DrawImage(input, 0, 0, newSize.Width, newSize.Height);
            }

            return (Image)newImg;
        }
        public static Color GetDominantColor(Bitmap bmp, bool includeAlpha)
        {
            // GDI+ still lies to us - the return format is BGRA, NOT ARGB.
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite,
            PixelFormat.Format32bppArgb);

            int stride = bmData.Stride;
            IntPtr Scan0 = bmData.Scan0;

            int r = 0;
            int g = 0;
            int b = 0;
            int a = 0;
            int total = 0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - bmp.Width * 4;
                int nWidth = bmp.Width;

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < nWidth; x++)
                    {
                        r += p[0];
                        g += p[1];
                        b += p[2];
                        a += p[3];

                        total++;

                        p += 4;
                    }
                    p += nOffset;
                }
            }

            bmp.UnlockBits(bmData);

            r /= total;
            g /= total;
            b /= total;
            a /= total;

            if (includeAlpha)
                return Color.FromArgb(a, r, g, b);
            else
                return Color.FromArgb(r, g, b);
        }
        public static Color CalculateOppositeColor(Color clr)
        {
            return Color.FromArgb(255 - clr.R, 255 - clr.G, 255 - clr.B);
        }
        public static Size ShrinkToDimensions(int originalWidth, int originalHeight, int maxWidth, int maxHeight)
        {
            int newWidth = 0;
            int newHeight = 0;

            if (originalWidth >= originalHeight)
            {
                //Match area width to max width
                if (originalWidth <= maxWidth)
                {
                    newWidth = originalWidth;
                    newHeight = originalHeight;
                }
                else
                {
                    newWidth = maxWidth;
                    newHeight = originalHeight * maxWidth / originalWidth;
                }
            }
            else
            {
                //Match area height to max height
                if (originalHeight <= maxHeight)
                {
                    newWidth = originalWidth;
                    newHeight = originalHeight;
                }
                else
                {
                    newWidth = originalWidth * maxHeight / originalHeight;
                    newHeight = maxHeight;
                }
            }

            return new Size(newWidth, newHeight);
        }
        public static Image ResizePictureArea(Image img)
        {
            //Create a thumbnail image (maintaining aspect ratio)

            Size newSize = ShrinkToDimensions(img.Width, img.Height, 160, 130);

            //use low interpolation
            return ResizeImage(img, new Size(newSize.Width, newSize.Height), InterpolationMode.Low);
        }
        public static Image FromString(string content)
        {
            Bitmap objBmpImage = new Bitmap(1, 1);
            int intWidth = 0;
            int intHeight = 0;
            // Create the Font object for the image text drawing.
            Font objFont = new Font("Arial", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            // This is where the bitmap size is determined.
            intWidth = (int)objGraphics.MeasureString(content, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(content, objFont).Height;
            //reate the bmpImage again with the correct size for the text and font.
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));
            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(objBmpImage);
            // Set Background color
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(content, objFont, new SolidBrush(Color.FromArgb(102, 102, 102)), 0, 0);
            objGraphics.Flush();
            return (objBmpImage);

        }
    }
}
