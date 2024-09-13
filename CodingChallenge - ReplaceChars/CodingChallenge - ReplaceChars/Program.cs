using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CodingChallenge___ReplaceChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(ReplaceVowelsWithUnderscores(input));

        }


        public static String ReplaceVowelsWithUnderscores(String prompt)
        {
            string vowels = "aeiou";
            
            foreach (char vowel in vowels)
            {
                prompt = prompt.Replace(vowel.ToString(), "_");
            }

            return prompt;
        }


        public static String ReplaceVowelsRegex (String prompt)
        {

            prompt = Regex.Replace(prompt, "[aeiouyAEIOUY]", "_");
            return prompt;

        }


            /* vowels: a, e, i, o, u, y
             * 1 - loop through letters of the sentence
             * 2 - for each letter, check if its in the vowels list
             * 3 - if yes - replace that sentence [index position] with an '_'
              
                char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'}   //'' - character array
              
                foreach (char vowel in vowels)
                if (sentence[i] == vowel)
                {
                    sentence = sentence.Replace(vowel, '_');
                }
                
                return sentence;
              
             */




        }
}
