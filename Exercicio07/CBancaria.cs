using System;
using System.Globalization;

namespace Exercicio07
{
    class CBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public CBancaria(int conta, string nome, double dinheiro)
        {
            Conta = conta;
            Nome = nome;
            Saldo = dinheiro;

        }

        public CBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
            Saldo = 0;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
