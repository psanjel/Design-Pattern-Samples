using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public abstract class CustomerFactory // Base class.
    {
        public ICustomer GetCustomer()
        {
            ICustomer objCustomer = this.CreateCustomer();
            objCustomer.AddPoints();
            objCustomer.AddDiscounts();
            return objCustomer;
        }

        /// <summary>
        /// This is call factory method.
        /// </summary>
        /// <returns></returns>
        public abstract ICustomer CreateCustomer();
    }
}
