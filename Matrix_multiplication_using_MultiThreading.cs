using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrixB = {
            {10, 11, 12},
            {13, 14, 15},
            {16, 17, 18}
        };

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("Resultant Matrix:");

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        Thread[] threads = new Thread[rowsA];

        for (int i = 0; i < rowsA; i++)
        {
            int rowIndex = i;
            threads[i] = new Thread(() => MultiplyRow(matrixA, matrixB, resultMatrix, rowIndex));
            threads[i].Start();
        }

        for (int i = 0; i < rowsA; i++)
        {
            threads[i].Join();
        }

        return resultMatrix;
    }

    static void MultiplyRow(int[,] matrixA, int[,] matrixB, int[,] resultMatrix, int rowIndex)
    {
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;

            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[rowIndex, k] * matrixB[k, j];
            }

            resultMatrix[rowIndex, j] = sum;
        }
    }
}
