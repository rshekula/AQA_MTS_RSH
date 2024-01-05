using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class CreditCard
    {
        public string AccountNumber;
        public int AccountSum;

        public CreditCard(string accountNumber, int accountSum)
        {
            AccountNumber = accountNumber;
            AccountSum = accountSum;
        }

        public void PutMoney (int money)
        {
            AccountSum += money;
        }

        public void ReceiveMoney (int money)
        {
            if (AccountSum - money >= 0)
            {
                AccountSum -= money;
            }
            else
            {
                Console.WriteLine($"Не хватает средств на карте {AccountNumber}");
            }
        }

        public void InfoCreditCard ()
        {
            Console.WriteLine($"На Вашей карте {AccountNumber} \n {AccountSum} рублей");
        }
    }

    
}
