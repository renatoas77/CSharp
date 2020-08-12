using System;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados: ");
            int qtdd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtdd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem removidos do estoque: ");
            qtdd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtdd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
