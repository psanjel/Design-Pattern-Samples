using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class TemporaryEmployee : ISalaryProcessing
    {
        public decimal GetSalary()
        {
            decimal _perDayHour = 6;
            decimal _perHour = 50;
            decimal _perWeekSalary = (_perDayHour * _perHour) * 6;

            return _perWeekSalary;
        }
    }
}
