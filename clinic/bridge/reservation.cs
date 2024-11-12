using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    abstract class reservation
    {
       public appointment _app ;
        public reservation(appointment app)
        { this._app = app ; }
        abstract public string reservations(string drname, string pname, string time);

    }
    
}
