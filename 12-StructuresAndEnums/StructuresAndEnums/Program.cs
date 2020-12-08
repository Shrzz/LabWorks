using System;

/*
 * Лабораторная работа №12
 * Выполнил Матус О., группа 7к2491
 * Вариант 2. Описать структуру с именем STUDENT, содержащую следующие поля:
 • фамилия и инициалы;
 • номер группы;
 • успеваемость (массив из пяти элементов).
 Написать программу, выполняющую следующие действия:
 • ввод с клавиатуры данных в массив, состоящий из десяти структур типа
 STUDENT (записи должны быть упорядочены по возрастанию среднего балла);
 • вывод на экран фамилий и номеров групп для всех студентов, имеющих
 оценки 8 - 10 (если таких студентов нет, вывести соответствующее сообщение). 
 */

namespace StructuresAndEnums
{
    struct Student
    {
        const int student_amount = 10;
        const int ocenki_amount = 5;

        public string fio;
        public string group;
        public byte[] ocenki;
        public double average;

        static Student AddInfo()
        {
            Student s = new Student();
            Console.WriteLine("ФИО:");
            s.fio = Console.ReadLine();
            Console.WriteLine("Группа:");
            s.group = Console.ReadLine();
            Console.WriteLine($"Текущие оценки студента ({ocenki_amount} оценок): ");
            s.ocenki = new byte[5];
            for (int i = 0; i < ocenki_amount; i++)
            {
                s.ocenki[i] = Convert.ToByte(Random());
            }

            int Random()
            {
                Random random = new Random();
                return random.Next(5, 10);
            }

            return s;
        }

        //поиск средней оценки каждого студента в массиве студентов
        static int FindAverage(byte[] b)
        {
            int buf = 0;
            for (int i = 0; i < ocenki_amount; i++)
            {
                buf += b[i];
            }
            return buf /= ocenki_amount;  
        }

        //анализируем оценки и отмечаем неуспевающих false
        static void Analysis(Student[] mas, ref bool[] res)     
        {
            res = new bool[student_amount];
            for (int i = 0; i < student_amount; i++)
            {
                for (int j = 0; j < ocenki_amount; j++)
                {
                    if (mas[i].ocenki[j] < 8)
                    {
                        res[i] = false;      
                        break;
                    }
                }
            }
        }

        //проверка на наличие неуспевающие
        static bool Check(bool[] mas)           
        {
            if (Array.IndexOf(mas, true) == -1)     
                return false;
            else
                return true;                        
        }

        //отображение информации об отличниках
        static public void Display(Student[] mas, bool[] res)              
        {
            if (Check(res))
            {
                Console.WriteLine("Отличники:");
                for (int i = 0; i < student_amount; i++)
                {
                    if (res[i] == true)
                    {
                        Console.WriteLine($"{mas[i].fio}, группа {mas[i].group}, средний балл - {mas[i].average}");
                        Console.WriteLine("Текущие оценки:");
                        for (int k = 0; k < ocenki_amount; k++)
                        {
                            Console.Write(mas[i].ocenki[k]+" ");
                        }
                        Console.WriteLine();    
                    }
                }
            }
            else
            {
                Console.WriteLine("Отличников нет.");
            }
        }

        //по возрастанию
        static public void SortStudents(Student[] mas)                 
        {
            int len = mas.Length;
            Student buf;
            for (int i = 0; i < len-1; i++)
            {
                if (mas[i].average > mas[i + 1].average)
                {
                    buf = mas[i+1];
                    mas[i + 1] = mas[i];
                    mas[i] = buf;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные студентов:");
            Student[] mas = new Student[student_amount];
            bool[] res = new bool[student_amount];
            for (int i = 0; i < student_amount; i++)
            {
                res[i] = true;
                Console.WriteLine($"Студент #{i + 1}");
                mas[i] = AddInfo();
                mas[i].average = FindAverage(mas[i].ocenki);
            }
            SortStudents(mas);
            Analysis(mas,ref res);
            Display(mas, res);
        }
    }
}
