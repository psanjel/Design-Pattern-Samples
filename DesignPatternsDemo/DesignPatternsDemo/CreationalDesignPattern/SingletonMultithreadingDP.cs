using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.CreationalDesignPattern
{
    public sealed class SingletonMultithreadingDP
    {
        private static int _counter = 0;
        private static SingletonMultithreadingDP _singletonInstance = null;

        private static readonly object obj = new object();
                
        /// <summary>
        /// Example of getting singleton instance in multi-threading, parallel invoke.
        /// </summary>
        public static SingletonMultithreadingDP GetInstance
        {
            get
            {
                if (_singletonInstance == null)
                {
                    lock (obj)
                    {
                        if (_singletonInstance == null)
                            _singletonInstance = new SingletonMultithreadingDP();
                    }
                }

                // NOTE :: Double verification of null instance checking is call double check locking.
                return _singletonInstance;
            }
        }
        private SingletonMultithreadingDP()
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
