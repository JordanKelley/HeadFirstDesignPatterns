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
using HeadFirstDesignPatterns.IteratorPattern;
using HeadFirstDesignPatterns.CompositePattern;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositePattern();
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

        private static void DuckSortTestDrive()
        {
            TemplatePattern.Duck[] ducks =
            {
                new TemplatePattern.Duck("Daffy", 8),
                new TemplatePattern.Duck("Dewey", 2),
                new TemplatePattern.Duck("Howard", 7),
                new TemplatePattern.Duck("Louie", 2),
                new TemplatePattern.Duck("Donald", 10),
                new TemplatePattern.Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);
        }

        private static void Display(TemplatePattern.Duck[] ducks)
        {
            for(int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i]);
            }
        }

        private static void IteratorPattern()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            IteratorPattern.Waitress waitress = new IteratorPattern.Waitress(pancakeHouseMenu, dinerMenu);

            waitress.printMenu();
        }

        private static void CompositePattern()
        {
            MenuComponent pancakeHouseMenu = new CompositePattern.Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new CompositePattern.Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new CompositePattern.Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new CompositePattern.Menu("DESSERT MENU", "Dessert of course");
            MenuComponent coffeeMenu = new CompositePattern.Menu("COFFEE MENU", "Coffee");

            MenuComponent allMenus = new CompositePattern.Menu("ALL MENUS", "All menus combined");

            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            pancakeHouseMenu.add(new CompositePattern.MenuItem(
            "K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99));
            pancakeHouseMenu.add(new CompositePattern.MenuItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99));
            pancakeHouseMenu.add(new CompositePattern.MenuItem(
                "Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49));
            pancakeHouseMenu.add(new CompositePattern.MenuItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59));

            dinerMenu.add(new CompositePattern.MenuItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99));
            dinerMenu.add(new CompositePattern.MenuItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99));
            dinerMenu.add(new CompositePattern.MenuItem(
                "Soup of the day",
                "A bowl of the soup of the day, with a side of potato salad",
                false,
                3.29));
            dinerMenu.add(new CompositePattern.MenuItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false,
                3.05));
            dinerMenu.add(new CompositePattern.MenuItem(
                "Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice",
                true,
                3.99));

            dinerMenu.add(new CompositePattern.MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));

            dinerMenu.add(dessertMenu);

            dessertMenu.add(new CompositePattern.MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59));

            dessertMenu.add(new CompositePattern.MenuItem(
                "Cheesecake",
                "Creamy New York cheesecake, with a chocolate graham crust",
                true,
                1.99));
            dessertMenu.add(new CompositePattern.MenuItem(
                "Sorbet",
                "A scoop of raspberry and a scoop of lime",
                true,
                1.89));

            cafeMenu.add(new CompositePattern.MenuItem(
                "Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true,
                3.99));
            cafeMenu.add(new CompositePattern.MenuItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69));
            cafeMenu.add(new CompositePattern.MenuItem(
                "Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true,
                4.29));

            cafeMenu.add(coffeeMenu);

            coffeeMenu.add(new CompositePattern.MenuItem(
                "Coffee Cake",
                "Crumbly cake topped with cinnamon and walnuts",
                true,
                1.59));
            coffeeMenu.add(new CompositePattern.MenuItem(
                "Bagel",
                "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin",
                false,
                0.69));
            coffeeMenu.add(new CompositePattern.MenuItem(
                "Biscotti",
                "Three almond or hazelnut biscotti cookies",
                true,
                0.89));

            CompositePattern.Waitress waitress = new CompositePattern.Waitress(allMenus);

            waitress.printMenu();
        }
    }
}
