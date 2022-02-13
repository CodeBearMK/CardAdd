using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAdd
{
    internal class Rectangle:Card
    {
        public double High { get; set; }
        public double Width { get; set; }
        public Rectangle(double h, double w)
        {
            High = h;
            Width = w;
        }
        public override double area()
        {
            return High * Width;
        }
    }
}
