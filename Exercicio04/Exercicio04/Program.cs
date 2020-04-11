using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos doláres você vai comprar? ");
            double qtdDolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.CalcularValorDolar(cotacao, qtdDolares));
        }
    }
}
