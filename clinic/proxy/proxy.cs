using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class proxy 
    {
        private concreteScheduling _scheduling;
        Dictionary<string, int> count = new Dictionary<string, int>();
        public string schedule_appointment(string pname, string time, string drname)
        {
            if (_scheduling == null)
            {

                _scheduling = new concreteScheduling();
            }
            if (!count.ContainsKey(pname))
            {
                count.Add(pname, 1);
                return _scheduling.schedule_appointments(pname, time, drname);
            }
            else
            {
                var patient = count.Where(x => x.Key == pname).FirstOrDefault();
                count[pname] = patient.Value + 1;
                // KeyValuePair<string, int> patient = count.FirstOrDefault(x => x.Key == pname);
                if (patient.Value >= 20)
                {

                    return "not available";
                }
                else
                {
                    return _scheduling.schedule_appointments(pname, time, drname);
                    
                }
            }
        }


        /* private scheduling _scheduling;
         ArrayList[] arr = new ArrayList[2];
         public string schedule_appointment(string pname, string time, string drname)
         {
             if (_scheduling == null)
             {

                 _scheduling = new concreteScheduling();
             }
             if (!arr.(pname))
             {
                 .Add(pname, 1);
                 return _scheduling.schedule_appointments(pname, time, drname);
             }

         }*/
    }
}
