using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_POS_Data.Models
{
    public class SaleDetail
    {
        [Key]
        public int SaleDetailID { get; set; }
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Computed property (not stored in the database)
        public decimal Subtotal => Quantity * Price;

        // Navigation Properties
        public Sale Sale { get; set; }
        public Product Product { get; set; }
    }

}
