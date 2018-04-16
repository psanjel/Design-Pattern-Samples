using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern.FactoryMethod.Client
{
    public class PhonePriceChecker
    {
        IMobile _mobile;

        IMobileFactory _factory;
        
        public PhonePriceChecker()
        {
            
        }

        public void GetMobileRangePrice(Manufactures manufacture)
        {
            
            switch(manufacture)
            {
                case Manufactures.Huawei:
                    _factory = new HuaweiFactory();                    
                    break;
                case Manufactures.IPhone:
                    _factory = new IPhoneFactory();
                    break;
            }
            _mobile = _factory.GetMobile();
            Console.WriteLine(manufacture.ToString() + " phone price start from $" + _mobile.MinimumMobilePrice().ToString() + " to $" + _mobile.MaximumMobilePrice().ToString());
        }
    }
}
