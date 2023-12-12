// Задание2
namespace Arrays2
{
    public class Program
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
