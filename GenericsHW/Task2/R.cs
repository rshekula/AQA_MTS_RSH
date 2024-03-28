using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHW.Task2
{
    internal class R
    {
        private Guid id;

        public R() => this.id = Guid.NewGuid();
    }
}