using System;
using System.Threading.Tasks;
using System.Threading;

namespace TPL
{
    class Program
    {
        static DateTime t1 = DateTime.Now;

        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                Console.WriteLine($"A: " + x.ToString());
                DateTime t2 = DateTime.Now;
                Console.WriteLine(t2 - t1);
            });
            Thread.Sleep(10000);
        }
    }
}
