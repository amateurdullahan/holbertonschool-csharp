using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        bool tf = aStack.Contains(search);
        Console.WriteLine("Stack contain \"{0}\": {1}", search, tf);
        while (aStack.Count != 0 && aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
