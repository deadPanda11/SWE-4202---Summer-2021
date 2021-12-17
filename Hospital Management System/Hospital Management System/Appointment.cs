using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Appointment
    {
        public string name;
        public int id;
        public string age;
        public string date;
        public string time;
        public string doctor;
        public string docname;

        public Appointment(string name, int id, string age, string date, string time, string doctor, string docname)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.date = date;
            this.time = time;
            this.doctor = doctor;
            this.docname = docname;
        }

        public string getInfo()
        {
            string apptinfo = name + "\t" + docname + "\t" + date + " \t" + time;
            return apptinfo;
        }
    }
}
