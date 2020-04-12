using System;
using System.Globalization;

namespace ProjectProduct.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string priceTag()
        {
            return Name + " R$" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}