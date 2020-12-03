using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            int len = array.Length - 1;
            for (int i = len; i >= 0; i--)
            {
                if (i > 0)
                {
                    Console.Write("{0} ", array[i]);
                }
                else
                {
                    Console.WriteLine("{0}", array[i]);
                }
            }
        }
    }
}