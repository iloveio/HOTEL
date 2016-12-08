using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Hotel.Database.Transportation
{
    class TransportationContext : DbContext
    {
        public DbSet<Transportation> Transportations { get; set; }
    }
}
