// Чернышов Виктор. Урок 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Program
    {
        static int [] mass = { 5, 3, 8, 1, 4, 10, 15, 2, 9, 7 };
        static void Print(string msg, ref int [] mass)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }
        //static
        //static int answer;
        static int Task1(ref int [] mass)
        {
            /* Реализовать пузырьковую сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int count = 0;
            Console.WriteLine("Пузырьковая сортировка");
            Print("Массив до сортировки: ", ref mass);
            for(int i = 0; i < mass.Length; i++)
            {
               for(int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j]>mass[j + 1])
                    {
                        int x = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = x;
                        count++;
                    }
                }
            }
            Print("Массив после сортировки: ", ref mass);
            return count;
        }
        static int Task2(ref int[] mass)
        {
            /* Реализовать шейкерную сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int count = 0;
            Console.WriteLine("Шейкерная сортировка");



            Print("Массив после сортировки: ", ref mass);
            return count;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Количество операций: " + Task1(ref mass));
            Console.WriteLine("Количество операций: " + Task2(ref mass));
            Console.ReadLine();
        }
    }
}