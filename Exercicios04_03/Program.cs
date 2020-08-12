using System;
using System.Globalization;

namespace Exercicios04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu;
            alu = new Aluno();

            Console.WriteLine("Enter os dados do aluno: ");
            Console.Write("Nome: ");
            alu.Nome = Console.ReadLine();
            Console.Write("Nota1: ");
            alu.NotaA = double.Parse(Console.ReadLine());
            Console.Write("Nota2: ");
            alu.NotaB = double.Parse(Console.ReadLine());
            Console.Write("Nota3: ");
            alu.NotaC = double.Parse(Console.ReadLine());

            Console.WriteLine(alu);

            if (alu.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else 
            { 
                Console.WriteLine("REPROVADO");
                double falta = 60 - alu.NotaFinal();
                Console.WriteLine("FALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
                

        }
    }
}
