using System;
using System.Globalization;


namespace Exercicios04_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

       public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto * (porcentagem + 100) / 100);
        }
        public override string ToString()
        {
            return "Dados atualizados: " + Nome + ", $" + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
