using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1606ConsoleApp
{
    class Books
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Id { get; }
        public static int _id;
        public Books()
        {

        }
        public Books(string name,  int year) : this()
        {
            Name = name;
            Year = year;
            Id = ++_id;

        }

    }
}
