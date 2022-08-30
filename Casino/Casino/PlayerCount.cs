using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerCount
    {
        PlayerHelper PlayerHelper = new PlayerHelper();
        public void PlayerPerRound(List<CasinoPlayer> arrayPlayers)
        {
            PlayerAdded(arrayPlayers);
            PlayerRemover(arrayPlayers);
        }
        private void PlayerAdded(List<CasinoPlayer> arrayPlayers)
        {
            RandomHelper randomHelper = new RandomHelper();
            if (randomHelper.Roll(50))
            {
                arrayPlayers.Add(new CasinoPlayer());
            }
        }
        private void PlayerRemover(List<CasinoPlayer> arrayPlayers)
        {
            RandomHelper randomHelper = new RandomHelper();
            Random randomIndex = new Random();
            if (randomHelper.Roll(5))
            {
                arrayPlayers.Remove(arrayPlayers[randomIndex.Next(0, arrayPlayers.Count)]);

            }
        }
        public void PlayerDeleteZeroChips(List<CasinoPlayer> arrayPlayers)
        {
            for (int i = 0; i < arrayPlayers.Count; i++)
            {
                if (!arrayPlayers[i].ChipsNotZero())
                {
                    arrayPlayers.RemoveAt(i);
                }
            }

        }

    }
}
