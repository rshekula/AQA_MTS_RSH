using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW.Transport
{
    public class Bus : AllTransport
    {
        public override string? GetTransportType()
        {
            return "Road";
        }
    }
}
