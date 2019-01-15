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

        static void Main(string[] args)
        {
            Console.WriteLine("Ответ: " + Task3(3, 20));
            Console.ReadLine();
        }
    }
}