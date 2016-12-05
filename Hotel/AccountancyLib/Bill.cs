using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountancyLib
{
    class Bill
    {
        public Bill()
        {

        }

        public Bill(Double income, String purpose, String module)
        {
            this.Module = module;
            this.Gain = (float)income;
            this.Purpose = purpose;
        }

        public String Module { get; private set; }
        public float Gain { get; private set; }
        public String Purpose { get; private set; }
    }
}
