using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Xml.Serialization;

namespace UserDialogs
{
    public class FileManager
    {
        private string path;

        public FileManager(string path)
        {
            this.path = path;
        }

        public BindingList<Book> LoadData()
        {
            BindingList<Book> list = null;
            XmlSerializer xs = new XmlSerializer(typeof(BindingList<Book>));
            using (StreamReader sr = new StreamReader(path))
            {
                list = (BindingList<Book>)xs.Deserialize(sr);   
            }
            foreach (Book b in list)
            {
                b.creationDate = DateTime.Now;
            }
            return list;           
        }

        public void SaveData(BindingList<Book> list)
        {
            XmlSerializer xs = new XmlSerializer(typeof(BindingList<Book>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xs.Serialize(fs, list);
            }     
        }
    }
}
