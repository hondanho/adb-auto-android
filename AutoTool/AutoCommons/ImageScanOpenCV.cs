﻿using System.Drawing;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace AutoTool.AutoCommons
{
	internal class ImageScanOpenCV
	{
		public static Bitmap GetImage(string path)
		{
			using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
				return (Bitmap)Image.FromStream(fileStream);
			}
		}

		public static Bitmap Find(string main, string sub, double percent = 0.9)
		{
			Bitmap image = GetImage(main);
			Bitmap image2 = GetImage(sub);
			return Find(image, image2, percent);
		}

        public static Bitmap Find(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
        {
            Image<Bgr, byte> image = mainBitmap.ToImage<Bgr, byte>();
            Image<Bgr, byte> image2 = subBitmap.ToImage<Bgr, byte>();
            Image<Bgr, byte> image3 = image.Copy();
            using (Image<Gray, float> image4 = image.MatchTemplate(image2, TemplateMatchingType.CcoeffNormed))
            {
                double[] array;
                double[] array2;
                Point[] array3;
                Point[] array4;
                image4.MinMax(out array, out array2, out array3, out array4);
                bool flag = array2[0] > percent;
                if (flag)
                {
                    Rectangle rect = new Rectangle(array4[0], image2.Size);
                    image3.Draw(rect, new Bgr(Color.Red), 2, LineType.EightConnected, 0);
                }
                else
                {
                    image3 = null;
                }
            }
            return (image3 == null) ? null : image3.ToBitmap();
        }

        public static Point? FindOutImagePoint(Bitmap mainBitmap, Bitmap subBitmap, bool getMiddle = true, double percent = 0.9)
        {
            Image<Bgr, byte> image = mainBitmap.ToImage<Bgr, byte>();
            Image<Bgr, byte> template = subBitmap.ToImage<Bgr, byte>();
            Point? result = null;
            using (Image<Gray, float> image2 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
            {
                double[] array;
                double[] array2;
                Point[] array3;
                Point[] array4;
                image2.MinMax(out array, out array2, out array3, out array4);
                bool flag = array2[0] > percent;
                if (flag)
                {
                    var tmp = new Point?(array4[0]);
                    if (tmp != null)
                    {
                        if (getMiddle)
                        {
                            result = new Point(tmp.Value.X + template.Width / 2, tmp.Value.Y + template.Height / 2);
                        } 
                        else
                        {
                            result = new Point(tmp.Value.X, tmp.Value.Y);
                        }
                    }
                }
            }
            return result;
        }
        public static Point? FindOutImagePoint(string mainPath, string subPath, bool getMiddle = true)
        {
            Bitmap image = GetImage(mainPath);
            Bitmap image2 = GetImage(subPath);
            return FindOutImagePoint(image, image2, getMiddle);
        }

        public static ImagePoint FindOutPoint(string mainPath, string subPath, bool getMiddle = true)
        {
            ImagePoint result = null;
            Point? point = FindOutImagePoint(mainPath, subPath, getMiddle);
            if (point.HasValue)
            {
                result = new ImagePoint(point.Value);
            }
            return result;
        }
    }
}
