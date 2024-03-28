using System.Collections;

namespace CollectionsHW.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory book1 = new Books("Джордж Оруэлл", "\"1984\"", "1949г.");
            Inventory book2 = new Books("Джон Рональд Толкин", "\"Властелин колец\"", "1954 г.");
            Inventory book3 = new Books("Джоан Роулинг", "\"Гарри Поттер и философский камень\"", "1997г.");
            Inventory book4 = new Books("Кен Кизи", "\"Пролетая над гнездом кукушки\"", "1962г.");
            Inventory book5 = new Books("Виктор Суворов", "\"Аквариум\"", "1985г.");
            Shop.AddBook(book1);
            Shop.AddBook(book2);
            Shop.AddBook(book3);
            Shop.AddBook(book4);
            Shop.AddBook(book5);
            Console.WriteLine("Список книг в библиотеке:");
            Shop.PrintBooks();

            string searchAuthor = "Джон Рональд Толкин";
            Console.WriteLine("По вашему запросу найдена книга:");
            Shop.SearchByAuthor(searchAuthor);

            Shop.DeleteBook(book3);
            Shop.DeleteBook(book5);
            Console.WriteLine("Список книг изменён:");
            Shop.PrintBooks();

            Shop.Exit();
        }
    }
}