using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_polimorfism_csharp.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Custom fee: $ {CustomsFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
