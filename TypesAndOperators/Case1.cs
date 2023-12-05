// See https://aka.ms/new-console-template for more information

//case one
namespace TypesAndOperators
{
    public class Case1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию: +, -, *, /");
            string? o = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            switch (o)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                    if (b != 0)
                        Console.WriteLine(a / b);
                    else 
                        Console.WriteLine("Делить на 0 нельзя");
                        break;
                    default:
                        Console.WriteLine("Не соответствует условиям");
                        break;
                }
            Console.ReadLine();
        }
    }
}