using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public class View : IView
    {
        public void HintToThePlayer(string hint, char[] display)
        {
            Console.WriteLine("Guess the full word!");
            Console.WriteLine($"Hint: It's a {hint}.");
            Console.WriteLine($"Word: {new string(display)}");
        }

        public void PlayerFailed()
        {
            Console.WriteLine("Incorrect. Try again.");
        }

        public string PlayerGuess()
        {
            Console.Write("Your guess: ");
            return Console.ReadLine().Trim().ToLower();
        }

        public void PlayerGuessedRight(string chosenWord)
        {
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }

        public void UserGuessedTheWord(string chosenWord)
        {
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }
    }
}