using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание2
namespace Arrays
{
    public class HW2
    {
        public static void Main(string[] args)
        {
            int[] number = { 1, 2, 4, 6, 8, 24, 3, 7, 26, 50, 30, 33, 21 };
            Console.WriteLine("Введите целое число \nЕсли оно есть в списке, то будет удалено");
            foreach (int play in number)
            {
                Console.Write($"{play} ");
            }
            Console.WriteLine();
            int pDelete = Convert.ToInt32(Console.ReadLine());

            bool p = false;
            for (int i = 0; i < number.GetLength(0); i++)
            {
                if (number[i] == pDelete)
                {
                    number[i] = 0;
                    p = true;
                }
            }
            if (p)
            {
                Console.WriteLine($"Новый массив:");
                foreach (int play2 in number)
                {
                    Console.Write($"{play2} ");
                }
            }
            else
            {
                Console.WriteLine($"Число {pDelete} не найдено");
            }

            Console.ReadKey();
        }
    }
}
