using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int E;
            double H,V,Salary;
            Console.WriteLine("Please type the number of the employe: ");
            E = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the number of hours worked: ");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of hour worked: ");
            V = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Salary = H * V;
            Console.WriteLine("EMPLOYE NUMBER: " + E);
            Console.WriteLine("Salary = U$ " + Salary.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
