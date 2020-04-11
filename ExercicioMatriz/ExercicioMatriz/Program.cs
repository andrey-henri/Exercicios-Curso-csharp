using System;
namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas e colunas de sua matriz: ");
            string[] tamanhoMatriz = Console.ReadLine().Split(' ');
            int[,] matriz = new int[int.Parse(tamanhoMatriz[0]), int.Parse(tamanhoMatriz[1])];

            for (int i = 0; i < int.Parse(tamanhoMatriz[0]); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(tamanhoMatriz[1]); j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            imprimeMatriz(matriz);

            Console.WriteLine("Digite o numero que deseja procurar: ");
            int numero = int.Parse(Console.ReadLine());
            localizaPosition(matriz, numero);
        }
        public static void imprimeMatriz(int[,] matriz)
        {
            Console.WriteLine("<----------->");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("<----------->");
        }

        public static void localizaPosition(int[,] matriz,int numero)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < matriz.GetLength(1) - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < matriz.GetLength(0) - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
