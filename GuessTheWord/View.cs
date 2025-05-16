using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public class View : IView
    {
        public void hintToThePlayer(string hint, char[] display)
        {
            Console.WriteLine("Guess the full word!");
            Console.WriteLine($"Hint: It's a {hint}.");
            Console.WriteLine($"Word: {new string(display)}");
        }

        public void playerFailed()
        {
            Console.WriteLine("Incorrect. Try again.");
        }

        public string playerGuess()
        {
            Console.Write("Your guess: ");
            return Console.ReadLine().Trim().ToLower();
        }

        public void playerGuessedRight(string chosenWord)
        {
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }

        public void userGuessedTheWord(string chosenWord)
        {
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }
    }
}