using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Square:Shape
    {
        public double Edge { get; set; }

        public  Square(double _edge) 
        { 
            Edge = _edge; 
        }

        public override double Area()
        {
            return Edge * Edge;
        }
    }
}
