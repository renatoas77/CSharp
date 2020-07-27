using System;

namespace EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0} :", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("A soma é igual a {0}", soma);
        }
    }
}
