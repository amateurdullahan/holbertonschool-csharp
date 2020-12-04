using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    Console.Write("{0:D}{1:D}, ", i, j);
                }
            }
            Console.WriteLine("89");
        }
    }
}
