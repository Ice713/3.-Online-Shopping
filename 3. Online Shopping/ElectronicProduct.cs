using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Online_Shopping
{
    internal class ElectronicProduct : Product
    {
        public int Warranty { get; set; } // Warranty in years

        public ElectronicProduct(string name, decimal price, int warranty) : base(name, price)
        {
            Warranty = warranty;
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}\nWarranty: {Warranty} years";
        }
    }
}
