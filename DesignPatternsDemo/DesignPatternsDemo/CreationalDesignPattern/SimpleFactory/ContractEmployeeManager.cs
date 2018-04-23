using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsDemo.CreationalDesignPattern.EnumClasses;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public EmployeeType GetEmployeeType()
        {
            return EmployeeType.CONTRACT;
        }

        public decimal GetPay()
        {
            return 12;
        }
    }
}
