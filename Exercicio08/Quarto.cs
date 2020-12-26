using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio08
{
    class Quarto
    {
        public string Nome { get; private set; }
        public string EMail { get; private set; }
        public int? NumeroDoQuarto { get; private set; }
        public double? Aluguel { get; private set; }

        public Quarto()
        {
            Nome = null;
            EMail = null;
            NumeroDoQuarto = null;
            Aluguel = null;
        }



        public void cadastro (string nome,string email, int numeroDoQuarto, double aluguel)
        {
            Nome = nome;
            EMail = email;
            NumeroDoQuarto = numeroDoQuarto;
            Aluguel = aluguel;

        }
        public override string ToString()
        {
            return NumeroDoQuarto + ": " + Nome + ", " + EMail + ", Aluguel: " + Aluguel;

        }
    }
}
