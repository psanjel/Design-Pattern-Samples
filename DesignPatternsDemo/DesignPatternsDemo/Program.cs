using DesignPatternsDemo.CreationalDesignPattern.Singleton;
using DesignPatternsDemo.CreationalDesignPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton For Single Thread
            /*
            SingletonDP objSingletonDP1 = SingletonDP.GetInstance;
            objSingletonDP1.SumTwoNumbers(1, 2);
            

            SingletonDP objSingletonDP2 = SingletonDP.GetInstance;
            objSingletonDP2.SumTwoNumbers(3, 4);

            */
            #endregion

            #region Singleton For Multithread 
            /*
            Parallel.Invoke(
                () => FirstCalculation(),
                () => SecondCalculation()
                );
            */
            #endregion

            #region Factory Pattern

            // For Full Time Employee
            
            SalaryProcessingFactory2 factory = new SalaryProcessingFactory2();
            ISalaryProcessing salaryProcessing = factory.RunSalaryProcessing(EmployeeType.FULLTIME);
            decimal fullTimeSalary = salaryProcessing.GetSalary();

            salaryProcessing = factory.RunSalaryProcessing(EmployeeType.CONTRACT);
            decimal contractSalary = salaryProcessing.GetSalary();

            salaryProcessing = factory.RunSalaryProcessing(EmployeeType.TEMPORARY);
            decimal tempSalary = salaryProcessing.GetSalary();

            Console.WriteLine("Full Time Employee's Salary : " + fullTimeSalary.ToString());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Contract Employee's Salary : " + contractSalary.ToString());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Temporary Employee's Salary : " + tempSalary.ToString());

            // For Contract Employee
            #endregion

            Console.ReadLine();
        }

        private static void SecondCalculation()
        {
            SingletonMultithreadingDP objSingletonMultithreadingDP = SingletonMultithreadingDP.GetInstance;
            objSingletonMultithreadingDP.SumTwoNumbers(3, 4);
        }

        private static void FirstCalculation()
        {
            SingletonMultithreadingDP objSingletonMultithreadingDP = SingletonMultithreadingDP.GetInstance;
            objSingletonMultithreadingDP.SumTwoNumbers(1, 2);
        }
    }
}
