using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] VetorQuarto = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuarto = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdQuarto; i++)
            {
                Console.WriteLine("Aluguel #"+ i+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();
                Console.Write("Quarto: ");
                VetorQuarto[int.Parse(Console.ReadLine())] = new Quarto(nome, Email);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < VetorQuarto.Length; i++)
            {
                if (VetorQuarto[i] != null)
                {
                    Console.WriteLine(i + VetorQuarto[i].ToString());
                }
            }

            //foreach(Quarto obj in VetorQuarto)
            //{
            //    Console.Write(obj);
            //}
        }
    }
}
