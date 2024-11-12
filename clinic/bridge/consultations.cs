using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class consultations : appointment 
    {
        public override string patientname(string Pname)
        {
            return "\n Patient name : "+ Pname ;
        }
        public override string apptime(string time)
        {
            return "\n has consultation apointment at :"+ time;
        }
        
    }
}
