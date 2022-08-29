using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class RoundWinner
    {
        public int IndexOfWinner(CasinoPlayer[] arrayPlayers, int winnerValue)
        {
            for (int i = 0; i < arrayPlayers.Length; i++)
            {
                if (i == winnerValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
