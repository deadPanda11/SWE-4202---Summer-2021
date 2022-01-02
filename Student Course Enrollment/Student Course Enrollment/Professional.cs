using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Professional: Participant
    {
        

        public Professional(string name, int reg, string contact, string email, string level, double fee)
        {
            this.name = name;
            this.reg = reg;
            this.contact = contact;
            this.email = email;
            this.level = level;
            this.fee = fee;
        }

        public override double getFee(double fee)
        {
            double profee = 0;
            profee = profee + fee + (0.1 * fee);
            return profee;
        }
    }
}
