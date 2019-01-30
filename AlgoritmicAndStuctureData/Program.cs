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