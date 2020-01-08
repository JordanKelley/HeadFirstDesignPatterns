using System;
using HeadFirstDesignPatterns.StrategyPattern;
using HeadFirstDesignPatterns.ObserverPattern;
using HeadFirstDesignPatterns.DecoratorPattern;
using HeadFirstDesignPatterns.FactoryPattern;
using HeadFirstDesignPatterns.SingletonPattern;
using HeadFirstDesignPatterns.CommandPattern;
using HeadFirstDesignPatterns.AdapterPattern;
using HeadFirstDesignPatterns.FacadePattern;
using HeadFirstDesignPatterns.TemplatePattern;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplatePattern();
        }

        private static void StrategyPattern()
        {
            StrategyPattern.Duck mallard = new StrategyPattern.MallardDuck();
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

        private static void AdapterPattern()
        {
            AdapterPattern.MallardDuck duck = new AdapterPattern.MallardDuck();

            WildTurkey turkey = new WildTurkey();
            AdapterPattern.Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("\nThe Duck says...");
            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            testDuck(turkeyAdapter);
        }

        private static void testDuck(AdapterPattern.Duck duck)
        {
            duck.quack();
            duck.fly();
        }

        private static void FacadePattern()
        {
            Amplifier amp = new Amplifier("amplifier");
            Tuner tuner = new Tuner("tuner", amp);
            DvdPlayer dvd = new DvdPlayer("Dvd Player", amp);
            CdPlayer cd = new CdPlayer("CD Player", amp);
            Projector projector = new Projector("Projector", dvd);
            Screen screen = new Screen("Screen");
            TheaterLights lights = new TheaterLights("Theater lights");
            PopcornPopper popper = new PopcornPopper("Popcorn popper");

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);

            homeTheater.watchMovie("Raiders of the Lost Ark");
            homeTheater.endMovie();
        }

        private static void TemplatePattern()
        {
            Tea tea = new Tea();
            Console.WriteLine("Preparing Tea");
            tea.prepareRecipe();

            Coffee coffee = new Coffee();
            Console.WriteLine("Preparing Coffee");
            coffee.prepareRecipe();
        }
    }
}
