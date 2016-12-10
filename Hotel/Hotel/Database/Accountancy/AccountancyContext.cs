using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Hotel.Database.Accountancy
{
    public class AccountancyContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
    }
}
