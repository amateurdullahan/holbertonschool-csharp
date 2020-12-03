using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var lists = myDict.Keys.ToList();
        lists.Sort();

        foreach (var key in lists)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }   
    }    
}