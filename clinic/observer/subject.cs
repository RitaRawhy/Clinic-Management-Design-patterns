using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
    class subject
    {
        public ArrayList ALNotify = new ArrayList();
        /// <summary>  
        /// Add object of notification System  
        /// </summary>  
        /// <param name="obj">Object is notification class</param>  
        public void AddService(Iobserver obj)
        {
            ALNotify.Add(obj);
        }
        /// <summary>  
        /// Remove object of notification System  
        /// </summary>  
        /// <param name="obj">Object of notification Calss</param>  
        public void RemoveService(Iobserver obj)
        {
            ALNotify.Remove(obj);
        }
        public void ExecuteNotifier()
        {
            foreach (Iobserver O in ALNotify)
            {
                string message="";
                //Call all notification System  
                O.Notify(message);
            }
        }
    }
    
}
