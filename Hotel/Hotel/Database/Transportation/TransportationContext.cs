using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;



namespace Hotel.Database.Transportation
{
    public class TransportationContext : DbContext
    {
        public virtual DbSet<Transportation> Transportations { get; set; }

    }
}
