namespace Ch09_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string msg = "anyone WHO takes more THAN thirty minutes for lunch is UNPROFESSIONAL.";
            
            string lowerMsg = msg.ToLower();
            Console.WriteLine(lowerMsg);

            string firstLetter = lowerMsg.Substring(0, 1).ToUpper();
            string lowerAll = lowerMsg.Substring(1, msg.Length).ToLower();
            string combine = firstLetter + lowerAll;
            Console.WriteLine($"upperA : {combine}");
            //Console.WriteLine($"upperA : {upperA + lowerAll}");

            string sixty = combine.Replace("thirty", "sixty");
            Console.WriteLine($"sixty : {sixty}");

            string fourty = sixty.Replace("sixty", "fourty");
            Console.WriteLine($"fourty : {fourty}");




        }
    }
}
