using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaces.OneFigures
{
    public class Rectangle : Figure
    {
        public double A;
        public double B;

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public override double GetArea()
        {
            double s = A * B;
            return s;
        }

        public override double GetPerimeter()
        {
            double p = (A + B) * 2;
            return p;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Стороны прямоугольника = {A} и {B}");
        }
    }
}
