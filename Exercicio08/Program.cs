using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("Quantos quartos serão alugados: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                quartos[i] = new Quarto();
            }

                for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail do cliente: ");
                string eMail = Console.ReadLine();
                Console.Write("Numero do quarto do cliente: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Quanto ira pagar de aluguel: ");
                double aluguel = double.Parse(Console.ReadLine());
                quartos[quarto].cadastro(nome, eMail, quarto, aluguel);
             }

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i].NumeroDoQuarto != null)
                    Console.WriteLine(quartos[i]);
                else
                    Console.WriteLine(i + ": está vazio");                
            }



        }
    }
}
