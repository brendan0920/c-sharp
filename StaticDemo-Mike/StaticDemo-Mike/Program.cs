namespace StaticDemo_Mike
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BrendansUtils.DoStuff(123);

            Console.WriteLine(BrendansUtils.DoubleIt(100));
        }
    }


    static class BrendansUtils
    {
        static public void DoStuff(int x)
        {
            //Do work
        }
        static public int DoubleIt(int x) 
        {
            return x * 2;
        }
        static public int TripleIt(int x)
        {
            return x * 3;
        }
    }


}
