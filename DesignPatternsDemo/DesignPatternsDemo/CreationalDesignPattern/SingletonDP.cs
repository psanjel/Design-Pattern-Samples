using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern
{
    public sealed class SingletonDP
    {

        private static int _counter = 0;
        private static SingletonDP _singletonInstance = null;
                

        /// <summary>
        /// Example of getting singleton instnace for single thread.
        /// </summary>
        public static SingletonDP GetInstance
        {
            get
            {
                if (_singletonInstance == null)
                    _singletonInstance = new SingletonDP();

                return _singletonInstance;
            }
        }
                
        private SingletonDP()
        {
            _counter++;
            Console.WriteLine("The number of times the instance created is : " + _counter.ToString());
        }
        public void SumTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of two number is : " + result.ToString());
        }
    }
}
