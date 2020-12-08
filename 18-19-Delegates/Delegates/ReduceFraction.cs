using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class ReduceFraction
    {
        private int n;
        private int m;

        public ReduceFraction(int n, int m)
        {
            this.n = n;
            this.m = m;
        }

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public int M
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }

        public void Reduce()                           
        {
            if (m == 0)
            {
                throw new Exception("Дробь не может иметь 0 в знаменателе");
            }
            else
            {
                int buf = FindGCD();
                n /= buf;
                m /= buf;
            }
        }

        private int FindGCD()             
            {
            int buf;
            int n1 = n;
            int m1 = m;
            while (n1 != 0)
            {
                buf = m1 % n1;
                m1 = n1;
                n1 = buf;
            }
            return m1;
        }
    }
}
