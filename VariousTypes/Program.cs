using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");

            int num = 8;
            uint z = 7U;
            long y = 1L;
            ulong j = 5UL;

            char arrow ='\u21AB';
            char hand ='\u261A';

            Console.WriteLine(num);
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(j);
            Console.WriteLine(arrow);
            Console.WriteLine(hand);



        }
    }
}
