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

            string two = one.Replace("test", "testing", StringComparison.OrdinalIgnoreCase);
            two = Regex.Replace(two, @"\d+", "");

            Console.WriteLine($"Новая строка: {two}");
        }
    }
}
