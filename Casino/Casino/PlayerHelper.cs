using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerHelper
    {
        public static List<string> namesArray = new List<string> { "Bob", "John", "Mike", "Joshua", "Allan", "Kane", "Cris", "Teo", "Patrik", "Leo" };
        public void PlayerName(CasinoPlayer player)
        {
            if (namesArray.Count == 0)
            {
                return;
            }
            player.playerName = namesArray[0];
            namesArray.RemoveAt(0);
        }
    }
}
