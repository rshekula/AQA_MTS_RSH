using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задание6
namespace Arrays
{
    public class HW6
    {
        public static void Main(string[] args)
        {
            int[] number = { 4, 7, 3, 8, 15 };
            foreach (int str in number)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();

            for (int i = 1; i < number.Length; i += 2)
            {
                number[i] = 0;
            }

            foreach (int str in number)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}