using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("INFO\nЛогин должен быть меньше 20 символов и не должен содержать пробелы.\n====\nВведите логин: ");
                string login = Console.ReadLine();

                Console.Write("====\nINFO\nПароль должен быть меньше 20 символов и не должен содержать пробелы.\nПароль должен содержать хотя бы одну цифру\n====\nВведите пароль: ");
                string password = Console.ReadLine();

                Console.Write("Введите пароль повторно: ");
                string confirmPassword = Console.ReadLine();

                if (Authorization.CheckInputInfo(login, password, confirmPassword))
                    Console.WriteLine("\nВсе данные корректны");
            }
            catch (WrongLoginException exLog)
            {
                Console.WriteLine($"\nОшибка при вводе логина: {exLog.Message}");
            }
            catch (WrongPasswordException exPas)
            {
                Console.WriteLine($"\nОшибка при вводе пароля: {exPas.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nОшибка: {e.Message}");
            }
        }
    }
}