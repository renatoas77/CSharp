using System;
using System.Globalization;

namespace Exercicios04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();
            Console.WriteLine("Entre a largura e a altura de um retangulo: ");
            ret.Larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
