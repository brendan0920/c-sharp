
using System.Text;

namespace CodingChallenge_StringBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter a sentence: ");
            string enter = Console.ReadLine();

            Console.WriteLine(StringBits(enter)); 
        }

        public static String StringBits(String prompt)
        {
                       
            var sb = new System.Text.StringBuilder();

            for(int i = 0; i <= prompt.Length - 1; i += 2)
            {
                sb.Append(prompt[i]);
                
            }
            prompt = sb.ToString();
           
            return prompt;

        }

    }
}
