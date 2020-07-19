using System;

namespace Exercicios02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two values separated: ");
            string[] value = Console.ReadLine().Split(' ');
            double X = double.Parse(value[0]);
            double Y = double.Parse(value[1]);
            if (X == 0 && Y == 0)
                Console.WriteLine("Origin");
            else if (X == 0)
                Console.WriteLine("Y axis");
            else if ( Y == 0)
                Console.WriteLine("X axis");
            else if (X > 0 && Y > 0)
                Console.WriteLine("Quadrant one");
            else if (X < 0 && Y > 0)
                Console.WriteLine("Quadrant two");
            else if (X < 0 && Y < 0)
                Console.WriteLine("Quadrant three");
            else
                Console.WriteLine("Quadrant four");

        }
    }
}
