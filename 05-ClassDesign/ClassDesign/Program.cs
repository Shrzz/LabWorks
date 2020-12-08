using System;

/* Лабораторная работа №5
 * Задание 2
 * Вариант 3
 * Класс: Треугольник
 * Поля: две стороны и угол между ними
 * Операции:
 *  увеличение/уменьшение размера угла на заданное количество процентов
 *  определение вида треугольника по числу равных сторон
 *  определение расстояния между центрами вписанной и описанной окружностей
 *  определение значение углов
 *Выполнил Матус О., гр. 7к2491*/

namespace ClassDesign
{   
    public class Triangle
    {
        //поля
        private double fs;
        private double ss;
        private double angle;

        //конструкторы
        public Triangle(){ fs = 4; ss = 5; angle = 90; }
        public Triangle(double fs) { this.fs = fs; ss = 10; angle = 45;  }
        public Triangle(double fs, double ss, double angle)
        {
            this.fs = fs;
            this.ss = ss;
            this.angle = angle;
        }

        //свойства полей
        public double Fs
        {
            get
            {
                return fs;
            }

            set
            {
                fs = value;
            }
        }

        public double Ss
        {
            get
            {
                return ss;
            }

            set
            {
                ss = value;
            }
        }

        public double Angle
        {
            get
            {
                return angle;
            }

            set
            {
                angle = value;
            }
        }

        public override string ToString()
        {
            return $"Стороны треугольника равны {fs} и {ss}, угол между этими сторонами равен {angle}";
        }

        public void ChangeAngleValue()
        {
            Console.WriteLine("Введите величину, на которую нужно изменить угол\n");
            double n = Convert.ToDouble(Console.ReadLine());
            n = (n / 100) * angle;
            Console.WriteLine("Выберите операцию\n1.Увеличить\n2.Уменьшить\n");
            byte ch = Convert.ToByte(Console.ReadLine());
            switch (ch)
            {
                   case 1:
                    angle += n;
                    break;
                case 2:
                    angle -= n;
                    break;
            }                      
            Console.WriteLine("\nТеперь угол составляет "+angle+" градусов\n");
        }

        //определить равенство сторон
        public void AreSidesEqual()
        {
            double ts = Math.Sqrt(fs * fs + ss * ss - 2 * fs * ss * Math.Round(Math.Cos((angle * Math.PI) / 180), 4));
            if ((fs == ss) || (ss == ts) || (fs == ts))
            {
                if( (fs == ss) && (ss == ts))
                    Console.WriteLine("Треугольник равносторонний\n");
                else
                    Console.WriteLine("Треугольник равнобедренный\n");
            }else
                Console.WriteLine("Треугольник разносторонний\n");
        }

        //найти разницу между радиусами
        public void FindRadiusDifference()
        {
            double ts = Math.Sqrt(fs * fs + ss * ss - 2 * fs * ss * Math.Round(Math.Cos((angle * Math.PI) / 180), 4));
            double p = 0.5 * (fs + ss + ts);
            double R = (fs * ss * ts) / (4 * Math.Sqrt(p * (p - fs) * (p - ss) * (p - ts)));
            double r = Math.Sqrt(((p - fs) * (p - ss) * (p - ts)) / p);
            R = R*R - 2 * R * r;
            Console.WriteLine("Разница между радиусами вписанной и описанной окружностей составляет " + R +"\n");
        }

        //найти остальные углы
        public void FindAngles()
        {
            double ts = Math.Sqrt(fs * fs + ss * ss - 2 * fs * ss * Math.Round(Math.Cos((angle * Math.PI) / 180), 4));
            double angle2 = Math.Acos((fs * fs + ts * ts - ss * ss ) / (2 * fs * ts)) * 180 / Math.PI;
            double angle3 = 180 - angle - angle2;
            Console.WriteLine("Величина первого угла равна " + angle + "\nВеличина второго угла равна " + angle2+"\nВеличина третьего угла равна "+angle3+"\n");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("Введите длину первой стороны треугольника");
            double ab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны треугольника");
            double bc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите величину угла между этими сторонами");
            double angle = Convert.ToDouble(Console.ReadLine());
            if (( ab <= 0 ) || ( bc <= 0 ) || ( angle <= 0 ) || ( angle > 90 ))
                Console.WriteLine("Треугольник с такими параметрами не может существовать");
            else
            {           
                Triangle mno = new Triangle();
                Triangle qrs = new Triangle(ab);
                Triangle triangle = new Triangle(ab, bc, angle);    
                Console.WriteLine($"mno: " + mno.ToString());
                Console.WriteLine("qrs: " + qrs.ToString());
                Console.WriteLine("triangle: " + triangle.ToString()); 
                triangle.ChangeAngleValue();           
                triangle.AreSidesEqual(); 
                triangle.FindRadiusDifference();
                triangle.FindAngles();
            }
        }
    }
}
