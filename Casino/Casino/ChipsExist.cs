using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class ChipsExist
    {
        public bool isChipsExist(CasinoPlayer[] arrayPlayers)
        {
            for (int i = 0; i < arrayPlayers.Length; i++)
            {
                if (!arrayPlayers[i].ChipsNotNull())
                {
                    return false;    
                }
            }
            return true;
        }
    }
}
