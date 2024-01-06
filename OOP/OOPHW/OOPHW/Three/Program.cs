using OOPHW.Transport;
using OOPHW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// задача 3

var tps = new TransportService();

AllTransport[] transports = new AllTransport[]
{
    new Bus() { AmountSeats = 38, DepartureTime = new TimeOnly(03, 45), Destination = "м.Звездная", Number = 27 },
    new Trolleybus() { AmountSeats = 34, DepartureTime = new TimeOnly(15, 05), Destination = "м.Пионерская", Number = 40 },
    new Tramcar() { AmountSeats = 23, DepartureTime = new TimeOnly(16, 00), Destination = "м.Сенная", Number = 39 }
};

Console.WriteLine("Все виды транспорта:");
foreach (var transport in transports)
{
    tps.PrintTransportType(transport);
}
Console.WriteLine("\nИнформация о транспорте:");
transports = tps.SortByAmountSeats(transports);
foreach (var transport in transports)
{
    transport.WriteTransportInfo();
}

var searchResults = new AllTransport[transports.Length];
int searchIndex = 0;

Console.WriteLine("\nВведите время чч:мм");
string rawDepartureTime = Console.ReadLine();
TimeOnly? departureTime = null;
if (rawDepartureTime != string.Empty)
{
    departureTime = new TimeOnly(int.Parse(rawDepartureTime.Split(':')[0]), int.Parse(rawDepartureTime.Split(':')[1]));
}

Console.WriteLine("Введите пункт назначения");
string destination = Console.ReadLine();
foreach (var transport in transports)
{
    if (!(rawDepartureTime == string.Empty ||
          (rawDepartureTime != string.Empty && transport.DepartureTime > departureTime)))
    {
        continue;
    }

    if (!(destination == String.Empty || (destination != String.Empty && destination == transport.Destination)))
    {
        continue;
    }

    searchResults[searchIndex] = transport;
    searchIndex++;
}

bool isAnyResultDisplayed = false;

foreach (var transport in searchResults)
{
    if (transport != null)
    {
        transport.WriteTransportInfo();
        isAnyResultDisplayed = true;
    }
}

if (!isAnyResultDisplayed)
{
    Console.WriteLine("Введённый транспорт не найден");
}