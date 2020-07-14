using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, t;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            t = n1 + n2;
            Console.WriteLine("A soma dos valores é igual a:");
            Console.WriteLine(t);

        }
    }
}
