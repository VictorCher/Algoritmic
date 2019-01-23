// Чернышов Виктор. Урок 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Program
    {
        static void Task1()
        {
            /* Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и 
             * нахождение количество маршрутов.*/
            /*int[,] map = {
                { 1, 1, 1},
                { 0, 1, 0},
                { 0, 1, 0}
            };*/
            int[,] map = {
                { 1, 1, 1},
                { 1, 1, 1},
                { 1, 1, 1}
            };
            int x = 3, y = 3;
            int[,] way = new int[x, y];
            for (int j = 0; j < y; j++) if (map[0, j] == 1) way[0, j] = 1;
            for (int i = 1; i < x; i++)
            {
                if(map[i, 0] == 1) way[i, 0] = 1;
                for (int j = 1; j < y; j++)
                {
                    if (map[i, j] == 1) way[i, j] = way[i, j - 1] + way[i - 1, j];
                    else way[i, j] = 0; 
                }
            }
            Console.WriteLine("Количество маршрутов равно: " + way[x - 1, y - 1]);
        }
        static void Task2()
        {
            /* Решить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы. */
            string word1 = "GEEKMINDS";
            string word2 = "GEEKBRAINS";
            int len1 = word1.Length;
            int len2 = word2.Length;
            int[,] max = new int[len1+1, len2+1];
            for (int i = 0; i < len1; i++)
            {
                char buff=' ';
                for (int j = 0; j < len2; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        max[i + 1, j + 1] = max[i, j] + 1;
                        buff = word1[i];
                    }
                    else
                    {
                        if (max[i, j + 1] > max[i + 1, j])
                            max[i + 1, j + 1] = max[i, j + 1];
                        else max[i + 1, j + 1] = max[i + 1, j];
                    }
                    //Console.Write(max[i + 1, j + 1] + " ");
                }
                //Console.WriteLine();
                if(buff!=' ')Console.Write(buff);
            }
            Console.WriteLine("\nДлина максимальной последовательности равна: " + max[len1, len2]);
        }
        static void Main(string[] args)
        {
            // Task1();
            Task2();

            Console.ReadLine();
        }
    }
}