using System;

namespace Alg7
{
    class Program
    {
        const int N = 5; // ширина доски
        const int M = 5;// высота доски
        static void Main(string[] args)
        {
            int[,] A = new int[N, M];
            int i, j;
            for (i = 0; i < N; i++)
            {
                A[i, 0] = 1; // заполняем первый столбец единицами
            }
            for (j = 0; j < M; j++)
            {
                A[0, j] = 1; //  заполняем первую строку единицами
            }

            for (i = 1; i < N; i++)
            {
                for (j = 1; j < M; j++)
                {
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
                }
            }

            Print(N, M, A);
            Console.WriteLine("Количество маршрутов = " + A[N-1, M-1]);
        }

        static void Print(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i, j]+"  ");
                Console.Write("\r\n");
            }
        }


    }
}
