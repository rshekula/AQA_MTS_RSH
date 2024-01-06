using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaces.OneFigures
{
    public class Triangle : Figure
    {
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double GetArea()
        {
            double semiP = GetPerimeter() / 2;
            double s = double.Sqrt(semiP * (semiP - A) * (semiP - B) * (semiP - C));
            return s;
        }

        public override double GetPerimeter()
        {
            double p = A + B + C;
            return p;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Стороны треугольника = {A}, {B}, {C}");
        }
    }
}
