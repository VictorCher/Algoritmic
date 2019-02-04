// Чернышов Виктор. Урок 7

/* 
 * 1. Написать функции, которые считывают матрицу смежности из файла и выводят её на экран.
 * 2. Написать рекурсивную функцию обхода графа в глубину.
 * 3. Написать функцию обхода графа в ширину
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
     class Program
    {
        static void Main(string[] args)
        {
            Graf.CreateGraf();
            Graf.InWidth(Graf.ReadGraf(), 0);

            Console.ReadLine();
        }
    }
}