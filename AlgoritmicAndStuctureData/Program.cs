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
        string name;
        int age;
        int id;
        int hash;
        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.hash = div_hash(id);
        }
        static int div_hash(int key)
        {
            return key % 10;
        }
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

        struct Node1
        {
            int data;
            Node left;
            Node right;
        }

        static Node Tree(int n)
        {
            Node newNode;
            int x, nl, nr;
            if (n == 0)
                newNode = NULL;
            else
            {
                fscanf(file, "%d", &x);
                nl = n / 2;
                nr = n – nl - 1;
                newNode = (Node*)malloc(sizeof(Node));
                newNode.data = x;
                newNode.left = Tree(nl);
                newNode->right = Tree(nr);
            }
            return newNode;
        }

        // Распечатка двоичного дерева в виде скобочной записи
        static void printTree(Node root)
        {
            if (root)
            {
                printf("%d", root->data);
                if (root->left || root->right)
                {
                    printf("(");
                    if (root->left)
                        printTree(root->left);
                    else
                        printf("NULL");
                    printf(",");
                    if (root->right)
                        printTree(root->right);
                    else
                        printf("NULL");
                    printf(")");
                }
            }
        }

        static void Task2()
        {
            // Построение идеально сбалансированного дерева с n узлами
            
        }


            static void Task1()
        {
            /* Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе
             * получается сумма кодов символов. */
            Console.Write("Введите данные: ");
            Console.Write("Хэш: " + Convert.ToString(CRC16_MODBUS(Console.ReadLine())));
        }

        static void Main(string[] args)
        {

            //Student[] student = new Student[10];

            //Student user1 = new Student("Василий", 23, 1223);
            //Console.WriteLine()
            Task1();
           
            Console.ReadLine();
        }
    }
}