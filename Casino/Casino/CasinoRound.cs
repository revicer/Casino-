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

        private int _roundBalance;
        private int _roundCost;



        public void StartRound(List <CasinoPlayer>arrayPlayers)
        {

            _roundBalance = 0;
            _roundCost = 10;

            for (int i = 0; i < arrayPlayers.Count; i++)
            {
                arrayPlayers[i].RemoveChips(_roundCost);
                _roundBalance += _roundCost;
            }
            List<int> playerValue = IngameCubeRoll(arrayPlayers);
            IngameRound(arrayPlayers, playerValue);
        }
        private List<int> IngameCubeRoll (List<CasinoPlayer> arrayPlayers)
        {
            List<int> playerCubeValue = new List<int>();

            for (int i = 0; i < arrayPlayers.Count; i++)
            {
                int cubesValue = _firstCube.RollCube() + _secondCube.RollCube();
                playerCubeValue.Add(cubesValue);
                Console.WriteLine(cubesValue);
            }
            return playerCubeValue;
        }
        private void IngameRound(List<CasinoPlayer> arrayPlayers, List<int> playerCubeValue) 
        { 
            int[] _drawPlayerIndex = DrawRound(playerCubeValue);

            if (_drawPlayerIndex.Length > 1)
            {
                Console.WriteLine("Draw!");
                for (int i = 0; i < _drawPlayerIndex.Length; i++)
                {
                    arrayPlayers[_drawPlayerIndex[i]].AddChips(_roundBalance / _drawPlayerIndex.Length);
                }
            }
            else
            {
                var winnerIndex = playerCubeValue.IndexOf(playerCubeValue.Max());
                arrayPlayers[winnerIndex].AddChips(_roundBalance);
            }

            for (int i = 0; i <= arrayPlayers.Count - 1; i++)
            {
                arrayPlayers[i].PlayerBalance();
            }

        }
        private int[] DrawRound(List<int> playerCubeValue)
        {
            var maxCubeValue = new List<int>();
            int tempMaxValue = int.MinValue;

            for (int i = 0; i < playerCubeValue.Count; i++)
            {
                var cubeValue = playerCubeValue[i];
                if (cubeValue == tempMaxValue)
                {
                    maxCubeValue.Add(i);
                    continue;
                }
                if (cubeValue > tempMaxValue)
                {
                    tempMaxValue = cubeValue;
                    maxCubeValue.Clear();
                    maxCubeValue.Add(i);
                }
            }
            return maxCubeValue.ToArray();
        }
    }
}
