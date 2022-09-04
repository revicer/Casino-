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
        public static CasinoPlayer Create ()
        {
           var casPlaya = new CasinoPlayer();
            var playerHelper = new PlayerHelper();
            playerHelper.PlayerName(casPlaya);
            return casPlaya;    
        }
    }
}
