using System;

namespace ex3
{
    class Program3
    {
        static int[] arr_initialize(int size, int range)
        {
            int[] mas = new int[size];
            Random rand = new Random();
            for(int i=0; i<size; i++)
            {
                mas[i] = rand.Next(range);
            }
            return mas;
        }

        static int[] arr_sum(int[] mas1, int[] mas2)
        {
            if (mas1.Length != mas2.Length)
            {
                Console.WriteLine("Нельзя сложить массивы разной длины.");
                return null;
            }

            else
            {
                int[] rez = new int[mas1.Length];
                for (int i = 0; i < mas1.Length; i++)
                {
                    rez[i] = mas1[i] + mas2[i];
                }
                return rez;
            }
        }

        static void arr_mult(int[] mas, int num)
        {
            for(int i=0; i<mas.Length; i++)
            {
                mas[i] *= num;
            }
        }

        static int[] arr_find(int[] mas1, int[] mas2)
        {
            int size, size2, count;
            count = 0;
            if (mas1.Length < mas2.Length)
            {
                size = mas1.Length;
                size2 = mas2.Length;
            }
            else
            { 
                size = mas2.Length;
                size2 = mas1.Length;
            }
            int[] temp = new int[size];
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size2; j++)
                {
                    if (mas1[i] == mas2[j])
                    {
                        temp[i] = mas1[i];
                        count++;
                        break;
                    }
                    else
                        temp[i] = 0;
                }
            }
            int[] rez = new int[count];
            int t = 0;
            for (int i = 0; i < size; i++)
            {
                if (temp[i] != 0)
                {
                    rez[t] = temp[i];
                    t++;
                }
            }
            return rez;
        }

        static void arr_print(int[] mas)
        {
            if (mas != null)
            {
                for (int i = 0; i < mas.Length; i++)
                    Console.WriteLine(mas[i]);
            }
            else
                Console.WriteLine("NULL");
        }

        static void arr_sort(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        int z = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = z;
                    }
                }
            }
        }

        static int arr_max(int[] mas)
        {
            int max = mas[0];
            for(int i=1; i<mas.Length; i++)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            return max;
        }
        static int arr_min(int[] mas)
        {
            int min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min)
                    min = mas[i];
            }
            return min;
        }
        static int arr_avg(int[] mas)
        {
            int avg = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                avg += mas[i];
            }
            avg /= mas.Length;
            return avg;
        }
        static void Main(string[] args)
        {
            int[] mas = { 5, 2, 10, 8 };
            int[] mas2 = { 2, 3, 8, 9, 4 };
            int[] mas3 = { 2, 7, 8, 9, };
            int[] rez;
            int min, max, avg;
            arr_print(mas);
            arr_sort(ref mas);
            arr_print(mas);
            arr_mult(mas, 2);
            arr_print(mas);
            rez = arr_sum(mas, mas2);
            arr_print(rez);
            rez = arr_sum(mas, mas3);
            arr_print(rez);
            rez = arr_find(mas3, mas2);
            arr_print(rez);
            rez = arr_initialize(5, 100);
            arr_print(rez);
            min = arr_min(mas2);
            max = arr_max(mas2);
            avg = arr_avg(mas2);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
        }
    }
}
