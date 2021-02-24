using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            uint b = 5u;
            long c = 5L;
            byte d = 3;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            char copySym = '\u00A9';
            char weird = '\u07D0';

            Console.WriteLine(copySym);
            Console.WriteLine(weird);

            float f = 3.455f;
            double g = 1.2e2;
            double h = 444.4;
            decimal i = 4981.33m;

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
        }
    }
}
