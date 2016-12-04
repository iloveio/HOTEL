using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Accountancy
{
    class Bill
    {
        public int BillID { set; get; }
        public int Amount { get; set; }
        public string Module { get; set; } //typ??
        public string Target { get; set; }
    }
}
