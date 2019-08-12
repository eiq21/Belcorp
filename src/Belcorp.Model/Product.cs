using System;
using System.Collections.Generic;
using System.Text;

namespace Belcorp.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
