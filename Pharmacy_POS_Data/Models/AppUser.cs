using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_POS_Data.Models
{
    public class AppUser:IdentityUser
    {
        public AppUser()
        {
            Categories = new List<Category>();
            Customers = new List<Customer>();
            Payments = new List<Payment>();
            Products = new List<Product>();
            Sales = new List<Sale>();
            SaleDetails = new List<SaleDetail>();
        }

        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

    }
}
