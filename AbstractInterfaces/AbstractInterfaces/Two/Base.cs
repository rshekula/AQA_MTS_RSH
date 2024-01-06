using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaces.Two
{
    public abstract class Base
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected Base(){}

        protected Base(string name)
        {
            Name = name;
        }

        protected Base(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void PrintProductInfo();
        public abstract bool IsExpired();
    }
}
