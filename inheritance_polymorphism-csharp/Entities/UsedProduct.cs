using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_polimorfism_csharp.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) $ {Price} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
