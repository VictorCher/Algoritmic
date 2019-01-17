// Чернышов Виктор. Урок 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Program
    {   
        static int answer;
        static int Task3(int a, int b)
        {
            /* Задача №3
         * Исполнитель "Калькулятор" преобразует целое число, записанное на экране.
         * У исполнителя две команды, каждой присвоен номер:
         * 1. Прибавь 1
         * 2. Умножь на 2
         * Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.
         * Сколько существует программ, которые число 3 преобразуют в 20?*/
            for (int i = 0; i < 2; i++)
            {
                int n = a;
                if (i == 0) n++;
                else n *= 2;
                if (n < b) Task3(n, b);
                else if (n == b) answer++;
            }
            return answer;
        }
        static void Task1(int n)
        {
            /* Задача №1
             * Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.*/
            int a = n / 2;
            n = n-(a * 2);
            if (a >= 2) Task1(a);
            else Console.Write(a);
            Console.Write(n);
        }
        static int Task2(int a, int b)
        {
            /* Задача №2
             * Реализовать функцию возведения числа а в степень b:
             * а. Без рекурсии
             * b. Рекурсивно*/         
            int result = 0;
            if ((a == 0) && (b == 0)) return result;
            result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        static void Main(string[] args)
        {
//          Console.WriteLine("Ответ: " + Task3(3, 20));
 /*           
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bin: ");
            Task1(n);
*/
/*            
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("В какую степень возвести?: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ: " + Task2(a, b));
*/     
            Console.ReadLine();
        }
    }
}