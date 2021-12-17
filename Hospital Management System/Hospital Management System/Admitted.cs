using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Admitted
    {
        public string name;
        public int id;
        public string age;
        public string roomno;

        public Admitted(string name, int id, string age, string roomno)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.roomno = roomno;
        }

        public string getInfo()
        {
            string admitinfo = name + "\t" + id + "\t" + age + "\t" + roomno;
            return admitinfo;
        }
    }
}
