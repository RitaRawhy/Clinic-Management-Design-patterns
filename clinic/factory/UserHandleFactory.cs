//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    class UserHandleFactory : IUserFactory

    {
        public IuserType GetType(string type)
        {
            switch(type)
            {
                case ("doctor"):
                    return new Doctorclass();

                case ("receptionist"):
                    return new Receotionistclass();

                case ("admin"):
                    return new Adminclass();
           
            }
           
            return null;
        }

    }
}
