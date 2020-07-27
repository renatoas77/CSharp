using System;

namespace Exercicio03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type one number: ");
            int Numb = int.Parse(Console.ReadLine());
            for (int con = 1; con <= Numb; con++)
            {
                if (Numb % con == 0)
                    Console.WriteLine(con);
            }
        }
    }
}
