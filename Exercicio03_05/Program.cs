using System;

namespace Exercicio03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int Res = 1;
            Console.WriteLine("Enter a number: ");
            int Fat = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= Fat; cont++)
            {
                Res = Res * cont;
            }
            Console.WriteLine("The fatorial of " + Fat + " is " + Res);
        }
    }
}
