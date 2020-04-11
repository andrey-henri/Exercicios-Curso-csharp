using System.Globalization;

namespace ExercicioList
{
    class Funcionario
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", R$ " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

        public void increaseSalary(double percentage)
        {
            Salary += (Salary * percentage) / 100;
        }

    }
}