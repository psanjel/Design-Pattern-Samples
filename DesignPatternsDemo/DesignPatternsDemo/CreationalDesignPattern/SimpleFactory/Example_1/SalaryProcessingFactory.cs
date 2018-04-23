using DesignPatternsDemo.CreationalDesignPattern.EnumClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.SimpleFactory
{
    public class SalaryProcessingFactory
    {
        public virtual ISalaryProcessing RunSalaryProcessing(EmployeeType employeeType)
        {
            ISalaryProcessing salaryProcessing = null;
            switch(employeeType)
            {
                case EmployeeType.FULLTIME:
                    salaryProcessing = new FullTimeEmployee();
                    break;
                case EmployeeType.CONTRACT:
                    salaryProcessing = new ContractEmployee();
                    break;
            }
            return salaryProcessing;
        }
    }

    public class SalaryProcessingFactory2 : SalaryProcessingFactory
    {
        public override ISalaryProcessing RunSalaryProcessing(EmployeeType employeeType)
        {
            ISalaryProcessing salaryProcessing = null;
            switch (employeeType)
            {
                case EmployeeType.TEMPORARY:
                    salaryProcessing = new TemporaryEmployee();
                    break;
                default:
                    salaryProcessing = base.RunSalaryProcessing(employeeType);
                    break;
            }
            return salaryProcessing;
            
        }
    }
}
