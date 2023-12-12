using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задание4
namespace Arrays
{
    public class HW4
    {
        public static void Main(string[] args)
        {
            int[] number = { 4, 7, 3, 0, 15 };
            int[] numbertwo = { 1, 8, 23, 2, 9 };

            Console.WriteLine("Первый массив:");
            foreach (int str in number)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
            Console.WriteLine("Второй массив:");
            foreach (int strtwo in numbertwo)
            {
                Console.Write($"{strtwo} ");
            }
            Console.WriteLine();

            int srd1 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                srd1 = srd1 + number[i];
            }
            int arifm1 = srd1 / number.Length;
            Console.WriteLine($"Среднее арифметическое значение первого массива = {arifm1}");
            int srd2 = 0;
            for (int i = 0; i < numbertwo.Length; i++)
            {
                srd2 = srd2 + numbertwo[i];
            }
            int arifm2 = srd2 / numbertwo.Length;
            Console.WriteLine($"Среднее арифметическое значение второго массива = {arifm2}");
            Console.WriteLine();

            if (arifm1 > arifm2)
            {
                Console.WriteLine("Значение массива 1 больше, чем значение массива 2");
            } else if (arifm1 < arifm2)
            {
                Console.WriteLine("Значение массива 2 больше, чем значение массива 1");
            } else if (arifm2 == arifm1)
            {
                Console.WriteLine("Значения равны");
            }

            Console.ReadKey();
        }
    }
}
