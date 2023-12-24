
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//3 задача

namespace Strings
{
    public class Program
    {
        public static void Main()
        {
            string one = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            Console.WriteLine($"Изначальная строка: {one}");
            string[] find = one.Split("abc");

            Console.WriteLine($"Начало строки: {find[0]}");
            Console.WriteLine($"Конец строки: {find[1]}");
        }
    }
}