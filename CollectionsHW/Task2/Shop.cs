using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW.Task2
{
    internal static class Storage
    {
        public static void AddItem(ref Dictionary<string, Item>? inventory, Item? item)
        {
            if (item is not null)
            {
                inventory.Add(Guid.NewGuid().ToString(), item);
            }
        }

        public static void DeleteItem(ref Dictionary<string, Item>? items, string id)
        {
            Item value;
            if (items.Count != 0 || !string.IsNullOrEmpty(id))
            {
                if (items.TryGetValue(id, out value))
                {
                    if (value is Item it)
                    {
                        items.Remove(id);
                    }
                }
                else
                {
                    Console.WriteLine("id не найден");
                }
            }
        }

        public static void UpdateItem(ref Dictionary<string, Item>? inventory, string? id)
        {
            if (inventory != null && !string.IsNullOrEmpty(id) && inventory.TryGetValue(id, out Item item))
            {
                Console.Write("Введите цену для обновления: ");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    item.Price = price;
                }

                Console.Write("Введите количество для обновления: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    item.Quantity = quantity;
                }
            }
            else
            {
                Console.WriteLine("id не найден");
            }
        }

        public static void SearchByID(Dictionary<string, Item>? items, string? id)
        {
            Item value;
            if (items.Count != 0 || !string.IsNullOrEmpty(id))
            {
                if (items.TryGetValue(id, out value))
                {
                    if (value is Item it)
                    {
                        Console.WriteLine($"ID {id}: {it.Title} {it.Price} {it.Quantity}");
                    }
                }
                else
                {
                    Console.WriteLine("id не найден");
                }
            }
        }

        public static void PrintItems(Dictionary<string, Item> dictionary)
        {
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Дата {DateTime.Now.ToString()}");
                Console.Write($"ID: {pair.Key} ");
                if (pair.Value is Item item)
                {
                    Console.Write(string.Format("Название: {0} ", item.Title));
                    Console.Write(string.Format("Цена: {0} рублей", item.Price));
                    Console.Write(string.Format("Количество: {0}", item.Quantity));
                    Console.WriteLine();
                }
            }
        }
    }
}