using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();

            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();

            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.Write("Pessoa mais velha: " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }

            Console.Write("Dados do primeiro funcionário:\nNome:");
            func1.nome = Console.ReadLine();
            Console.Write("Salario:");
            func1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Dados do segundo funcionário:\nNome:");
            func2.nome = Console.ReadLine();
            Console.Write("Salario:");
            func2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Salário médio = " + ((func1.salario + func2.salario)/2).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
