using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class FullTimeEmployee : ISalaryProcessing
    {
        public decimal GetSalary()
        {
            decimal _salary = 110000;

            return _salary;
        }
    }
}
