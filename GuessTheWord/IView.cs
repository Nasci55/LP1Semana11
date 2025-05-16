using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public interface IView
    {
        void UserGuessedTheWord(string chosenWord);

        string PlayerGuess();

        void PlayerGuessedRight(string chosenWord);

        void PlayerFailed();

        void HintToThePlayer(string hint, char[] display);


    }
}