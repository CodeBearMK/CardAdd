using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAdd
{
    internal class Circle:Card
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override double area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
