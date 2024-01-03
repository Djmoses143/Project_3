using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    public class Student : IComparable<Student>
    {
        public string Stuname { get; set; }
        public string Stuclass { get; set; }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            Student student = other as Student;
            if (student != null)
            {
                return this.Stuname.CompareTo(student.Stuname);
            }
            else
            {
                return -1;
            }
        }
    }
}
