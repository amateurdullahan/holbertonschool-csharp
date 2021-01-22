using System;

/// <summary>
///  arithmancy
/// </summary>
class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] vec = new double[] {0, 0};
            vec[0] = Math.Round((vector1[0] + vector2[0]), 2);
            vec[1] = Math.Round((vector1[1] + vector2[1]), 2);
            return (vec);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] vec = new double[] {0, 0, 0};
            vec[0] = Math.Round((vector1[0] + vector2[0]), 2);
            vec[1] = Math.Round((vector1[1] + vector2[1]), 2);
            vec[2] = Math.Round((vector1[2] + vector2[2]), 2);
            return (vec);
        }
        else
        {
            double[] vec = new double[] {-1};
            return (vec);
        }
    }
}
