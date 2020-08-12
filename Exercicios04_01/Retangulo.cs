using System;

namespace Exercicios04_01
{
    class Retangulo
    {
        public double Alt;
        public double Larg;

        public double Area()
        {
            return Alt * Larg;
        }
        
        public double Perimetro()
        {
            return (Alt + Larg) * 2; 
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Alt, 2) + Math.Pow(Larg, 2));
        }
    }
}
