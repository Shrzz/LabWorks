using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class CollectionType<T>
    {
        private List<T> list;

        public CollectionType()
        {
            list = new List<T>();
        }

        ~CollectionType()
        {
            Console.WriteLine("Объект удалён");
        }
        
        public T this [int index]
        {
            set
            {
                if (index < 0 || index >= list.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    list[index] = value;
                }

            }

            get
            {
                if (index < 0 || index >= list.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return list[index];
                }
            }
        } 

        public int GetLength()
        {
            return list.Count;
        }    

        public void Add(T t)
        {
            list.Add(t);
        }

        public void Remove(T t)
        {
            list.Remove(t);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T x in list)
            {
                sb.Append(x + " ");
            }
            return sb.ToString();
        }
    }

}
