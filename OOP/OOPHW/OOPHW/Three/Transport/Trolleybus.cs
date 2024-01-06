using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Transport
{
    public class Trolleybus : AllTransport
    {
        public override string? GetTransportType()
        {
            return "Electric";
        }
    }
}
