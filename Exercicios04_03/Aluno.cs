using System;
using System.Globalization;
namespace Exercicios04_03
{
    class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }
        public override string ToString()
        {
            return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
