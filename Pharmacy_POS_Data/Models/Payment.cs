using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_POS_Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int SaleID { get; set; }
        public string PaymentType { get; set; } // Cash, Card, Mobile Payment
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        // Navigation Property
        public Sale Sale { get; set; }
    }

}
