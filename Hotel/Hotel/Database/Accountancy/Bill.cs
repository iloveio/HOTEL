
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Database
{
    
    public class Bill
    {
        /// <summary>
        /// Gets or sets the bill identifier.
        /// </summary>
        /// <value>The bill identifier.</value>
        public int BillID { set; get; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the module.
        /// </summary>
        /// <value>The module.</value>
        public string Module { get; set; } //typ??

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public string Target { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bill"/> class.
        /// </summary>
        public Bill() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bill"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="amt">The amt.</param>
        /// <param name="Module">The module.</param>
        /// <param name="Target">The target.</param>
        public Bill(int id, int amt, string Module, string Target)
        {
            this.BillID = id;
            this.Amount = amt;
            this.Module = Module;
            this.Target = Target;
        }
    }
}
