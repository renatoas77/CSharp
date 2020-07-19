using System;

namespace Exercicios02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ini, fin, dur;
            Console.WriteLine("Digite o horario inicial: ");
            ini = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o horario final: ");
            fin = int.Parse(Console.ReadLine());
            if (fin > ini)
                dur = fin - ini;
            else
                dur = 24 - ini + fin;
            Console.WriteLine("O jogo durou " + dur + " horas");
        }
    }
}
