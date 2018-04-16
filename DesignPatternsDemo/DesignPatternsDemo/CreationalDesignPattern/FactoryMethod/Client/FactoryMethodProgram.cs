using DesignPatternsDemo.CreationalDesignPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class FactoryMethodProgram
    {
        static void Main(string[] args)
        {

            CustomerFactory objBaseCust = new GoldCustomerFactory();
            ICustomer objCust = objBaseCust.GetCustomer();
                
            Console.ReadLine();
        }
    }
}
