using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Задание1

/*
namespace Arrays
{
    public class HW1
    {
        public static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool flag = false;
            Console.WriteLine("Введите одно из целых чисел");

            foreach (int str in number)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
            int p = Convert.ToInt32(Console.ReadLine());

            foreach (int str in number)
            {
                if (str == p)
                {
                    flag = true;
                    break;
                }
            }
            Console.WriteLine();

            if (flag)
            {
                Console.WriteLine("Число входит в массив");
            }
            else
            {
                Console.WriteLine("Число не входит в массив");
            }

            Console.ReadKey();
        }
    }
}
*/


// Задание2
namespace Arrays
{
    public class HW1
    {
        public static void Main(string[] args)
        {
            int[] number = { 1, 2, 4, 6, 8, 24, 3, 7, 26, 50, 30, 33, 21 };

            Console.WriteLine("Введите целое число. Если оно есть в списке, то будет удалено");

            foreach (int play in number)
            {
                Console.Write($"{play} ");
            }
            Console.WriteLine();
            int p = Convert.ToInt32(Console.ReadLine());

            if (p != number.Length)
            {
                Console.WriteLine($"Такого числа нет");
            }
            else
            {
                foreach (int play in p)
                {
                    Console.Write($"{play} ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
