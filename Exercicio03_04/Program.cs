using System;

namespace Exercicio03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            int Numb = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= Numb; cont++)
            {
                double res;
                Console.WriteLine("Type two separated numbers: ");
                string[] Number = Console.ReadLine().Split(' ');
                double Num1 = double.Parse(Number[0]);
                double Num2 = double.Parse(Number[1]);
                if (Num2 != 0)
                {
                    res = Num1 / Num2;
                    Console.WriteLine(res.ToString("F1"));
                }
                else
                    Console.WriteLine("it is impossible to divide by zero");
            }
        }
    }
}
