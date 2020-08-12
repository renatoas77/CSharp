using System;

namespace Problema
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double area()
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt((P * (P - A) * (P - B) * (P - C)));
        }   
    }
}
