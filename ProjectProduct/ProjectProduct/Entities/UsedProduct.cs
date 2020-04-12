using System;
using System.Globalization;

namespace ProjectProduct.Entities
{
    sealed class UsedProduct : Product
    {
        public DateTime Manufacture { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            Manufacture = manufacture;
        }

        public override string priceTag()
        {
            return Name + " (used) " + "R$" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + Manufacture.ToString("dd/MM/yyyy") + ")";
        }

    }
}