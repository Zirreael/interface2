using System;

namespace interface2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i=0; i<N; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите размер массива для вставки: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] mas2 = new int[M];
            Console.WriteLine("Введите элементы массива для вставки: ");
            for (int i = 0; i < M; i++)
            {
                mas2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите номер позиции, после которой осуществить вставку: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > N)
            {
                Console.WriteLine("В исходном массиве меньше элементов. Присоединение будет произведено с позиции " + N);
                k = N;
            }
            int t = N - k;
            int[] temp = new int[t];
            for(int i = 0; i < t; i++)
            {
                temp[i] = mas[k + i];
            }
            Array.Resize(ref mas, N + M);
            for (int i = 0; i < M; i++)
            {
                mas[k+i] = mas2[i];
            }
            for (int i = 0; i < t; i++)
            {
                mas[k + M + i] = temp[i];
            }
            Console.WriteLine("Результат: ");
            for (int i = 0; i < N+M; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
