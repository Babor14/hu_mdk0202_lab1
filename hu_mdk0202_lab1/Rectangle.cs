using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hu_mdk0202_lab1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override Shape Clone()
        {
            return new Rectangle(Width, Height);
        }

        public override string ToString()
        {
            return $"Rectangle with width: {Width} and height: {Height}";
        }

    }
}
