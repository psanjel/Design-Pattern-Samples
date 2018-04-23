using DesignPatternsDemo.CreationalDesignPattern.EnumClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
        EmployeeType GetEmployeeType();
    }
}
