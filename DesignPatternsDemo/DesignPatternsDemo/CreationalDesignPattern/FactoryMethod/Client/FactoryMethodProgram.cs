using DesignPatternsDemo.CreationalDesignPattern.FactoryMethod.Client;
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

            PhonePriceChecker phonePriceChecker = new PhonePriceChecker();
            phonePriceChecker.GetMobileRangePrice(Manufactures.IPhone);
            Console.ReadLine();
        }
    }
}
