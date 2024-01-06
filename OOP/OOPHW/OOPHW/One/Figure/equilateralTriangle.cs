using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    public class equilateralTriangle : scaleneTriangle
    {
        public equilateralTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override double GetArea()
        {
            return double.Sqrt(3) / 4 * double.Pow(A, 2);
        }
    }
}
