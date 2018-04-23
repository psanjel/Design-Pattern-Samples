using DesignPatternsDemo.CreationalDesignPattern.EnumClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(EmployeeType empType)
        {
            IEmployeeManager empManager = null;

            switch(empType)
            {
                case EmployeeType.FULLTIME:
                    empManager = new PermanentEmployeeManager();
                    break;
                case EmployeeType.CONTRACT:
                    empManager = new ContractEmployeeManager();
                    break;
            }
            

            return empManager;
        }
    }
}
