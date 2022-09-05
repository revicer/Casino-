using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class PlayerCount
    {
        private RandomHelper _randomHelper = new RandomHelper();
        private Random _randomIndex = new Random();
        private static int _maxPlayerCount = 10;
        private static List<int> _playersAtAll = new List<int>(_maxPlayerCount);
        
        public static List<int> GetTotalPlayer() { return _playersAtAll; }

        public void PlayerPerRound(List<CasinoPlayer> arrayPlayers)
        {
            if (_playersAtAll.Count < _maxPlayerCount)
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

        private void PlayerAdded(List<CasinoPlayer> arrayPlayers)
        {
            if (_randomHelper.Roll(30))
            {
                arrayPlayers.Add(PlayerFactory.Create());
            }
        }

        private void PlayerRemover(List<CasinoPlayer> arrayPlayers)
        {
            if (_randomHelper.Roll(5))
            {
                arrayPlayers.Remove(arrayPlayers[_randomIndex.Next(0, arrayPlayers.Count)]);

            }
        }
    }
}
