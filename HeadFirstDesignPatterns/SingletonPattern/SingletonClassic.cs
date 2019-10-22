using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.SingletonPattern
{
    // not thread safe
    public class SingletonClassic
    {
        private static SingletonClassic uniqueInstance;

        private SingletonClassic() { }

        public static SingletonClassic getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new SingletonClassic();
            }
            return uniqueInstance;
        }

        // other useful methods here
        public string getDescription()
        {
            return "I'm a classic Singleton!";
        }
    }
}
