using System;
using HeadFirstDesignPatterns.StrategyPattern;
using HeadFirstDesignPatterns.ObserverPattern;
using HeadFirstDesignPatterns.DecoratorPattern;
using HeadFirstDesignPatterns.FactoryPattern;
using HeadFirstDesignPatterns.SingletonPattern;
using HeadFirstDesignPatterns.CommandPattern;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPattern();
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

        private static void SingletonPattern()
        {
            SingletonClassic singletonClassic = SingletonClassic.getInstance();
            Console.WriteLine(singletonClassic.getDescription());

            SingletonThreadSafe singletonThreadSafe = SingletonThreadSafe.getInstance();
            Console.WriteLine(singletonThreadSafe.getDescription());
        }

        private static void CommandPattern()
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light light = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            Command[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            Command[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.setCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On ---");
            remoteControl.onButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Off ---");
            remoteControl.offButtonWasPushed(0);
        }
    }
}
