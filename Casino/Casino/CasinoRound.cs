using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoRound
    {
        private RandomHelper _firstCube = new RandomHelper();
        private RandomHelper _secondCube = new RandomHelper();

        private int _roundBalance = 0;
        private const int _roundBet = 10;

        public int GetBetValue() { return _roundBet; }

        public void StartRound(List <CasinoPlayer>arrayPlayers)
        {
            _roundBalance = 0;

            for (int i = 0; i < arrayPlayers.Count; i++)
            {
                arrayPlayers[i].RemoveChips(GetBetValue());
                _roundBalance += _roundBet;
            }

            var playersRoll = new Dictionary<CasinoPlayer, int>();

            foreach (var player in arrayPlayers)
            {
                int cubeValue = _firstCube.RollCube() + _secondCube.RollCube();
                playersRoll.Add(player, cubeValue);
                Console.WriteLine(cubeValue);
            }

            CasinoPlayer[] winners = GetWinners(playersRoll);

            foreach (var player in winners)
            {
                player.AddChips(_roundBalance / winners.Length);
            }

            foreach (var player in arrayPlayers)
            {
                player.PlayerBalance();
            }
        }

        private CasinoPlayer[]  GetWinners (Dictionary<CasinoPlayer, int> playersRoll)
        {
            var winnersRound = new List<CasinoPlayer>();
            int tempMaxValue = int.MinValue;

            foreach (var playerRoll in playersRoll)
            {
                if (playerRoll.Value == tempMaxValue)
                {
                    winnersRound.Add(playerRoll.Key);
                    continue;
                }
                if (playerRoll.Value > tempMaxValue)
                {
                    tempMaxValue = playerRoll.Value;
                    winnersRound.Clear();
                    winnersRound.Add(playerRoll.Key);
                }
            }
            return winnersRound.ToArray();
        }
    }
}
