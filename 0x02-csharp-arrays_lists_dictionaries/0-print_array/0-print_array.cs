using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] narry = new int[size];
            if (size == 0)
            {
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    narry[i] = i;
                    if (i != size - 1)
                    {
                        Console.Write("{0} ", i);
                    }
                    else
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            return narry;
        }
    }
}