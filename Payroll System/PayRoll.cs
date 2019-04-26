using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    public static class PayRoll
    {

        public static float CalculatePayroll(float Hours, float WagePh)
        {
            return Hours * WagePh;
        }

        public static bool Paythem(Person Person)
        {
            if (Person.PaidAlready)
                return true;
            else
                return false;
        }


    }
}
