// Чернышов Виктор. Урок 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    public class Stack<T>
    {
        const int stackSize = 10;
        T[] buf;
        public int index = -1;
        public Stack()
        {
            buf = new T[stackSize];
        }
        public int Push(T value)
        {
            if (index < stackSize - 1)
            {
                index++;
                buf[index] = value;
            }
            else
            {
                Console.WriteLine("Стек переполнен");
                return -1;
            }
            return 0;
        }
        
        public T Pop()
        {
            if (index == -1) Console.WriteLine("\nСтек пуст");
            else return buf[index--];
            return buf[0];
        }
    }
    class Program
    {
        

        static void Task1(int n)
        {
            /* Реализовать перевод из десятичной в двоичную систему счисления с использованием стека. */
            Stack<int> Stack = new Stack<int>();
            do
            {
                if (n > 1)
                {
                    int a = n / 2;
                    Stack.Push(n - a * 2);
                    n = a;
                }
                else
                {
                    Stack.Push(n);
                    break;
                }
            } while (Stack.index != -1);
            while (Stack.index != -1) Console.Write(Stack.Pop());
        }
        static void Task3(string line)
        {
            /* Написать программу, которая определяет, является ли введённая скобочная
             * последовательность правильной. Примеры правильных скобочных выражений – (), ([])(), {}(), ([{}]), 
             * неправильных – )(, ())({), (, ])}), ([(]), для скобок – [, (, {.
             * Например: (2+(2*2)) или [2/{5*(4+7)}]. */
            Stack<char> Stack = new Stack<char>();
            for (int i=0; i < line.Length; i++)
            {
                if ((line[i] == '(') || (line[i] == '[') || (line[i] == '{')) Stack.Push(line[i]);
                if ((line[i] == ')') || (line[i] == ']') || (line[i] == '}'))
                {
                    char a = Stack.Pop();
                    if (a == ')') continue;
                    if (a == '}') continue;
                    if (a == ']') continue;
                }
            }
            if (Stack.index == -1) Console.WriteLine("Введённая скобочная последовательность правильная");
            else Console.WriteLine("Введённая скобочная последовательность содержит ошибку");
        }
        static void Main(string[] args)
        {
            // Task1(536);
            Task3("[2/{5*(4+7)}]");
            

            Console.ReadLine();
        }
    }
}