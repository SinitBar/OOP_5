using System;

namespace OOP5LabaMatrix
{
    class MatrixMultiply
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] result = new int[2, 2] { { 0, 0 }, { 0, 0} };

            Console.WriteLine("Enter first matrix 2x2");

            for (int i = 0; i < 2; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' });
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(data[j]);
                }
            }

            Console.WriteLine("Enter second matrix 2x2");

            for (int i = 0; i < 2; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' });
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(data[j]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                        result[i, j] += a[i, k] * b[k, j];
                }
            }

            Console.WriteLine("the result of multiplication first on second:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0}", result[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
