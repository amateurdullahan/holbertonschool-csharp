using System;
using System.Reflection;

class Obj
{
    /// <summary> prints all properties and methods </summary>
    public static void Print(object myObj) 
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (PropertyInfo property in myObj.GetType().GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (MethodInfo method in myObj.GetType().GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
