using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    internal class scaleneTriangle : general
    {
        public double A;
        public double B;
        public double C;

        private double P => (A + B + C) / 2;

        public scaleneTriangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        
        //формула Герона
        public override double GetArea() 
        {
            return double.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
}
