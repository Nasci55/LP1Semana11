using System;
using System.Collections.Generic;
using GuessTheWord;

public class Program
{
    private static void Main()
    {
        IDictionary<string, string> wordsWithHints = new Dictionary<string, string>()
        {
            { "apple", "fruit" },
            { "banana", "fruit" },
            { "tiger", "animal" },
            { "elephant", "animal" },
            { "guitar", "instrument" },
            { "violin", "instrument" },
            { "canada", "country" },
            { "brazil", "country" },
            { "laptop", "object" },
            { "microscope", "scientific instrument" }
        };

        IView view = new View();
        // Select a random word
        Random rand = new Random();
        List<string> words = new List<string>(wordsWithHints.Keys);
        string chosenWord = words[rand.Next(words.Count)];
        string hint = wordsWithHints[chosenWord];

        // Determine revealed letter positions (up to 50% of the length)
        int length = chosenWord.Length;
        int numToReveal = Math.Max(1, (int)Math.Floor(length * 0.4));  // at least 1 letter
        char[] display = new string('_', length).ToCharArray();

        // Use hash code of the word for consistent seeding
        int seed = chosenWord.GetHashCode();
        Random maskRand = new Random(seed);

        HashSet<int> revealedIndices = new HashSet<int>();
        while (revealedIndices.Count < numToReveal)
        {
            int index = maskRand.Next(length);
            revealedIndices.Add(index);
        }

        foreach (int i in revealedIndices)
        {
            display[i] = chosenWord[i];
        }

        view.hintToThePlayer(hint, display);


        string guess;
        do
        {
            guess = view.playerGuess();

            if (guess != chosenWord)
                view.playerFailed();

        } while (guess != chosenWord);
        view.playerGuessedRight(chosenWord);


    }
}
