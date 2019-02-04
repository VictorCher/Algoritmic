using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Graf
    {
        public static string path = "graf.txt";

        /// <summary>
        /// Создает текстовый файл с графом
        /// </summary>
        public static void CreateGraf()
        {
            byte[,] graf =
            {
                {0, 2, 0, 3},
                {2, 0, 1, 0},
                {0, 1, 0, 4},
                {3, 0, 4, 0},
            };
            StreamWriter file = new StreamWriter(path);
            int size = graf.GetLength(0);
            file.WriteLine(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    file.Write(graf[i, j] + " ");
                }
                file.WriteLine();
            }
            file.Close();
        }

        /// <summary>
        /// Считывает граф из текстового файла
        /// </summary>
        /// <returns></returns>
        public static int[,] ReadGraf()
        {
            Console.WriteLine("Дан граф:");
            StreamReader file = new StreamReader("graf.txt");
            int size = int.Parse(file.ReadLine());
            int[,] graf = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string line = file.ReadLine();
                int count = 0;
                for (int j = 0; j < size; j++)
                {
                    string buff = "";
                    while (true)
                    {
                        count++;
                        if (line[count - 1] == ' ') break;
                        buff += line[count - 1];
                    }
                    graf[i, j] = int.Parse(buff);
                    Console.Write(buff + ' ');
                }
                Console.WriteLine();
            }
            file.Close();
            return graf;
        }

        /// <summary>
        /// Обход графа в ширину
        /// </summary>
        /// <param name="graf"></param>
        /// <param name="node"></param>
        public static void InWidth(int[,] graf, int node)
        {
            Console.WriteLine("\nПошла волна...");
            int size = graf.GetLength(0);
            int[] wave = new int[size];
            Dek buff = new Dek(size);
            wave[node] = 1;
            do
            {
                wave[node]++;
                if (!buff.Empty())
                {
                    node = buff.Get();
                    Console.WriteLine("Волна дошла до узла: " + node);
                }
                for (int i = 0; i < size; i++)
                {
                    if (graf[node, i] != 0)
                    {
                        if (wave[i] < 1)
                        {
                            buff.Add(i);
                            wave[i]++;
                        }
                    }
                }
                if (wave[node] == 1) wave[node]++;
                PrintWave(wave);
                Console.WriteLine();
            } while (!buff.Empty());
            Console.WriteLine("Волна прошла");
        }

        /// <summary>
        /// Вывод на экран волны
        /// </summary>
        /// <param name="wave"></param>
        public static void PrintWave(int[] wave)
        {
            foreach (int i in wave)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Обход графа в глубину
        /// </summary>
        public static void InDepth(int[,] graf, int node)
        {
            Console.WriteLine("\nПошла волна...");
            int size = graf.GetLength(0);
            int[] wave = new int[size];
            Dek buff = new Dek(size);
            wave[node] = 1;
            do
            {

            } while (!buff.Empty());
        }
    }
}