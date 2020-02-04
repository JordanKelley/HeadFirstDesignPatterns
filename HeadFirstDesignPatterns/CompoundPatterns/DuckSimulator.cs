using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.CompoundPatterns
{
    public class DuckSimulator
    {
        public DuckSimulator()
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulate(duckFactory);
        }
        public void simulate(AbstractDuckFactory duckFactory)
        {
            Quackable redheadDuck = duckFactory.createRedheadDuck();
            Quackable duckCall = duckFactory.createDuckCall();
            Quackable rubberDuck = duckFactory.createRubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());

            Flock flockOfDucks = new Flock();

            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseDuck);

            Flock flockOfMallards = new Flock();

            Quackable mallardOne = duckFactory.createMallardDuck();
            Quackable mallardTwo = duckFactory.createMallardDuck();
            Quackable mallardThree = duckFactory.createMallardDuck();
            Quackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockOfDucks.add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");

            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);

            simulate(flockOfDucks);

            Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times");
        }

        private void simulate(Quackable duck)
        {
            duck.quack();
        }
    }
}
