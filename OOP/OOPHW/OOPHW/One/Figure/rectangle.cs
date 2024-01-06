using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    internal class rectangle : general
    {
        public double A;
        public double B;

        public rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }
    }
}
