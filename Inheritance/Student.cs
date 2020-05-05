using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public string School { get; set; }

        public Student(string name, string school)
            :base(name)
        {
            this.School = school;
        }
    }
}
