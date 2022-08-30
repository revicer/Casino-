using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerHelper
    {
        public List<string> namesArray = new List<string> { "Bob", "John", "Mike", "Joshua", "Allan", "Kane", "Cris", "Teo", "Patrik", "Leo" };
        string playerName;
        public void PlayerName(List<CasinoPlayer> arrayPlayers)
        {
            playerName = namesArray[0];
            namesArray.RemoveAt(0);
        }
    }
}
