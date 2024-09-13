using System.Text;

namespace Ch09_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string str1 = "abd";
            Console.WriteLine(str1);
            str1 += "def";
            Console.WriteLine(str1);

            Console.WriteLine("StringBuilder");
            StringBuilder strb = new StringBuilder();
            strb.Append(str1);
            Console.WriteLine(strb);
            strb.Remove(2, 2);
            Console.WriteLine(strb);



        }
    }
}
