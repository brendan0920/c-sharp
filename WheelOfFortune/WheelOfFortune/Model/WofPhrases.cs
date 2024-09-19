namespace WheelOfFortune.Model
{
    public class WofPhrases
    {
        private static List<string> phrases = new List<string>
        {
            "A BLESSING IN DISGUISE", "BACK IN THE SADDLE", "BETTER LATE THAN NEVER", "BITE THE BULLET", "BREAK THE ICE", "BURNING THE MIDNIGHT OIL",
            "ON THE BALL", "CUTTING CORNERS", "DO NOT COUNT YOUR CHICKENS", "EASIER SAID THAN DONE", "EVERY CLOUD HAS A SILVER LINING",
            "FEELING UNDER THE WEATHER", "GETTING COLD FEET", "HIT THE NAIL ON THE HEAD", "IN THE NICK OF TIME", "IT IS A PIECE OF CAKE",
            "KILL TWO BIRDS WITH ONE STONE", "LET THE CAT OUT OF THE BAG", "NO PAIN NO GAIN", "YOU ARE WHAT YOU EAT", "OUT OF THE BLUE",
            "PUTTING ALL YOUR EGGS IN ONE BASKET", "READ BETWEEN THE LINES", "THE BALL IS IN YOUR COURT", "THROW IN THE TOWEL"
        };

        public static string GetPhrase()
        {
            Random random = new Random();
            int idx = random.Next(phrases.Count());
            string phrase = phrases[idx];
            // removing from list so we won't play the same phrase twice
            phrases.RemoveAt(idx);
            return phrase.ToUpper();
        }

        

        public string GetRandomWord()
        {
            Random random = new Random();
            return words[random.Next(words.Count)];
        }

        public string GetHiddenWord(string word)
        {
            string hiddenWord = "";
            foreach (char s in word)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }

        public string DisplayHiddenWord(string hiddenWord)
        {
            string displayString = "";
            foreach (char c in hiddenWord)
            {
                displayString += c + " ";
            }
            return displayString;
        }







    }
}
