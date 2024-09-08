namespace Ch12_Clasees_Exercise
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brands { get; set; }
        public string Description { get; set; }
    }

    internal class Appliance : Product
    {
        public string GeneralElectronic { get; set; }
        public string Home { get; set; }
        public string Kitchen { get; set; }
    }

    internal class Stove : Appliance
    {
        public string StoveSize { get; set; }
    }

    internal class TV : Appliance
    {
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
    }

    internal class Computers : Appliance
    {
        public string Ram { get; set; }
        public string Graphic { get; set; }
    }

    internal class Toys : Product
    {
        public string AgeRestric { get; set; }
        public string mateiral { get; set; }
    }
}
