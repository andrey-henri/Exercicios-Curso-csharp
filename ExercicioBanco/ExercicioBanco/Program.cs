using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta ct;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?  ");
            char tgDeposito = char.Parse(Console.ReadLine().ToUpper());

            if (tgDeposito == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ct = new Conta(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
                ct = new Conta(numeroConta, nomeTitular);
            }

            Console.WriteLine(ct);

            Console.Write("Entre um valor para depósito: ");
            ct.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(ct);

            Console.Write("Entre um valor para saque: ");
            ct.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(ct);
        }
    }
}
