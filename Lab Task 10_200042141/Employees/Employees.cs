using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employees
    {
        public string id;
        public string firstName;
        public string lastName;
        public string email;
        public string phoneNumber;
        public string hireDate;
        public string jobId;
        public string salary;
        public string commission;
        public string managerId;
        public string departmentId;

        public string getInfo()
        {
            return (id + "\t" + firstName);
        }
    }
}
