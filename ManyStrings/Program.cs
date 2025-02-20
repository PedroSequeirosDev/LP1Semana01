using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

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

            string real = $"xx real with 2 decimal = {xx:f2}";
            string perc = $"xx in percent with 1 decimal = {xx:p1}";
            string hexa = $"ii in hecadecimal = {ii:x}";
            string moeda = $"ii in moeda = {ii:c}";
            
            Console.WriteLine(real);
            Console.WriteLine(perc);
            Console.WriteLine(hexa);
            Console.WriteLine(moeda);
            

        }
    }
}
