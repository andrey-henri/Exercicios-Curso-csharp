using System;
using System.Globalization;

namespace Exercicio04
{
    class ConversorDeMoeda
    {

        public static double CalcularValorDolar(double cotacaoDolar, double qtdDolar)
        {
            double valorEmReais = cotacaoDolar * qtdDolar + 0.06*(cotacaoDolar * qtdDolar);
            return valorEmReais;
        }
    }
}
