using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_POS_Data.Models
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        public int? CustomerID { get; set; } // Nullable for walk-in customers
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } // UserID of the cashier/admin who created the sale

        // Navigation Properties
        public Customer Customer { get; set; }
        public AppUser CreatedByUser { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }

}
