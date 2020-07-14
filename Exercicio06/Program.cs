using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine());
            double tri, circ, trapz, quad, ret;
            tri = (A * C) / 2;
            circ = Math.Pow(C, 2) * 3.14159;
            trapz = ((A + B) * C) / 2;
            quad = Math.Pow(B, 2);
            ret = A * B;
            Console.WriteLine("TRIANGULO: " + tri.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circ.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapz.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quad.ToString("F3"));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3"));
        }
    }
}
