using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            string str_1 = "olá mundo! \u272A";
            string str_2 = "a space\t and pretty letters \u24BD \u24BE ";
            string str_3 = "a different alphabet \u03A6 \u03A8 \u03BE ";

            Console.WriteLine(str_1);
            Console.WriteLine(str_2);
            Console.WriteLine(str_3);
        }
    }
}
