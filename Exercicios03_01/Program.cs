using System;

namespace Exercicios03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            int Num1 = int.Parse(Console.ReadLine());

            for (int cont = 0; cont <= Num1; cont++)
            {
                if (cont % 2 != 0)
                    Console.WriteLine(cont);
                else
                    Console.WriteLine(" ");
            }
        }
    }
}
