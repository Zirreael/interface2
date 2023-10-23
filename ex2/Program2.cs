using System;

namespace ex2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = N / 2;
            int t;
            for(int i = 0; i < k; i++)
            {
                t = mas[i];
                mas[i] = mas[k + i];
                mas[k + i] = t;
            }
            if (N % 2 == 1)
            {
                for(int i = N - 1; i > k; i--)
                {
                    t = mas[i];
                    mas[i] = mas[i - 1];
                    mas[i - 1] = t;
                }
            }
            Console.WriteLine("Результат: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
