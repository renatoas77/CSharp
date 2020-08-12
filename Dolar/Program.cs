using System;
using System.Globalization;

namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidade,total,valor;
            Console.Write("Qual é a cotação do dolar: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar: ");
            quantidade = double.Parse(Console.ReadLine());
            total = Dolar.Total(quantidade, valor);
            Console.WriteLine("Valor a ser pago em reias: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
