using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            CBancaria c;
            int conta;
            string nome;
            double dinheiro;
            char resposta;

            Console.Write("Entre o numero da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (S/N)? ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor para deposito: ");
                dinheiro = double.Parse(Console.ReadLine());
                c = new CBancaria(conta, nome, dinheiro);
            }
            else
            {
                c = new CBancaria(conta, nome);
            }

            Console.WriteLine("");
            Console.WriteLine(c);

            Console.Write("Entre o valor para deposito: ");
            dinheiro = double.Parse(Console.ReadLine());
            c.Deposito(dinheiro);

            Console.WriteLine("");
            Console.WriteLine(c);

            Console.Write("Entre o valor para saque:");
            dinheiro = double.Parse(Console.ReadLine());
            c.Saque(dinheiro);

            Console.WriteLine("");
            Console.WriteLine(c);
        }
    }
}
