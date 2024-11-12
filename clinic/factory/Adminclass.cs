using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace clinic
{
    class Adminclass : IuserType
    {
        
        public void login()
        {
            admin ad = new admin();
            ad.Show();
        
        }
        
    }
}
