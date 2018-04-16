using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class GoldCustomer : ICustomer
    {
        public void AddDiscounts()
        {
            Console.WriteLine("Gold Customer - Discounts Added.");
        }

        public void AddPoints()
        {
            Console.WriteLine("Gold Customer - Points Added.");
        }

        public void GoldOperation()
        {
            Console.WriteLine("Operation specific to Gold Customer.");
        }
    }
}
