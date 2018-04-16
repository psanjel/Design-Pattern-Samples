using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class GoldCustomerFactory : CustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            GoldCustomer objCust = new GoldCustomer();
            objCust.GoldOperation();
            return objCust;
        }
    }
}
