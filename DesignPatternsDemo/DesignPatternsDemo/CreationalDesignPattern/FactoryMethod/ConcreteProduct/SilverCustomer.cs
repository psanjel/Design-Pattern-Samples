using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class SilverCustomer : ICustomer
    {
        public void AddDiscounts()
        {
            Console.WriteLine("Silver Customer - Discounts Added.");
        }

        public void AddPoints()
        {
            Console.WriteLine("Silver Customer - Points Added.");
        }

        public void SilverOperation()
        {
            Console.WriteLine("Operation specific to Silver Customer.");
        }
    }
}
