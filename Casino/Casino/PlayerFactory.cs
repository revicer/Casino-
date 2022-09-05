using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerFactory
    {
        private static List<string> _namesArray = new List<string> { "Bob", "John", "Mike", "Joshua", "Allan", "Kane", "Cris", "Teo", "Patrik", "Leo" };
        private static void PlayerName(CasinoPlayer player)
        {
            if (_namesArray.Count == 0)
            {
                return;
            }
            player.playerName = _namesArray[0];
            _namesArray.RemoveAt(0);
        }
        public static CasinoPlayer Create()
        {
            var casPlaya = new CasinoPlayer();
            PlayerName(casPlaya);
            PlayerCount.GetTotalPlayer().Add(1);
            return casPlaya;    
        }
    }
}
