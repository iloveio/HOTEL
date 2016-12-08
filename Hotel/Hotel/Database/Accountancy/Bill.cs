using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database.Accountancy
{
    public class Bill
    {
        [Key]
        public int BillID { set; get; }
        public int Amount { get; set; }
        public string Module { get; set; } //typ??
        public string Target { get; set; }

        public Bill(int id, int amt, string Module, string Target)
        {
            this.BillID = id;
            this.Amount = amt;
            this.Module = Module;
            this.Target = Target;
        }
    }
}
