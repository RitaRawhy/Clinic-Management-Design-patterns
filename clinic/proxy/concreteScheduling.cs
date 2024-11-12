using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class concreteScheduling : scheduling
    {
        public override string schedule_appointments(string pname, string time, string drname)
        {
            return "the patient : "+ pname+" at " + time+ " with "+drname;
        }
       
    }
}
