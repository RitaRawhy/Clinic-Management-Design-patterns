using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
   public interface Iobserver
    {
        string Notify(string message);
    }
}
