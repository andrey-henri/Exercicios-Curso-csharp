using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listFunc = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listFunc.Add(new Funcionario(id, name, salario));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int idFunc = int.Parse(Console.ReadLine());

            Funcionario emp = listFunc.Find(x => x.Id == idFunc);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario func in listFunc)
            {
                Console.WriteLine(func);
            }
        }
    }
}
