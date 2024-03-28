using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW.Task1
{
    internal static class Shop
    {
        public static ArrayList? bibl = new();

        public static void AddBook(Inventory? book)
        {
            if (book is not null)
            {
                bibl.Add(book);
            }
        }

        public static ArrayList DeleteBook(Inventory book)
        {
            if (bibl.Count != 0)
            {
                foreach (var bookItem in bibl.ToArray())
                {
                    if (bookItem is Inventory item)
                    {
                        if (item.Equals(book))
                        {
                            bibl.Remove(book);
                        }
                    }
                }
            }
            return bibl;
        }

        public static void SearchByAuthor(string searchAuthor)
        {
            if (bibl.Count != 0)
            {
                foreach (var book in bibl)
                {
                    if (book is Inventory item)
                    {
                        if (item.Author.Equals(searchAuthor)) Console.WriteLine($"{item.ID.ToString()} {item.Author} {item.Title}");
                    }
                }
            }
        }

        public static void PrintBooks()
        {
            foreach (var book in bibl)
            {
                if (book is Inventory item)
                {
                    Console.WriteLine($"{item.ID.ToString()} {item.Author} {item.Title}");
                }
            }
            Console.WriteLine();
        }

        public static void Exit()
        {
            Console.Write("Для выхода нажмите Enter");
            Console.ReadKey();
        }
    }
}
