namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces!");
            // interface = defines a "contract" that all the classes inheriting from should follow
            //             
            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"
            //
            //             Benefit = security + multiple ingeritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Lion lion = new Lion();
            Fish fish = new Fish();

            rabbit.Flee();
            lion.Hunt();
            fish.Hunt();
            fish.Flee();

        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("the rabbit is running away");
        }
    }

    class Lion : IPredator 
    {
        public void Hunt() 
        {
            Console.WriteLine("the lion is hunting");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("the fish is swimming away");
        }

        public void Hunt()
        {
            Console.WriteLine("the fish is hunting for smaller fishes");
        }
    }


}
