using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");
            Console.WriteLine(@"\nHello World!\n");
            Console.WriteLine("\u07F7 \u09EA");
            Console.WriteLine(@"\u07F7 \u09EA");
            Console.WriteLine("\"This is a double quotes\"");
            Console.WriteLine(@"""This is a double quotes""");
        }
    }
}
