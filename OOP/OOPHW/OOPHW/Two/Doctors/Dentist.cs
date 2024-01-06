using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Doctors
{
    public class Dentist : general
    {
        public override void recording(string patientName)
        {
            Console.WriteLine($"Пациент {patientName} назначен к дантисту");
        }
    }
    {
    }
}
