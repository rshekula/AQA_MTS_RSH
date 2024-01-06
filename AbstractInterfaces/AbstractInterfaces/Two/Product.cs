using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractInterfaces.Two
{
    public class Product : Base
    {
        public DateOnly StartDate;
        public DateOnly ExpirationDate;

        public Product(string name, double price, DateOnly startDate, DateOnly expirationDate) : base(name, price)
        {
            StartDate = startDate;
            ExpirationDate = expirationDate;
        }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"Название: {Name}. Цена: {Price}.\nДата изготовления {StartDate}. Дата окончания: {ExpirationDate}");
        }

        public override bool IsExpired()
        {
            return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
        }
    }
}
