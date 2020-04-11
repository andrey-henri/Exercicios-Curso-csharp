using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome:");
            prod1.Nome = Console.ReadLine();
            Console.Write("Preço:");
            prod1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            prod1.QtdEstoque = float.Parse(Console.ReadLine());
            Console.WriteLine(prod1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            prod1.AdicionarProdutos(float.Parse(Console.ReadLine()));
            Console.WriteLine(prod1.imprimirInformaçoes());

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            prod1.RemoverProdutos(float.Parse(Console.ReadLine()));
            Console.WriteLine(prod1.imprimirInformaçoes());
        }
    }
}
