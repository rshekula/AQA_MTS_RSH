// See https://aka.ms/new-console-template for more information

//case one
namespace TypesAndOperators
{
    public class Program
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

// See https://aka.ms/new-console-template for more information

//case two
namespace TypesAndOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= -50 && number <= 50)
            {
                if (number >= -40 && number <= -10)
                {
                    Console.WriteLine("Число входит в промежуток от -40 до -10");
                }
                else
                {
                    if (number >= -9 && number <= 0)
                    {
                        Console.WriteLine("Число входит в промежуток от -9 до 0");
                    }
                    else
                    {
                        if (number >= 1 && number <= 10)
                        {
                            Console.WriteLine("Число входит в промежуток от 1 до 10");
                        }
                        else
                        {
                            if (number >= 11 && number <= 40)
                            {
                                Console.WriteLine("Число входит в промежуток от 11 до 40");
                            }
                            else
                            {
                                Console.WriteLine("Число не входит ни в один из промежутков");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Число за пределами промежутка от -50 до 50");
            }


        }
    }
}