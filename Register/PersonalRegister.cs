using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    class PersonalRegister
    {
        
        string namn;
        int lön;

        public void setNamn(string name)
        {
            namn = name;
        }

        public string getNamn()
        {
            return namn;
        }

        public void setLon(int salary)
        {
            lön = salary;
        }

        public int getLon()
        {
            return lön;
        }



    }
}
