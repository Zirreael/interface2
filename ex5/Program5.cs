using System;

namespace ex5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            int m = 1000;
            int s = 0;
            int[] matrix1 = new int[n];
            int[] matrix2 = new int[n];
            int[] rez = new int[n];
            for (int i=0; i<n; i++)
            {
                matrix1[i] = matrix2[i] = 1;
            }
            for (int k = 0; k < m; k++) //  фиксируем строку первой матрицы
            { 
                for (int i = 0; i < m; i++) //  по всем столбцам второй матрицы
                {
                    for (int j = 0; j < m; j++) //  каждый элемент первой матрицы
                    {
                        rez[s] += matrix1[j + k*m] * matrix2[i + j*m];
                    }
                    s++;
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(rez[i] + " ");
        }
    }
}
