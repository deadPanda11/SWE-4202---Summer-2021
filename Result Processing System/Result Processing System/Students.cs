using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Processing_System
{
    internal class Students
    {
            public string id;
            public string name;
            public string attendance;
            public string quiz1;
            public string quiz2;
            public string quiz3;
            public string quiz4;
            public string mid;
            public string final;
            public string viva;

            public string getInfo()
            {
                return (id + "\t" + name);
            }
    }
}
