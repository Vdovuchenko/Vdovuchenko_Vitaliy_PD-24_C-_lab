using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Lab_1()
        {
            Console.WriteLine("Сума двох перших цифр даного чотиризначного числа рівна сумі двох його останніх цифр");
            int x = int.Parse(Console.ReadLine());
            int sum_first = 0;
            int sum_second = 0;
            for (int i = 3; i >= 0; i--)
            {
                if (i >= 2)
                {
                    sum_first += x / (int)Math.Pow(10.0, i);
                    x = x % (int)Math.Pow(10.0, i);
                }
                else
                {
                    sum_second += x / (int)Math.Pow(10.0, i);
                    x = x % (int)Math.Pow(10.0, i);
                }
            }
            
            if(sum_first == sum_second){ Console.WriteLine(true); }
            else { Console.WriteLine(false); }
        } 
        static void Lab_2()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N+1];
            Random rand = new Random();
            int Max = 0;
            int num = 0;
            for (int i = 0; i < N-1; i++)
            {
                nums[i] = rand.Next(10);
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
            nums[N] = -1;
            Max = nums[0];

            for(int i = 0; i < N - 1; i++)
            {
                if (nums[i] >= nums[i + 1])
                {
                    num++;
                }
            }
            num--;
            Console.WriteLine(num);
        }
        static void Lab_3()
        {
            int M = int.Parse(Console.ReadLine());
            int[,] nums = new int[M, M];
            Random rand = new Random();
            int tmp = 0;

            Console.WriteLine("Початкова матриця");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    nums[i, j] = rand.Next(10);
                    Console.Write("{0} ", nums[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < (M / 2); i++)
            {
                for (int j = 0; j < M; j++)
                {
                    tmp = nums[i, j];
                    nums[i, j] = nums[(M - i - 1), j];
                    nums[(M - i - 1), j] = tmp;
                }
            }

            Console.WriteLine("Дзеркальна матриця");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0} ", nums[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Lab_4()
        {
            List<int> list = new List<int>();
            Console.Write("Введіть число: ");
            int num = int.Parse(Console.ReadLine());
            int Zero = 0;
            int One = 0;

            for(int i = 0; i < num; i++) {
                Console.Write($"Введіть число під індексом {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
                if(list[i] != 0 && list[i] != 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
                else if (list[i] == 0) { Zero++; }
                else { One++; }
            }

            Console.Write($"Кількість нулів {Zero}. Кількість одиниць {One}. \n");
            Console.WriteLine("Ліст");
            foreach (var item in list)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();

            int[] nums = new int[num];

            Console.WriteLine("Масив");
            for (int i = 0; i < num; i++)
            {
                nums[i] = list[i];
                Console.Write($"{nums[i]}  ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Lab_1();
            // НЕ РОБИТЬ // Lab_2();
            //Lab_3();
            //Lab_4();
        }
    }
}
