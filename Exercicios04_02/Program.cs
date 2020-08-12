using System;

namespace Exercicios04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double porc;

            Funcionario func;
            func = new Funcionario();
            Console.WriteLine("Entre os dados do Funcionario");

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Salario: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(func);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            porc = double.Parse(Console.ReadLine());
            func.AumentarSalario(porc);

            Console.WriteLine(func);

        }
    }
}
