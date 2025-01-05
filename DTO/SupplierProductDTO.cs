using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    internal class SupplierProductDTO
    {
        public int ProductID { get; set; } // Primary key
        public int SupplierID { get; set; } // Foreign key - Supplier ID
        public string ProductName { get; set; } // Product name
        public decimal Price { get; set; } // Price of the product
        public string Status { get; set; } // Status of the product (e.g., Available, Sold Out)
        public DateTime CreatedAt { get; set; } // Creation timestamp


    }
}
