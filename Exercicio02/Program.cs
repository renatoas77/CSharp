using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            Console.WriteLine("Calculador de área de circulos");
            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            area = Math.Pow(raio, 2) * 3.14159;
            Console.WriteLine("A área do circulo é igual a: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
