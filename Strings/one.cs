using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//1 задача

namespace Strings
{
    public class Program
    {
        public static void Main()
        {
            string one = "1 test, 2 Test, 3 TesT, 4 TiST, 5 no_test, finish";
            Console.WriteLine($"Изначальная строка: {one}");

            string none = one.ToLower(); // подогнал всё под нижний регистр, чтобы поменялись все слова test (кроме 4)

            string two = none.Replace("test", "testing");
            two = Regex.Replace(two, @"\d+", "");

            Console.WriteLine($"Новая строка: {two}");
        }
    }
}