namespace MurachProductManager.Models
{
    internal class Software : Product, IWebPrintable
    {
        public string Version { get; set; }

        public Software(int id, string code, string description, decimal price, string version) : base(id, code, description, price)
        {
            this.Version = version;
        }

        public override string ToString()
        {
            return base.ToString() + $", version - {Version}";
        }

        public override void IPrintToWeb()
        {
            base.IPrintToWeb();
            Console.WriteLine($"{Version}");
        }

    }
}
