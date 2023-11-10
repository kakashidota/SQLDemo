using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace SQLDemo.Data
{
    internal class Courses
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Student> Students { get; set; }
    }
}
