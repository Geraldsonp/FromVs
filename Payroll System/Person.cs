using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public float ID { get; set; }
        public float HourWorked { get; set; }
        public float WagePH { get; set; }
        public bool PaidAlready { get; set; }

        public string DisplaMembers
        {    
            get
            {
                return string.Format("{0} {1}   ID:{2}", Name, LastName, ID);
            }
        }


    }
}
