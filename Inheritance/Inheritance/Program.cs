namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent
            //
            // getters & setters = add security to fields by encapsulation
            //                     They are accessors found within properties
            // properties = combine aspercts of both fields and methods (share name with a field)
            // get accessor = used to return the propery value
            // set accessor = use to assign a new value
            // value keyword = defiens the value being assigned by the set (parameter)


            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
