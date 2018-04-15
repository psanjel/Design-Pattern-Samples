using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public class ContractEmployee : ISalaryProcessing
    {
        public decimal GetSalary()
        {
            decimal _hour = 45;
            decimal _perHour = (40 * 4);
            decimal _salary = (_hour * _perHour) * 12;

            return _salary;
        }
    }
}
