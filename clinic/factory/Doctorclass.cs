using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class Doctorclass : IuserType
    {
  
        public void login()
        {
            doctor dr = new doctor();
            dr.Show();
         
        }
    }
}
