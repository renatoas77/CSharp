using System;
using System.Globalization;

namespace Exercicio03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double Avg;
            Console.WriteLine("Type an integer: ");
            int Fin = int.Parse(Console.ReadLine());
             for (int cont = 1; cont <= Fin; cont++)
            {
                Console.WriteLine("Enter three grades: ");
                string[] Grds = Console.ReadLine().Split(' ');
                double Grd1 = double.Parse(Grds[0], CultureInfo.InvariantCulture);
                double Grd2 = double.Parse(Grds[1], CultureInfo.InvariantCulture);
                double Grd3 = double.Parse(Grds[2], CultureInfo.InvariantCulture);
                 
                Avg = Grd1 * 0.2 + Grd2 * 0.3 + Grd3 * 0.5;

                Console.WriteLine("The average is: " + Avg.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
