using System.Globalization;

namespace ProjectEmployee.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; protected set; }

        protected TaxPayer(string name, double anualIncome)
        {
            this.Name = name;
            this.AnualIncome = anualIncome;
        }

        abstract public double tax();

        public override string ToString() => "Name:" + Name + " R$" + tax().ToString("F2", CultureInfo.InvariantCulture);
    }
}