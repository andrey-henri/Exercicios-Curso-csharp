using System;

namespace ProjectEmployee.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            this.NumberOfEmployees = numberOfEmployees;
        }
        public override double tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
