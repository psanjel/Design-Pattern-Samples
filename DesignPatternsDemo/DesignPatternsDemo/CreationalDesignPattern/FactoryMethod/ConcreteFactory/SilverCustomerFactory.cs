using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class SilverCustomerFactory : CustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            SilverCustomer objCust = new SilverCustomer();
            objCust.SilverOperation();
            return objCust;
        }
    }
}
