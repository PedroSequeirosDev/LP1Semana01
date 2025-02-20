using System;
using System.Text;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");

            Console.WriteLine("Insira um número inteiro");
            string input_1 = Console.ReadLine();

            int convertido_1 = int.Parse(input_1);

            Console.WriteLine("insira um número real");
            string input_2 = Console.ReadLine();

            float convertido_2 = float.Parse(input_2);

            Console.WriteLine($"A soma dos dois números fornecidos é {convertido_1 + convertido_2}");

        }
    }
}
