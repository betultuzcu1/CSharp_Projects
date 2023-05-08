using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Regtangle:Shape
    {
        public double Height { get; set; }
        public double Weidht { get; set; }

        public Regtangle(double _height,double _weidht) 
        { 
            Height = _height;
            Weidht = _weidht;
        }

        public override double Area()
        {
            return Height * Weidht;
        }
    }
}
