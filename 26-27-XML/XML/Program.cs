using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

/*
 * Лабораторная работа №26-27
 * Выполнил Матус О.В., группа 7к2491
Вариант 2.
По заданной схеме (книжный магазин) построить XML-документ. Для
каждого элемента первого уровня предусмотреть не менее 3 экземпляров, для
каждого элемента последующих уровней – не менее двух экземпляров.
 */

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Directory.GetCurrentDirectory() + "\\lr26.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    Console.WriteLine(xnode.Attributes.GetNamedItem("code").Value);
                    Console.WriteLine("Работники в " + xnode.Attributes.GetNamedItem("name").Value + ":");
                    foreach (XmlNode childNode in xnode)
                    {
                        if (childNode.Name == "employee")
                        {
                            Console.WriteLine("Код сотрудника: {0}\nФИО сотрудника: {1}\nДолжность сотрудника: {2}", childNode.Attributes.GetNamedItem("code").Value, childNode.Attributes.GetNamedItem("fio").Value, childNode.Attributes.GetNamedItem("position").Value);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Книги в " + xnode.Attributes.GetNamedItem("name").Value + ": ");
                    foreach (XmlNode childNode in xnode)
                    {
                        if (childNode.Name == "book")
                        {
                            Console.WriteLine("Код книги: {0}\nНазвание книги: {1}\nГод издания книги: {2}\nЧисло страниц: {3}\n", childNode.Attributes.GetNamedItem("code").Value, childNode.Attributes.GetNamedItem("name").Value, childNode.Attributes.GetNamedItem("year").Value, childNode.Attributes.GetNamedItem("pages").Value); 
                            Console.WriteLine("Подробная информация о книге: ");
                            foreach (XmlNode childChild in childNode)
                            {
                                if (childChild.Name == "genre")
                                {
                                    Console.WriteLine("Код жанра: {0}, название жанра: {1}", childChild.Attributes.GetNamedItem("code").Value, childChild.Attributes.GetNamedItem("name").Value);
                                }

                                if (childChild.Name == "author")
                                {
                                    Console.WriteLine("Код автора: {0}, имя автора: {1}", childChild.Attributes.GetNamedItem("code").Value, childChild.Attributes.GetNamedItem("name").Value);
                                }

                                if (childChild.Name == "location")
                                {
                                    Console.WriteLine("Код места расположения: {0}, место расположения: {1}", childChild.Attributes.GetNamedItem("code").Value, childChild.Attributes.GetNamedItem("name").Value);
                                }

                                if (childChild.Name == "publisher")
                                {
                                    Console.WriteLine("Код издателя: {0}, название издателя: {1}", childChild.Attributes.GetNamedItem("code").Value, childChild.Attributes.GetNamedItem("name").Value);
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("---------------------------------------------------------");
                }
            }
        }
    }
}
