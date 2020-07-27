using System;

namespace Exercicio03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type one number: ");
            int Numb = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Numb; i++)
            {
                double Normal = Math.Pow(i, 1);
                double Square = Math.Pow(i, 2);
                double Cubic = Math.Pow(i, 3);
                Console.WriteLine("Normal " + Normal + " Square " + Square + " Cubic " + Cubic);
            }
        }
    }
}
