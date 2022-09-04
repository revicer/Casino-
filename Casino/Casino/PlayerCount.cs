using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerCount
    {
        RandomHelper randomHelper = new RandomHelper();
        Random randomIndex = new Random();
        private static int _maxPlayerCoutn = 8;
        List<int> playersAtAll = new List<int>(_maxPlayerCoutn);
        public void PlayerPerRound(List<CasinoPlayer> arrayPlayers)
        {
            if (playersAtAll.Count < _maxPlayerCoutn)
            {
                PlayerAdded(arrayPlayers);
            }
            PlayerRemover(arrayPlayers);
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
        public void PlayerCheck(List<CasinoPlayer> arrayPlayers)
        {
            playersAtAll.Add(1);
        }
        private void PlayerAdded(List<CasinoPlayer> arrayPlayers)
        {
            if (randomHelper.Roll(30))
            {
                arrayPlayers.Add(PlayerFactory.Create());
                PlayerCheck(arrayPlayers);
            }
        }
        private void PlayerRemover(List<CasinoPlayer> arrayPlayers)
        {
            if (randomHelper.Roll(30))
            {
                arrayPlayers.Remove(arrayPlayers[randomIndex.Next(0, arrayPlayers.Count)]);

            }
        }
    }
}
