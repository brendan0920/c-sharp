namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism");
            //Polymorphism = Greek word that means to "have many forms"
            //               Objects can be identified any more than one type
            //               Ex. A Dog is also: Canince, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehichles = { car, bicycle, boat };
            foreach (Vehicle v in vehichles) 
            {
                v.Go();
            }
            
        }
    }

    // Parent class
    class Vehicle
    {
        public virtual void Go()
        {

        }
    }

    // Child classes

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
