using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Course
    {
        public string title;
        public string level;
        public double coursefee;

        public Course(string title, string level, double coursefee)
        {
            this.title = title;
            this.level = level;
            this.coursefee = coursefee;
        }
    }
}
