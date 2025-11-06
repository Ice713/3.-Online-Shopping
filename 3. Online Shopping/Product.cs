using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Online_Shopping
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual string GetDetails()
        {
            return $"Product: {Name}\n$Price: {Price}";
        }
    }
}
