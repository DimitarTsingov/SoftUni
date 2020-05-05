using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
