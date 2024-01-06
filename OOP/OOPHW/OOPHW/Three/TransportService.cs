using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class TransportService
    {
        public void PrintTransportType(AllTransport transport)
        {
            string? transportType = transport.GetTransportType();
            Console.WriteLine($"[{transport.GetType().Name}] Вид транспорта - {transportType}");
        }

        public AllTransport[] SortByAmountSeats(AllTransport[] list)
        {
            for (var i = 0; i < list.Length; i++)
            {
                for (var j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j].AmountSeats > list[j + 1].AmountSeats)
                    {
                        var tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
                }
            }

            return list;
        }
    }
}
