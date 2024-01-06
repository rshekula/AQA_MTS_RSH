using OOPHW.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class CreateTriangle
    {
        public static scaleneTriangle CrTriangle(double a, double b, double c)
        {
            if (a.Equals(0) || b.Equals(0) || c.Equals(0))
            {
                throw new Exception("Невозможно построить треугольник со стороной 0");
            }

            if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
            {
                throw new Exception(
                    "Невозможно построить треугольник с заданными сторонами. Для создания треугольника необходимо, чтобы сумма длин двух сторон была больше длины третьей стороны.");
            }

            if (a.Equals(b) && a.Equals(c))
            {
                return new equilateralTriangle(a, b, c);
            }

            if (
                (a * a).Equals(b * b + c * c) ||
                (b * b).Equals(a * a + c * c) ||
                (c * c).Equals(a * a + b * b)
            )
            {
                return new rightTriangle(a, b, c);
            }

            if (a.Equals(b) || a.Equals(c) || b.Equals(c))
            {
                return new isoscelesTriangle(a, b, c);
            }

            return new scaleneTriangle(a, b, c);
        }
    }
}
