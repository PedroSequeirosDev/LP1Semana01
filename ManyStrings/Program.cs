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

            string conc_1 = "olá" + " mundo!";
            string conc_2 = "abc" + " as easy as " + "123";
            string inter_1 = $"valor de x é {9}";
            string inter_2 = $"{6} a dividir {2} é {6 / 2}";

            Console.WriteLine(conc_1);
            Console.WriteLine(conc_2);
            Console.WriteLine(inter_1);
            Console.WriteLine(inter_2);
            

        }
    }
}
