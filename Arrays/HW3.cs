using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задание3
namespace Arrays
{
    public class HW3
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int numberSize = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[numberSize];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = new Random().Next(100);
                Console.Write($"{number[i]} ");
            }
            Console.WriteLine();

            Array.Sort(number);
            Console.WriteLine($"Минимальное значение: {number[0]}");
            Console.WriteLine($"Максимальное значение: {number[number.GetUpperBound(0)]}");
            Console.WriteLine($"Среднее значение: {number[number.GetUpperBound(0) / 2]}");
            Console.ReadKey();
        }
    }
}
