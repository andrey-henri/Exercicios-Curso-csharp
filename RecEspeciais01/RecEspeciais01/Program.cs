using System;
using System.Globalization;

namespace RecEspeciais01
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = ""; //tipo generico de varivel definido de acordo com o seu valor de inicialização

            DateTime d1 = new DateTime(2018, 11, 25); //inicializando um DateTime manualmente com ano, mes, dia
            DateTime d2 = new DateTime(2018, 11, 25, 20 , 45 , 3); //inicializando um DateTime manualmente com ano, mes, dia, hora, minuto, segundo
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); //inicializando um DateTime manualmente com ano, mes, dia, hora, minuto, segundo, milissegundo
            DateTime d4 = DateTime.Now; //variavel que grava data e hora "DateTime.Now" retorna data e hora atual do sistema
            DateTime d5 = DateTime.Today; //variavel que grava data "DateTime.Today" retorna data atual do sistema
            DateTime d6 = DateTime.UtcNow;  //variavel que grava data e hora "DateTime.Now" de acordo com o horario de Greenwich

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("18/08/2000");
            DateTime d10 = DateTime.Parse("18/08/2000 20:32:00");
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("08/18/2000 13:05:58", "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            TimeSpan t1 = new TimeSpan(0,1,30);//grava um instante hora, minuto e segundo
            TimeSpan t2 = new TimeSpan();//incializa um instante 00:00:00
            TimeSpan t3 = new TimeSpan(900000000L);//passando a quantidade de ticks do instantne


            Console.WriteLine("Digite o numero de uma opção do menu: ");
            switch (int.Parse(Console.ReadLine())) //switch-case
            {
                case 1:
                    Console.WriteLine("Opção 1"); 
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

            double preco, desconto;
            Console.Write("Digite o valor de um produto: ");
            preco = double.Parse(Console.ReadLine());
            desconto = (preco > 100.0) ? preco * 0.1 : preco * 0.2; //Expressão condicional ternária

            Console.Write("Digite seu nome: ");
            string original = Console.ReadLine();
            string var2 = original.ToUpper(); //deixando o texto em maiusculo 
            string var3 = original.ToLower(); //deixando o texto em minusculo 
            string var4 = original.Trim(); //remover espaço em branco no final do string
            int num1 = original.IndexOf("A"); //retorna a posição da primeira letra A dentro da string
            int num2 = original.LastIndexOf("A"); //retorna a posição da ultima letra A dentro da string
            string var5 = original.Substring(0,10); //recorta a string original começando na posição 0 e indo até o 10 caracter
            string var6 = original.Replace('a', 'x'); //substitui o caracter a pelo caracter x em todos os locais da string
            string var7 = original.Replace("Andrey", "Maria"); //substitui uma palavra por outra em todos os locais da string
            bool var8 = String.IsNullOrEmpty(original); //retorna se a variavel está null ou vazia ""
            bool var9 = String.IsNullOrWhiteSpace(original); //retorna se o conteudo da variavel só possui espaços em branco

        }
    }
}
