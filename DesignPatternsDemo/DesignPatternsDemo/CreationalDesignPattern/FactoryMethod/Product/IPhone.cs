using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class IPhone : IMobile
    {
        public decimal MaximumMobilePrice()
        {
            decimal _maxPrice = 1200;
            return _maxPrice;
        }

        public decimal MinimumMobilePrice()
        {
            decimal _minPrice = 300;
            return _minPrice;
        }
    }
}
