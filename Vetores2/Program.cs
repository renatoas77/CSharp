using System;
using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produtos[] item = new Produtos[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                item[i] = new Produtos(nome,preco);

            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += item[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("A media de preço dos itens é de: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}