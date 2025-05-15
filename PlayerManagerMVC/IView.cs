using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public interface IView
    {
        void DisplayMenu();
        void AddNewPlayer(List<Player> playerList);
        void LastProgramMessage();
        void ListOfAllPlayers(IEnumerable<Player> ListOfPlayers);
        void ErrorMessage();

    }
}