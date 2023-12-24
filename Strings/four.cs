
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//4 задача

namespace Strings
{
    public class Program
    {
        public static void Main()
        {
            string one = "Плохой день.";
            Console.WriteLine($"Изначальная строка: {one}");

            string substr = one.Substring(7);
            // Console.WriteLine($"для проверки: {substr}");
            string insert = substr.Insert(0, "Хороший ");
            // Console.WriteLine($"для проверки: {insert}");
            string insert2 = insert.Replace(".", "!!!!!!!!!");
            // Console.WriteLine($"для проверки: {insert2}");
            string remove = insert2.Remove(insert2.Length - 1);
            string finish = remove.Insert(remove.Length, "?");

            Console.WriteLine($"Новая строка: {finish}");
        }
    }
}