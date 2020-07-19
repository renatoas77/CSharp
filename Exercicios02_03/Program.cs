using System;

namespace Exercicios02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resto;
            Console.WriteLine("Digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
                resto = n1 % n2;
            else
                resto = n2 % n1;
            if (resto == 0)
                Console.WriteLine("São multiplos");
            else
                Console.WriteLine("Não são multiplos");
         }
    }
}
