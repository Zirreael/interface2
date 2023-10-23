using System;

namespace ex4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество рядов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество мест в ряду: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, m];
            string str;
            string[] arr_str;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                arr_str = str.Split(' ');
                for(int j=0; j<m; j++)
                {
                    mas[i, j] = Convert.ToInt32(arr_str[j]);
                }
            }
            Console.WriteLine("Введите количество билетов для покупки: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            int rez = 0;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    if (mas[i, j] == 0)
                    {
                        flag++;
                        if (flag == k)
                        {
                            rez = i + 1;
                            break;
                        }
                    }
                    else
                        flag = 0;
                }
                if (flag == k)
                {
                    rez = i + 1;
                    break;
                }
            }
            Console.WriteLine("Вы можете купить билеты в ряду № " + rez);
        }
    }
}
