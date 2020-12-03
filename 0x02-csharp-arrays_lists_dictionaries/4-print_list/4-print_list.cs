using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> nlist = new List<int>();
            if (size == 0)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                nlist.Add(i);
                if (i < size - 1)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }
            return nlist;
        }
    }
}