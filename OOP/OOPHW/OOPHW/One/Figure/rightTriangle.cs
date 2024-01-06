using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    internal class rightTriangle : scaleneTriangle
    {
        public rightTriangle(double a, double b, double c) : base(a, b, c)
        {
        }

        public override double GetArea()
        {
            if (A > B && A > C)
            {
                return (B * C) / 2;
            }

            if (B > A && B > C)
            {
                return (A * C) / 2;
            }

            if (C > A && C > B)
            {
                return (A * B) / 2;
            }

            return base.GetArea();
        }
    }
}
