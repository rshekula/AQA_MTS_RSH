using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaces.Two
{
    public class Batch : Base
    {
        public List<Product> BatchProduct { get; set; }
        public int Amount;
        //Берем первый элемент, предполагая, что все продукты в партии одинаковые
        public new string? Name => BatchProduct.FirstOrDefault()?.Name;
        public new double Price => BatchProduct.Sum(x => x.Price);
        public DateOnly? StartDate => BatchProduct.FirstOrDefault()?.StartDate;
        public DateOnly? ExpirationDate => BatchProduct.FirstOrDefault()?.ExpirationDate;

        public Batch(List<Product> product)
        {
            BatchProduct = product;
            Amount = product.Count;
        }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"Название продукта: {Name}. Кличество в партии: {Amount}шт. Цена: {Price}.\nДата изготовления {StartDate}. Дата окончания: {ExpirationDate}");
        }

        public override bool IsExpired()
        {
            return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
        }
    }
}
