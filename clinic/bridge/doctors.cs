using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class doctors :reservation
    {

        public doctors(appointment app) : base(app)
        {

        }

       

        public override string reservations(string drname , string pname , string time)
        {
            return " \n with dr : "+ drname + base._app.patientname(pname) + _app.apptime(time); 
        }
    }
}
