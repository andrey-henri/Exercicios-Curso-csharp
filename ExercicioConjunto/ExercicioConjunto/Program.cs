using System;
using System.Collections.Generic;

namespace ExercicioConjunto
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();
            HashSet<int> totalAlunos = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for(int i = 1; i <= qtdA; i++)
            {
                cursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            int qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 1; i <= qtdB; i++)
            {
                cursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            int qtdC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 1; i <= qtdC; i++)
            {
                cursoC.Add(int.Parse(Console.ReadLine()));
            }

            //cursoA.ExceptWith(cursoB); //remover do curso A todos que também estão no curso B
            //cursoA.UnionWith(cursoB); // Adicionar no curso A os alunos do curso B (não faz repetição)
            //cursoA.IntersectWith(cursoB; //irá permanecer no curso A somente os alunos que também estão no curso B

            totalAlunos.UnionWith(cursoA);
            totalAlunos.UnionWith(cursoB);
            totalAlunos.UnionWith(cursoC);
    
            Console.WriteLine("Total de alunos: " + totalAlunos.Count);

            Console.Write("Digite o codigo de um aluno do curso A: ");
            if (cursoA.Contains(int.Parse(Console.ReadLine()))) //verificar se o conjunto A possui / contem
            {
                Console.WriteLine("Aluno está matriculado no curso!");
            }
            else
            {
                Console.WriteLine("Esse aluno não está matriculado neste curso!");
            }
        }
    }
}
