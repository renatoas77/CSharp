using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0;

            double[] vetor = new double[3];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            Console.WriteLine(soma / n);
        }
    }
}
