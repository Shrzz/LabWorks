using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class MyQueue
    {
        private int name;
        public Queue<Int32> queue = new Queue<Int32>();

        public MyQueue(int name)
        {
            this.name = name;
        }

        public void FillQueue(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                queue.Enqueue(random.Next(-100, 100));
            }
        }

        public void AddNums(int n, MyQueue queue1)
        {
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(queue1.queue.Dequeue());
            }
        }

        public void WriteQueue()
        {
            Console.WriteLine($"Очередь {name}:");   
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }
        }
    }
}
