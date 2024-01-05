using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Phone
    {
        public string Number;
        public string Model;
        public int Weight;

        // конструктор без параметров
        public Phone() { }

        // конструктор с двумя параметрами - number, model
        public Phone(string number, string model)
        {
            Number = number;
            Model = model;
        }

        // конструктор с трёмя параметрами
        public Phone(string number, string model, int weight) : this(number, model)
        {
            Weight = weight;
        }

        // методы
        public void receiveCall(string name)
        {
            Console.WriteLine($"{name}")
        }

        public string getNumber()
        {
            return Number;
        }
    
        public void sendMessage(params int[] numbers)
        {
            foreach (string number in numbers)
                Console.WriteLine(number);
        }

        public void Print()
        {
            Console.WriteLine($"Номер: {Number}, модель: {Model}, вес: {Weight}");
        }

    }
}
