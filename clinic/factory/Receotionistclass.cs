using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class Receotionistclass : IuserType
    {
        userlogin us = new userlogin();
        public void login()
        {
            receptionist re = new receptionist();
            re.Show();
            us.Hide();
        }
    }
}
