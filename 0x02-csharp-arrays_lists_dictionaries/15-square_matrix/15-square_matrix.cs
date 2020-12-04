using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] nmatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        for (int h = 0; h < myMatrix.GetLength(0); h++)
        {
            for (int w = 0; w < myMatrix.GetLength(1); w++)
            {
                nmatrix[h, w] = myMatrix[h, w] * myMatrix[h, w];
            }
        }
        return nmatrix;
    }
}
