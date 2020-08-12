using System;

namespace ExercicioPOO02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1, F2;
            F1 = new Funcionario();
            F2 = new Funcionario();
            Console.WriteLine("Primeiro funcionario: ");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            F1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Funcionario ");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            F2.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("A media salarial de " + F1.Nome + " e " + F2.Nome + " é " + ((F1.Salario + F2.Salario)/2).ToString("F2"));
        }
    }
}
