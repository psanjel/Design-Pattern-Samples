using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class Huawei : IMobile
    {
        public decimal MaximumMobilePrice()
        {
            decimal _maxPrice = 850;
            return _maxPrice;
        }

        public decimal MinimumMobilePrice()
        {
            decimal _minPrice = 150;
            return _minPrice;
        }
    }
}
