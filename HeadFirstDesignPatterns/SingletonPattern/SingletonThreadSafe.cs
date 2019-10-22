using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.SingletonPattern
{
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe uniqueInstance = new SingletonThreadSafe();

        private SingletonThreadSafe() { }

        public static SingletonThreadSafe getInstance()
        {
            return uniqueInstance;
        }

        public string getDescription()
        {
            return "I'm a statically initialized Singleton";
        }
    }
}
