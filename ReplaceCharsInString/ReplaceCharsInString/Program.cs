﻿namespace ReplaceCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // creat a string of asterisks
            string aStr = "************";

            Console.WriteLine($"aStr: {aStr}");

            char[] stringArray = aStr.ToArray();

            // replace every other * with a + sign
            for (int i = 0; i < stringArray.Length; i+=2)
            {
                stringArray[i] = '+' ;
            }

            string newString = new String(stringArray);
            Console.WriteLine($"stringArray: {newString}");

        }
    }
}
