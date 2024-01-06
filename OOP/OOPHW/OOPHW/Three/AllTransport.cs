using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public abstract class AllTransport
    {
        public string Destination { get; set; }
        public int Number { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public int AmountSeats { get; set; }

        public abstract string? GetTransportType();

        //метод нельзя переопределить
        public void WriteTransportInfo() 
        {
            Console.WriteLine($"[{this.GetType().Name}] Номер = {Number}, Куда едет = {Destination}, Время отправления = {DepartureTime}, Количество мест = {AmountSeats}");
        }
    }
}
