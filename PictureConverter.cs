using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Example1
{
    public class PictureConverter
    {
        public const int DEFAULT_CONVERTED_IMAGE_SIDE = 15;
        public const int DEFAULT_CONVERTED_IMAGE_SIZE = DEFAULT_CONVERTED_IMAGE_SIDE * DEFAULT_CONVERTED_IMAGE_SIDE;

        public int Boundary { get; set; } = 128;
        public int Height { get; set; }
        public int Width { get; set; }
        public int ConvertedImageSide { get; set; } = DEFAULT_CONVERTED_IMAGE_SIDE;

        //public double[] Convert(string path)
        public List<int>Convert(string path)
        {
            //var result = new List<double>();
            var result = new List<int>();
            //считываем изображение
            var image = new Bitmap(path);
            var resizeImage = new Bitmap(image, new Size(ConvertedImageSide, ConvertedImageSide));
            Height = resizeImage.Height;
            Width = resizeImage.Width;

            for(int y = 0; y < resizeImage.Height; y++)
            {
                for(int x = 0; x < resizeImage.Width; x++)
                {
                    var pixel = resizeImage.GetPixel(x, y);
                    var value = Brightness(pixel);
                    result.Add(value);
                }
            }
            return result;
            //return result.ToArray();
        }

        private int Brightness(Color pixel)
        {
            //превращение картинки в черно-белую из цветной
            var result = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
            return result < Boundary ? 0 : 1;
        }

        public void Save(string path, List<int> pixels)
        {
           
            var image = new Bitmap(Width, Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var color = pixels[y * Width + x] == 1 ? Color.White : Color.Black;
                    image.SetPixel(x, y, color);
                }
            }

            image.Save(path);
        }

        // преобразует массив пикселей в изображение для формы
        public Bitmap ToBitmap(List<int> pixels)
        {
            var image = new Bitmap(Width, Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var color = pixels[y * Width + x] == 1 ? Color.White : Color.Black;
                    image.SetPixel(x, y, color);
                }
            }

            return image;
        }
    }
}

