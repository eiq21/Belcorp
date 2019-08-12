using System;
using System.Collections.Generic;
using System.Text;

namespace Belcorp.Model
{
    public class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Product> Product { get; set; } //c#6 = new HashSet<Product>();
    }
}
