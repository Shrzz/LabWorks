using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class MyStack
    {
        public Stack<Int32> stack = new Stack<Int32>();

        public void WriteStack()
        {
            Console.WriteLine("Стек: ");
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }
        }

        public void FillStack(int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                stack.Push(random.Next(-100,100));
            }
        }

        public int FindSum(int n)
        {
            int sum = 0;
            foreach(int x in stack)
            {
                sum += x;
            }
            return sum;
        }




    }
}
