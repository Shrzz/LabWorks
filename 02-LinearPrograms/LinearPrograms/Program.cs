using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x,y,z");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("х = " + x);
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = " + y);
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("z = " + z);
            double ch = (1 + Math.Pow(Math.Sin(x + y), 2)) * Math.Pow(x, Math.Abs(y));        
            double zn = Math.Abs(x - 2 * y / (1 + x * x * y * y));       
            double v;
            v = ch / zn;  
            ch = Math.Pow(Math.Cos(Math.Atan2(1, z)),2);   
            v += ch;
            Console.WriteLine("Значение функции v: " + v);
            Console.ReadLine();
        }
    }
}
