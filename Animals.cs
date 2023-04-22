using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examin_typa
{
    internal class Animals
    {
        private string _name;
        private string _location;
        private int _ostatok;

        public string Name
        {
            get { return _name; }
        }

        public string Location
        {
            get { return _location; }
        }

        public int Ostatok
        {
            get { return _ostatok; }
        }

        public Animals(string name, string location, int ostatok)
        {
            _name = name;
            _location = location;
            _ostatok = ostatok;
        }
    }
}
