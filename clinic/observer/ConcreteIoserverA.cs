using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
   public class ConcreteIoserverA : Iobserver
    {
      public  string Notify(string message)
        {
            return message;
        }
    }
}
