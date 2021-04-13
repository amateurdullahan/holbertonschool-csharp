using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_num = Math.Abs(number % 10);
        Console.Write(last_num);
        return last_num;
    }
}
