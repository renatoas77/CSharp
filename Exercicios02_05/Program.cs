using System;
using System.Globalization;

namespace Exercicios02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd, qtt;
            float price;
            Console.WriteLine("Code     Name              Price");
            Console.WriteLine("1        Hot-Dog           R$ 4,00");
            Console.WriteLine("2        X-Salad           R$ 4,50");
            Console.WriteLine("3        X-Bacon           R$ 5,00");
            Console.WriteLine("4        Simple toast      R$ 2,00");
            Console.WriteLine("5        soda              R$ 1,50");
            Console.WriteLine("Choose one item");
            cd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount: ");
            qtt = int.Parse(Console.ReadLine());
            if (cd == 1)
            {
                price = qtt * 4.00f;
                Console.WriteLine("Total price: R$" + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cd == 2)
            {
                price = qtt * 4.50f;
                Console.WriteLine("Total price: R$" + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cd == 3)
            {
                price = qtt * 5.00f;
                Console.WriteLine("Total price: R$" + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cd==4) {
                price = qtt * 2.00f;
                Console.WriteLine("Total price: R$" + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (cd==5) {
                price = qtt * 1.50f;
                Console.WriteLine("Total price: R$" + price.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
                Console.WriteLine("Wrong choice, please try again");
        }
    }
}
