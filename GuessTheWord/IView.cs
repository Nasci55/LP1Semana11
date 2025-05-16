using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public interface IView
    {
        void userGuessedTheWord(string chosenWord);

        string playerGuess();

        void playerGuessedRight(string chosenWord);

        void playerFailed();

        void hintToThePlayer(string hint, char[] display);


    }
}