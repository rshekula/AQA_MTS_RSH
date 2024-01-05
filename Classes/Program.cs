using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("Задание 1");
            Console.WriteLine();

            Phone phone1 = new Phone();
            Phone phone2 = new Phone("79990001122", "Samsung");
            Phone phone3 = new Phone("79996663333", "Samsung2", 15);
            phone1.Print();
            phone2.Print();
            phone3.Print();
            Console.WriteLine();

            phone1.receiveCall("Дима");
            phone2.receiveCall("Катя");
            phone3.receiveCall("Петя");

            Console.WriteLine(phone1.getNumber());
            Console.WriteLine(phone2.getNumber());
            Console.WriteLine(phone3.getNumber());
            Console.WriteLine();

            phone1.sendMessage(
                "70006661122",
                "71110441133");

            phone2.sendMessage(
                "72220551177",
                "72220088888");

            phone3.sendMessage(
                "75550009999",
                "75550009090",
                "75550003333",
                "75550002321",
                "75550003443");
            
            Console.WriteLine("=================================");
            
            // задание 2
            Console.WriteLine("Задание 2");
            CreditCard creditCard1 = new CreditCard("8989999902023434", 50000);
            CreditCard creditCard2 = new CreditCard("8955559911123335", 33333);
            CreditCard creditCard3 = new CreditCard("8000900010005000", 0);

            Console.WriteLine("Информация по картам до операций");
            creditCard1.InfoCreditCard();
            creditCard2.InfoCreditCard();
            creditCard3.InfoCreditCard();
            
            //положили деньги на первые две карты и снимаем с третьей
            creditCard1.PutMoney(5000);
            creditCard2.PutMoney(43);
            creditCard3.ReceiveMoney(55555);

            Console.WriteLine("Информация по картам после операций");
            creditCard1.InfoCreditCard();
            creditCard2.InfoCreditCard();
            creditCard3.InfoCreditCard();

        }
    }
}