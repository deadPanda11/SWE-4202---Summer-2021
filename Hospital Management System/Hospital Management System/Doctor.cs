using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Doctor
    {
        public string name;
        public int id;
        public string specialization;
        public string degree;
        public string branch;

        public Doctor(string name, int id, string specialization, string degree, string branch)
        {
            this.name = name;
            this.id = id;
            this.specialization = specialization;
            this.degree = degree;
            this.branch = branch;
        }

        public string getInfo()
        {
            string doctorinfo = name + "\t" + id + "\t" + specialization + "\t" + branch;
            return doctorinfo;
        }
    }
}
