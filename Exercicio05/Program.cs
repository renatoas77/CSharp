using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da primeira peça: ");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças: ");
            double q1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o codigo da segunda peça: ");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças: ");
            double q2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça: ");
            double v2 = double.Parse(Console.ReadLine());
            double t1, t2;
            t1 = q1 * v1;
            t2 = q2 * v2;
            double tt = t1 + t2;
            Console.WriteLine("O valor a ser pago é: R$" + tt.ToString("F2"));
        }
    }
}
