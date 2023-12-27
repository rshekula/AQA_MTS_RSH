using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int del = 0;
            foreach (int item in number)
            {
                if (item == pDelete) 
                del++;
            }

            int[] newNumber = new int[number.Length - del];
            int novnum = 0;

            foreach (var item in number)
            {
                if (item != pDelete)
                {
                    newNumber[novnum] = item;
                    novnum++;
                }
            }
            if (del > 0)
                {
                    Console.WriteLine("Новый массив:");
                    foreach (var play2 in newNumber)
                    {
                        Console.Write(play2 + " ");
                    }
                }
                else
                {
                    Console.WriteLine($"Число {pDelete} не найдено");
                }
        }
    }
}
