using static Exceptions.WrongLoginException;
using static Exceptions.WrongPasswordException;

namespace Exceptions
{
    public static class Authorization
    {
        public static bool CheckInputInfo(string login, string password, string confirmPassword)
        {
            bool result = true;

            if (login.Length >= 20 || login.Contains(' '))
            {
                result = false;
                throw new WrongLoginException("Логин должен быть меньше 20 символов и не содержать пробелы");
            }
            if (password.Length >= 20 || password.Contains(' '))
            {
                result = false;
                throw new WrongPasswordException("Пароль должен быть меньше 20 символов и не содержать пробелы");
            }
            if (password.All(x => !char.IsDigit(x)))
            {
                result = false;
                throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру");
            }
            if (password != confirmPassword)
            {
                result = false;
                throw new WrongPasswordException("Пароль не совпадает");
            }

            return result;
        }
            
    }
}
