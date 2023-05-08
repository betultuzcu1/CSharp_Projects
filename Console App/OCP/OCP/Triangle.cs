using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double _baseLength, double _height)
        {
            BaseLength = _baseLength;
            Height = _height;
        }

        public override double Area()
        {
            return (BaseLength * Height) / 2;
        }
    }
}
