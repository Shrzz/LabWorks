using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApplication
{
    public class TableEntity
    {
        private string _name;
        private string _content;
        private int _attribAmount;
        private string[] _attribs;

        public TableEntity(string name, string content)
        {
            _name = name;
            _content = content;
            _attribs = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            _attribAmount = _attribs.Length;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
            }
        }

        public int AttribAmount
        {
            get => _attribAmount;
            set
            {
                _attribAmount = value;
            }
        }

        public string[] Attribs
        {
            get => _attribs;
            set
            {
                _attribs = value;
            }
        }


    }
}
