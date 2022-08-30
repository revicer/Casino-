using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class ChipsExist
    {
        public bool isChipsExist(List<CasinoPlayer> arrayPlayers)
        {
            for (int i = 0; i < arrayPlayers.Count; i++)
            {
                if (arrayPlayers.Count == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
