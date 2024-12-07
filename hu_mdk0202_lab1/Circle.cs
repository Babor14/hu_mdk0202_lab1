using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hu_mdk0202_lab1
{
    public  class Circle :Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override Shape Clone()
        {
            return new Circle(Radius);
        }

        public override string ToString()
        {
            return $"Circle with radius: {Radius}";
        }
    }
}
