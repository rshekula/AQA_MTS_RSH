using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW.Task2
{
    internal class Item
    {
        public string Title { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public Item() { }

        public Item(string title, int price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }
    }
}
