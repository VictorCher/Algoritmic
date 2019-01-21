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
        static void Print(string msg, int[] array)
        {
            int[] mass = array;
            Console.Write(msg);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }
        static int Task1(int[] array)
        {
            /* Реализовать пузырьковую сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int[] mass = new int[array.Length];
            Array.Copy(array, mass, array.Length);
            int count = 0;
            Console.WriteLine("Пузырьковая сортировка");
            Print("Массив до сортировки:          ", mass);
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int x = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = x;
                        count ++;
                    }
                    count++;
                }
                count++;
            }
            Print("Массив после сортировки:       ", mass);
            return count;
        }
        static int Task2(int[] array)
        {
            /* Реализовать шейкерную сортировку. Вывести количество операций, которые потребовались для сортировки.
             */
            int[] mass = array;
            int count = 0;
            Console.WriteLine("Шейкерная сортировка");
            Print("Массив до сортировки:          ", mass);
            int left = 0;
            int right = mass.Length - 1;
            for (int i = 0; i < mass.Length/2; i++)
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
                        count++;
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
                        count++;
                    }
                    left++;
                }
                count+=2;
            }
            Print("Массив после сортировки:       ", mass);
            return count;
        }
        static int Task3(int value, int[] array)
        {
            /* Реализовать алгоритм поиска методом половинного деления в виде функции, которой передается 
             * отсортированный массив.
             * Функция должна возвращать индекс найденного элемента или -1, если элемент не найден.
             */
            int[] mass = array;
            int left = 0;
            int rigth = mass.Length - 1;
            while (left <= rigth)
            {
                int i = left + (rigth - left) / 2;
                if (mass[i] > value) rigth = i - 1;
                else if (mass[i] < value) left = i + 1;
                else return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 8, 1, 4, 10, 15, 2, 9, 7};
            Console.WriteLine("Кол-во операций сравнения:     " + Task1(array));
            Console.WriteLine("Кол-во операций сравнения:     " + Task2(array));
            Console.Write("Какое число необходимо найти?: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Индекс искомого элемента:      " + Task3(value, array));

            Console.ReadLine();
        }
    }
}