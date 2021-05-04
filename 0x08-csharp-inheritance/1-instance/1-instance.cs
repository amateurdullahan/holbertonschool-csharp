using System;

/// <summary> utility functions </summary>
class Obj
{
    /// <summary> checks if array </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsArray == true)
        {
            return true;
        }
        return false;
    }
}