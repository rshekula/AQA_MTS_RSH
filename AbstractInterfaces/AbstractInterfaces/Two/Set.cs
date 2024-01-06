using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractInterfaces.Two
{
    public class Set : Base
    {
        public List<Product> SetProducts { get; set; }

        public new double Price => SetProducts.Sum(x => x.Price);
        public DateOnly? ExpirationDate => SetProducts.Min(x => x.ExpirationDate);

        public Set(string name, List<Product> products) : base(name)
        {
            SetProducts = products;
        }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"\nПродукт \"{Name}\". Общая цена комплекта = {Price}. Состав комплекта:");
            foreach (var product in SetProducts)
            {
                product.PrintProductInfo();
            }
        }

        public override bool IsExpired()
        {
            return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
        }
    }
}
