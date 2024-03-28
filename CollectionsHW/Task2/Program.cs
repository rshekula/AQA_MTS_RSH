using System.Collections;

namespace CollectionsHW.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Item>? inventoryDictionary = new Dictionary<string, Item>() { };
            Item item1 = new Item("\"Лейка\"", 250, 16849);
            Item item2 = new Item("\"Краска\"", 300, 73292389);
            Item item3 = new Item("\"Кисточка\"", 15, 372784);
            Item item4 = new Item("\"Лопата\"", 50, 3928932);
            Item item5 = new Item("\"Пила\"", 50, 3478273);
            Item item6 = new Item("\"Молоток\"", 27, 474738);
            Storage.AddItem(ref inventoryDictionary, item1);
            Storage.AddItem(ref inventoryDictionary, item2);
            Storage.AddItem(ref inventoryDictionary, item3);
            Storage.AddItem(ref inventoryDictionary, item4);
            Storage.AddItem(ref inventoryDictionary, item5);
            Storage.AddItem(ref inventoryDictionary, item6);
            Console.WriteLine("Товары в магазине в наличии:");
            Storage.PrintItems(inventoryDictionary);

            Console.Write("Для поиска товара, введите существующий id:");
            string? searchId = Console.ReadLine().ToString();
            Console.WriteLine("Найдено:");
            Storage.SearchByID(inventoryDictionary, searchId);

            Console.Write("Для изменения id товара, введите существующий id: ");
            string? updateId = Console.ReadLine().ToString();
            Storage.UpdateItem(ref inventoryDictionary, updateId);
            Storage.PrintItems(inventoryDictionary);

            Console.Write("Для удаления товара, введите существующий id: ");
            string? deletedId = Console.ReadLine().ToString();
            Storage.DeleteItem(ref inventoryDictionary, deletedId);
            Storage.PrintItems(inventoryDictionary);
        }
    }
}