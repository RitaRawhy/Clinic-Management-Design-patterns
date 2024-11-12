using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    interface Isubject
    {
        void attach(Iobserver observer);
        void detach(Iobserver observer);
        void notify();
    }
}
