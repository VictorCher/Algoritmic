// Чернышов Виктор. Урок 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    public class Node<T>
    {
        public T data;
        public Node<T> Next;
        public Node(T _data) { data = _data; }
    }
    public class ListStack<T>
    {
        Node<T> head;
        int count;

        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head; 
            head = node;
            count++;
        }
        public T Pop()
        {
            Node<T> temp = head;
            if (count == 0) Console.WriteLine("Стек пуст");
            else
            {
                head = head.Next;
                count--;
            }
            return temp.data;
        }
    }
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
    public class Queue<T>
    {
        const int masSize = 3;
        T[] buf;
        int front = -1;
        int rear = -1;
        public Queue()
        {
            buf = new T[masSize];
        }
        public void Enqueue(T value)
        {
            if (rear < masSize - 1) rear++;
            else rear = 0;
            buf[rear] = value;
        }

        public T Dequeue()
        {
            if (front < masSize - 1) front++;
            else front = 0;
            return buf[front];
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
        static void Task4(ListStack<string> stack)
        {
            /* Создать функцию, копирующую односвязный список (то есть создающую в памяти копию
             * односвязного списка без удаления первого списка). */

            ListStack<string> CopyStack = new ListStack<string>();
            CopyStack = stack;
        }
        static void Task5(string line)
        {
            // Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
            Stack<char> Stack = new Stack<char>();
            int a = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if ((line[i] == '+') || (line[i] == '-'))
                {
                    Stack.Push(line[i]);
                    a++;
                }
                else Console.Write(line[i]);
            }
            for(int i = 0; i < a; i++) Console.Write(Stack.Pop());
        }
        static void Task6()
        {
            // Реализовать очередь с использованием массива.
            Queue<string> Queue = new Queue<string>();
            Queue.Enqueue("abcd");
            Queue.Enqueue("efgh");         
            string a = Queue.Dequeue();
            string b = Queue.Dequeue();
            Queue.Enqueue("ijkl");
            Queue.Enqueue("mnop");
            string c = Queue.Dequeue();
            string d = Queue.Dequeue();
            string e = Queue.Dequeue();
        }
        static void Main(string[] args)
        {
            // Task1(536);
            // Task3("[2/{5*(4+7)}]");
            /*
                        ListStack<string> stack = new ListStack<string>();
                        stack.Push("Tom");
                        stack.Push("Alice");
                        stack.Push("Bob");
                        stack.Push("Kate");
                        Task4(stack);
            */
            // Task5("2+3-1");
            Task6();

            Console.ReadLine();
        }
    }
}