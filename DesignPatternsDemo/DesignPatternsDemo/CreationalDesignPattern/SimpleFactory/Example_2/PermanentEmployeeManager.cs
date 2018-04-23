using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsDemo.CreationalDesignPattern.EnumClasses;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public EmployeeType GetEmployeeType()
        {
            return EmployeeType.FULLTIME;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}
