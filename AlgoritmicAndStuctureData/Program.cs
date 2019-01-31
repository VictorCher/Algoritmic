// Чернышов Виктор. Урок 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Student
    {
        public string name;
        public int age;
        public int id;
        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    class Program
    {
        static ushort CRC16_MODBUS(string key)
        {
            ushort hash = 0xFFFF;
            const ushort polynom = 0xA001;
            foreach (ushort i in key)
            {
                hash ^= i;
                for (int j = 0; j <= 7; j++)
                {
                    bool val = Convert.ToBoolean(hash-2*(hash/2));
                    hash >>= 1;
                    if (val == true) hash ^= polynom;
                }
            }
            return hash;
        }
       
        static int[] massive = { 1,2,3,4,5,6,7,8 };

        // Построение идеально сбалансированного дерева с n узлами
        static Node Tree(int n)
        {
            Node newNode = new Node();
            int x, nl, nr;
            if (n == 0) newNode = null;
            else
            {
                x = massive[n-1];
                nl = n / 2;
                nr = n - nl - 1;
                newNode.data = x;
                newNode.left = Tree(nl);
                newNode.right = Tree(nr);
            }    
            return newNode;
        }

        // Распечатка двоичного дерева в виде скобочной записи
        static void printTree(Node root)
        {
            if (root!=null)
            {
                Console.Write(root.data);
                if ((root.left!=null) || (root.right!=null))
                {
                    Console.Write('(');
                    if (root.left!=null)
                        printTree(root.left);
                    else
                        Console.Write("NULL");
                    Console.Write(',');
                    if (root.right!=null)
                        printTree(root.right);
                    else
                        Console.Write("NULL");
                    Console.Write(')');
                }
            }
        }

        static void Task1()
        {
            /* Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе
             * получается сумма кодов символов. */
            Console.Write("Введите данные: ");
            Console.Write("Хэш: " + Convert.ToString(CRC16_MODBUS(Console.ReadLine())));
        }

        static void Task2()
        {
            /* Переписать программу, реализующее двоичное дерево поиска:
             * a. Добавить в него обход дерева различными способами.
             * b. Реализовать поиск в нём.
             * c. *Добавить в программу обработку командной строки с помощью которой можно
             * указывать, из какого файла считывать данные, каким образом обходить дерево. */

            Node tree = Tree(massive.Length);
            printTree(tree);
        }

        static void Task3()
        {
            /* Разработать базу данных студентов, состоящую из полей «Имя», «Возраст», «Табельный
             * номер», в которой использовать все знания, полученные на уроках. Данные следует считать в
             * двоичное дерево поиска. Реализовать поиск по какому-нибудь полю базы данных. */

            Student peron1 = new Student("Василий", 23, 1223);
            Student peron2 = new Student("Виталий", 25, 2573);
            Student peron3 = new Student("Пётр", 21, 9573);
        }
        static void Main(string[] args)
        {
            //Task1();
            Task2();
           
            Console.ReadLine();
        }
    }
}