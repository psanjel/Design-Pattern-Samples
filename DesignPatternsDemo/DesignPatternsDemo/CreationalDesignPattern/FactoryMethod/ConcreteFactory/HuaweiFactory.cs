using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod
{
    public class HuaweiFactory : IMobileFactory
    {
        public IMobile GetMobile()
        {
            return new Huawei();
        }
    }
}
