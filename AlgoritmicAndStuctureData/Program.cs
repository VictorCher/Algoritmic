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
        static void Print(string msg, ref int [] mass)
        {
            Console.Write(msg);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }
        static int Task1(ref int [] mass)
        {
            /* Реализовать пузырьковую сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int count = 0;
            Console.WriteLine("Пузырьковая сортировка");
            Print("Массив до сортировки:          ", ref mass);
            for (int i = 0; i < mass.Length; i++)
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
            Print("Массив после сортировки:       ", ref mass);
            return count;
        }
        static int Task2(ref int[] mass)
        {
            /* Реализовать шейкерную сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int count = 0;
            Console.WriteLine("Шейкерная сортировка");
            Print("Массив до сортировки:          ", ref mass);
            int left = 0;
            int right = mass.Length - 1;
            for (int i = 0; i < mass.Length/2 - 1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = left; j < right; j++)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            int x = mass[j];
                            mass[j] = mass[j + 1];
                            mass[j + 1] = x;
                            count++;
                        }
                    }
                    right--;
                }
                else
                {
                    for (int j = right; j > left; j--)
                    {
                        if (mass[j] < mass[j - 1])
                        {
                            int x = mass[j];
                            mass[j] = mass[j - 1];
                            mass[j - 1] = x;
                            count++;
                        }
                    }
                    left++;
                }   
            }
            Print("Массив после сортировки:       ", ref mass);
            return count;
        }
        static int Task3(int value, ref int [] mass)
        {
            /* Реализовать алгоритм поиска в виде функции, которой передается отсортированный массив.
             * Функция должна возвращать индекс найденного элемента или -1, если элемент не найден.
             */
            for(int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == value) return i;
            }
            return -1;
        }
            static void Main(string[] args)
        {
            int[] mass = { 5, 3, 8, 1, 4, 10, 15, 2, 9, 7, 13 };
            Console.WriteLine("Кол-во операций перестановки:  " + Task1(ref mass));
            //Console.WriteLine("Кол-во операций перестановки:  " + Task2(ref mass));
            Console.Write("Какое число необходимо найти?: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс искомого элемента:      " + Task3(value, ref mass));

            Console.ReadLine();
        }
    }
}