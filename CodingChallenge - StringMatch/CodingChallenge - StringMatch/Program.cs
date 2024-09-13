namespace CodingChallenge___StringMatch
{
    internal class Program
    {
        /*
         * Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" substrings appear in both strings.
 
            StringMatch("xxcaazz", "xxbaaz") → 3
            StringMatch("abc", "abc") → 2
            StringMatch("abc", "axc") → 0
 
            public int StringMatch(String a, String b) {
  
            }
        */


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int task1 = StringMatch("xxcaazz", "xxbaaz");
            int task2 = StringMatch("abcaaa", "abcaaa");
            int task3 = StringMatch("abc", "axc");

            Console.WriteLine(task1);
            Console.WriteLine(task2);
            Console.WriteLine(task3);
        }


        public static int StringMatch(String first, String second)
        {
            // count the same length 2 substring
            //string [] senta = { first };
            //string [] sentb = { second };

            int count = 0;
            for (int i = 0; i < first.Length -1; i++)
            {
                string str1 = first.Substring(i,2);

                for (int j = 0; j < second.Length -1; j++)
                {
                    string str2 = second.Substring(j,2);

                    if (str1 == str2)
                    {
                        count ++;
                    }
                }
            }
            return count;

        }
    }
}
