using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod.AbstractProduct
{
    interface IMobile
    {
        decimal MinimumMobilePrice();
        decimal MaximumMobilePrice();
    }
}
