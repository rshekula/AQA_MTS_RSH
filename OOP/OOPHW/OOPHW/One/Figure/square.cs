using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Figure
{
    internal class square : rectangle
    {
        public square(double a) : base(a, a)
        {
        }

        public override double GetArea()
        {
            return A * A;
        }
    }
}
