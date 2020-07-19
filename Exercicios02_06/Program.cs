using System;

namespace Exercicios02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Double N1;
            Console.WriteLine("Enter a value: ");
            N1 = Double.Parse(Console.ReadLine());
            if (N1 >= 0 && N1 <= 25)
                Console.WriteLine("Interval (00,25)");
            else if (N1 > 25 && N1 <= 50)
                Console.WriteLine("Interval (25,50)");
            else if (N1 > 50 && N1 <= 75)
                Console.WriteLine("Interval (50,75)");
            else if (N1 > 75 && N1 <= 100)
                Console.WriteLine("Interval (75,100)");
            else
                Console.WriteLine("Out of interval");          
        }
    }
}
