using System;

namespace Exercicios02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0;
            Console.WriteLine("Type your monthly income: ");
            double income = double.Parse(Console.ReadLine());
            if (income <= 2000.00)
                Console.WriteLine("Exempted");
            else if (income <= 3000.00)
                tax = (income - 2000.00) * 0.08;
            else if (income <= 4500.00)
                tax = ((income - 3000.00) * 0.18) + 80;
            else
                tax = ((income - 4500.00) * 0.28) + 80 + 270;
            Console.WriteLine("Total taxes: " + tax);
        }
    }
}
