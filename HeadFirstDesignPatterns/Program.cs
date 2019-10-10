using HeadFirstDesignPatterns.StrategyPattern;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // strategy pattern
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
