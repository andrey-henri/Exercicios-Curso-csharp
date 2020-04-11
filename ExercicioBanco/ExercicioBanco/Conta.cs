using System;
using System.Globalization;


namespace ExercicioBanco
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get;  private set; }

        public Conta()
        {
        }
        public Conta(int numeroConta, string NomeTitular)
        {
            this.NumeroConta = numeroConta;
            this.NomeTitular = NomeTitular;
            this.Saldo = 0.0;
        }
        public Conta (int numeroConta, string NomeTitular, double valorDeposito)
        {
            this.NumeroConta = numeroConta;
            this.NomeTitular = NomeTitular;
            this.Deposito(valorDeposito);
        }

        public override string ToString()
        {
            return "Dados da conta:\n" +
                "Conta: " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: R$ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }

        public void Saque(double valor)
        {
            this.Saldo -= valor + 5.0;
        }

    }
}
