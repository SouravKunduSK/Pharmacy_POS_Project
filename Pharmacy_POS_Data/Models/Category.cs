using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_POS_Data.Models
{
    public class Category
    {
        [Key] 
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Property
        public ICollection<Product> Products { get; set; }

    }
}
