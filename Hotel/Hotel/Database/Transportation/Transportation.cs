using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Transportation
{
    class Transportation
    {
        public virtual Employee employee { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }

    }
}
