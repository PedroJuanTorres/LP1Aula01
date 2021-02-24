using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            int y = -123;
            double z = 0.44;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");
            Console.WriteLine(@"\nHello World!\n");
            Console.WriteLine("\u07F7 \u09EA");
            Console.WriteLine(@"\u07F7 \u09EA");
            Console.WriteLine("\"This is a double quotes\"");
            Console.WriteLine(@"""This is a double quotes""");

            Console.WriteLine("a" + 2);
            Console.WriteLine("abc" + x);

            string myStr = $"valor de x é {x}";
            Console.WriteLine(myStr);
            myStr = $"{x} mais {y} é igual a {x + y}";
            Console.WriteLine(myStr);

            myStr = string.Format("Y is {1}, X is {0}", x, y);
            Console.WriteLine(myStr);
            Console.WriteLine("Y is {1}, X is {0}", x, y);

            Console.WriteLine(@"\Verbati\m \com x = {0}", x);

            Console.WriteLine("Valor é {0, -10:f3}!!", 1.34534);

            Console.WriteLine($"x em hex = {x:X}");

            Console.WriteLine($"z = {z}");
            Console.WriteLine($"z = {z:p}");
            Console.WriteLine($"z = {z:c}");

        }
    }
}
