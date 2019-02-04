using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Dek
    {
        int[] buff;
        int front = -1;
        int rear = -1;
        int size;

        public Dek(int size)
        {
            this.buff = new int[size];
            this.size = size;
        }
        public void Add(int value)
        {
            if(this.front < size) this.front++;
            else this.front = 0;
            this.buff[this.front] = value;
        }
        public void Sub(int value)
        {
            if (this.front == 0) this.front--;
            else this.front = size-1;
            this.buff[this.front] = value;
        }
        public int Get()
        {
            if (this.rear < size) this.rear++;
            else this.rear = 0;
            return this.buff[this.rear];
        }
        public bool Empty()
        {
            return this.front == this.rear;
        }
    }
}
