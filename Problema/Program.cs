using System;
using System.Globalization;

namespace Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            double xP, xT, yP, yT;
            Console.WriteLine("Enter the measures of the triangle X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the measures of the triangle Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            xT = x.area();

            yT = y.area();

            Console.WriteLine("Área de X = " + xT.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + yT.ToString("F4", CultureInfo.InvariantCulture));

            if (xT > yT)
                Console.WriteLine("Biggest area is X");
            else if (yT > xT)
                Console.WriteLine("Biggest area is Y");
            else
                Console.WriteLine("The area of Y and X area equal");

        }
    }
}
