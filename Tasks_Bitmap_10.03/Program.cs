using System.Drawing;
using Image = System.Drawing.Image;

namespace Tasks_Bitmap_10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] images = Directory.GetFiles(@"D:\TestOrdner\A");
            foreach (var image in images)
            {
                Task.Run(() => ChangeImage(image));
            }

            Console.ReadKey();
        }
        public static void ChangeImage(string pfad)
        {
            Image bild = Bitmap.FromFile(pfad);
            Bitmap bmpBild = new Bitmap(bild);

            int höhe = bmpBild.Height;
            int breite = bmpBild.Width;

            for (int y = 0; y < höhe; y++)
            {
                for (int x = 0; x < breite; x++)
                {

                    Color p = bmpBild.GetPixel(x, y);
                    int mittel = (p.R + p.G + p.B) / 3;
                    Color gp = Color.FromArgb(mittel, mittel, mittel);
                    bmpBild.SetPixel(x, y, gp);
                }
            }
            bmpBild.Save(pfad.ToString().Replace(".bmp", "1.bmp"));
            //bmpBild.Save(@"D:\TestOrdner\A\testtask.bmp");
            Console.WriteLine("task ok");
        }
    }
}