using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Participant
    {
        public string name;
        public int reg;
        public string contact;
        public string email;
        public string level;
        public double fee;
        public List<string> enrolled_courses = new List<string>();

        public virtual double getFee(double fee)
        {
            double totalfee = 0;
            totalfee += fee;
            return totalfee;
        }

        public void Enroll(string title)
        {
            enrolled_courses.Add(title);
        }

        public string EnrolledCourses()
        {
            string list = name + "\t" + reg + "\t";
            string new_list = "";
            for (int i = 0; i < enrolled_courses.Count; i++)
            {
                new_list = new_list + "\t" + enrolled_courses[i];
            }
            return (list + new_list);
        }
    }
}
