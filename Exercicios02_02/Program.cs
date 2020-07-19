using System;

namespace Exercicios02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Digite um numero inteiro: ");
            Num = int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
                Console.WriteLine("O numero é par");
            else
                Console.WriteLine("O numero é impar");
        }
    }
}
