using System;
using HeadFirstDesignPatterns.StrategyPattern;
using HeadFirstDesignPatterns.ObserverPattern;
using HeadFirstDesignPatterns.DecoratorPattern;
using HeadFirstDesignPatterns.FactoryPattern;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPattern();
        }

        private static void StrategyPattern()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }

        private static void ObserverPattern()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }

        private static void DecoratorPattern()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());
        }

        private static void FactoryPattern()
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.orderPizza("cheese");

            PizzaStore chiPizzaStore = new ChicagoPizzaStore();
            chiPizzaStore.orderPizza("cheese");
        }
    }
}
