using System;

namespace ProjectEmployee.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            this.HealthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            if(AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
