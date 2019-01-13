// Чернышов Виктор. Урок 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Program
    {
        static void Task10()
        {
            /* Дано целое число N(> 0). С помощью операций деления нацело и взятия остатка от деления 
             * определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, 
             * если нет — вывести False.
             */
            Console.Write("Введите целое число больше нуля: ");
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                if ((n % 10) % 2 != 0)
                {
                    Console.WriteLine("True");
                    break;
                }
                n = n / 10;
                if(n==0)        
                Console.WriteLine("False");
            }
        }
        static void Task11()
        {
            /* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое 
             * всех положительных четных чисел, оканчивающихся на 8.
             */
            int n;
            int count = 0;
            float sum = 0;
            Console.WriteLine("Для выхода введите 0");
            while (true)
            {
                Console.Write("Введите число: ");
                n = int.Parse(Console.ReadLine());

                if (n == 0) break;
                if ((n % 2 == 0) && (n > 0) && (n % 10 == 8))
                {
                    count++;
                    sum += n;
                    Console.WriteLine("Среднее арифметическое: " + sum / count);
                }
            }
        }
        static void Task12()
        {
            /* Написать функцию нахождения максимального из трех чисел.
             */
            int max = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите число №" + i + ": ");
                int n = int.Parse(Console.ReadLine());
                if (i == 1){max = n;}
                else {if(max < n) max = n;}
            }
            Console.WriteLine("Максимальное число: " + max);
        }
        static void Task13()
        {
            /* Написать функцию, генерирующую случайное число от 1 до 100.
             * - с использованием стандартной функции rand()
             * - без использования стандартной функции rand()
             */
            Random rnd1 = new Random();
            Console.WriteLine("Случайное число 1: " + rnd1.Next(1,100));
            var rnd2 =DateTime.Now.Ticks % 100 + 1;
            Console.Write("Случайное число 2: " + rnd2);
        }
        static void Task14()
        {
            /* Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним 
             * цифрам своего квадрата. Например, 25 ^ 2 = 625. Напишите программу, которая вводит натуральное 
             * число N и выводит на экран все автоморфные числа, не превосходящие N.
             */
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n * n; i++)
            {
                int sqrt = i * i;
                if (sqrt > n * n) break;
                int count = 1;
                int a = i;
                while (true)
                {
                    a = a / 10;
                    count *= 10;
                    if (a == 0) break;   
                }
                if(sqrt % count == i) Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Task10();
            Task11();
            Task12();
            Task13();
            Task14();
            Console.ReadLine();
        }
    }
}