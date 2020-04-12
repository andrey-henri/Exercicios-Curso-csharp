using System.Globalization;

namespace ProjectProduct.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFree { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) : base (name, price)
        {
            CustomsFree = customsFree;
        }

        public double totalPrice()
        {
            return Price + CustomsFree;
        }

        public override sealed string priceTag()
        {
            return Name + " R$" + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs free: $ " + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}