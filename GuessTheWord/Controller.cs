using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace GuessTheWord
{
    public class Controller
    {
        Random rand;
        IView _view;
        string _file;

        Dictionary<string, string> wordsWithHints;
        public Controller(IView view, string path)
        {
            _view = view;
            rand = new Random();
            wordsWithHints = new Dictionary<string, string>();

            string[] nameList = File.ReadAllLines(path);
            foreach (string set in nameList)
            {
                string[] wordDivider = set.Split(",");
                wordsWithHints.Add(wordDivider[0], wordDivider[1]);
            }

        }

        public void Start()
        {
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

            _view.HintToThePlayer(hint, display);


            string guess;
            do
            {
                guess = _view.PlayerGuess();

                if (guess != chosenWord)
                    _view.PlayerFailed();

            } while (guess != chosenWord);
            _view.PlayerGuessedRight(chosenWord);


        }
    }
}