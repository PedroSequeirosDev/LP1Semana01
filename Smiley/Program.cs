using System;
using System.Globalization;
using System.Text;


namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            Console.WriteLine("insere código :");
            string input_1 = Console.ReadLine();

           int converted1 = System.Int32.Parse(input_1, NumberStyles.
           HexNumber);

           char charvalue = Convert.ToChar(converted1);
           

           Console.WriteLine("carácter Unicode : " + charvalue);

            

            
        }
    }
}
