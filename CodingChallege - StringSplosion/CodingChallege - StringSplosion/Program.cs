namespace CodingChallege___StringSplosion
{
    internal class Program
    {
        /*Coding Challenge 9 – StringSplosion
            Given a non-empty string like "Code" return a string like "CCoCodCode".

            StringSplosion("Code") → "CCoCodCode"
            StringSplosion("abc") → "aababc"
            StringSplosion("ab") → "aab"
            public String StringSplosion(String str) {
            }
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the StringSplosion !");
            



        }

        public static String StringSplosion(String str)
        {
            // index for loop thru str
            // - get substring (0,1)

            string newstring = "";

            for (int i = 0; i < str.Length; i++)
            {
                newstring = str.Substring(i.1);
            }


        }



    }
}
