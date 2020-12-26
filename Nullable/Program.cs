using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("Valor de X é nulo");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Valor de Y é nulo");

            Console.WriteLine(x);

            Console.WriteLine(y);

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
