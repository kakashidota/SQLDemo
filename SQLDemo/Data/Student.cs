using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDemo.Data
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Courses> Courses { get; set; }
    }
}
