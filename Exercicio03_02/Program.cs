using System;

namespace Exercicio03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int ins = 0 , outs = 0;
            Console.WriteLine("Type an integer: ");
            int Num1 = int.Parse(Console.ReadLine());
        for (int cont =1; cont <= Num1; cont++)
            {
                Console.WriteLine("Type an integer: ");
                int Num2 = int.Parse(Console.ReadLine());
                if (Num2 >= 10 && Num2 <= 20)
                    ins++;
                else
                    outs++;
            }
            Console.WriteLine("in: " + ins);
            Console.WriteLine(" ");
            Console.WriteLine("out: " + outs);
        }
    }
}
