using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1606ConsoleApp
{
    class Libray
    {
        public string Name { get; set; }
        public List<Employe> employes;
        public List<Books> books;
        public Libray(string name)
        {
            Name = name;
            employes = new List<Employe>();
            books = new List<Books>();
        }
        
    }
}
