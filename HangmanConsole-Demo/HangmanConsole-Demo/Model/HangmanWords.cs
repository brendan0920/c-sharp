using System.Reflection;

namespace HangmanConsole_Demo.Model
{
    public class HangmanWords
    {
        List<string> words { get; set;}

        public HangmanWords()
        {
            words= new List<string> { "strange", "halloween", "crystal", "program", "super", "noisey", "table", "histroy",
                                      "crazy", "dodgey", "standard", "automobile" };         // how to re-initialize a list
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
