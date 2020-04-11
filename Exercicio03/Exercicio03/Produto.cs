using System;
using System.Globalization;
using System.Text;

namespace Exercicio03
{
    class Produto
    {

        private string _nome;
        private double _preco;
        private float _qtdEstoque;

        public string Nome {
            get { return _nome; }
            set {  _nome = value; }
        }
        public double Preco { get => _preco; set => _preco = value; }
        public float QtdEstoque { get => _qtdEstoque; set => _qtdEstoque = value; }

        public override string ToString()
        {
            return "Dados do Produto: " + Nome + ", R$:" + Preco + ", " + QtdEstoque
                + " unidades, " + "Total: " + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * QtdEstoque;
        }

        public void AdicionarProdutos(float qtd)
        {
            QtdEstoque += qtd;
        }

        public void RemoverProdutos(float qtd)
        {
            QtdEstoque -= qtd;
        }

        public string imprimirInformaçoes()
        {
             string dados = ("Dados do Produto: " + Nome + ", R$:" + Preco + ", " + QtdEstoque 
                + " unidades, " + "Total: " + ValorTotalEmEstoque());
            return dados;
        }
    }
}
