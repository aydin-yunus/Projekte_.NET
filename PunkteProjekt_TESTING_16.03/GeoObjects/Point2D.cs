using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkteProjekt_TESTING_16._03.GeoObjects
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D() {X=Y=0;}
        public Point2D(int x, int y){ X = x; Y = y; }
        public void Move(int offset)
        {
            X += offset;
            Y += offset;
        }
        public void Move(int xoffset, int yoffset)
        {
            X += xoffset;
            Y += yoffset;
        }
        public double GetDistance() { return Math.Sqrt(X*X + Y*Y); }
        public override string ToString()
        {
            return string.Format("{0},{1}",X,Y);
        }

    }
}
