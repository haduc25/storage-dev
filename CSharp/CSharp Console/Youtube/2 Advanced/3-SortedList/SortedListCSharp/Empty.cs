using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListCSharp
{
    public class Empty
    {
        private string hoten;
        private int age;

        public string Hoten { get => hoten; set => hoten = value; }
        public int Age { get => age; set => age = value; }
        //Create Contructer
        public Empty(string Hoten, int Age)
        {
            this.Hoten = Hoten;
            this.Age = Age;
        }
        //Use Override and ToString()
        public override string ToString()
        {
            return "Name: " + hoten + "\t| Age: " + age;
        }
    }
}
