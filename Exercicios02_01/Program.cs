using System;

namespace Exercicios02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            bool pstv;
            Console.WriteLine("Digite um numero inteiro");
            Num = int.Parse(Console.ReadLine());
            pstv = Num >= 0;
            if (pstv == true)
                Console.WriteLine("Não negativo");
            else
                Console.WriteLine("Negativo");
        }
    }
}
