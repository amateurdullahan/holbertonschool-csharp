using System;

/// <summary> function for vector math </summary>
class VectorMath
{
    /// <summary> function for math </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]), 2);
        }
        else if (vector.Length == 3)
        {
            return Math.Round(Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]), 2);
        }
        else
        {
            return -1;
        }
    }
}
