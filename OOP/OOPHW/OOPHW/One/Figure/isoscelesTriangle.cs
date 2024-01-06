﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    internal class isoscelesTriangle : scaleneTriangle
    {
        public isoscelesTriangle(double a, double b, double c) : base(a, b, c) {}

        public override double GetArea()
        {
            if (A.Equals(B))
            {
                return C / 4 * double.Sqrt(4 * double.Pow(A, 2) - double.Pow(C, 2));
            }

            if (A.Equals(C))
            {
                return B / 4 * double.Sqrt(4 * double.Pow(A, 2) - double.Pow(B, 2));
            }

            if (B.Equals(C))
            {
                return A / 4 * double.Sqrt(4 * double.Pow(B, 2) - double.Pow(A, 2));
            }

            return base.GetArea();
        }
    }
}
