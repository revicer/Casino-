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
        private RollCube _firstCube = new RollCube();
        private RollCube _secondCube = new RollCube();
        private int _roundBalance;
        private int _roundCost;

        public void StartRound(CasinoPlayer[] arrayPlayers)
        {
            _roundBalance = 0;
            _roundCost = 10;

            for (int i = 0; i < arrayPlayers.Length; i++)
            {
                arrayPlayers[i].RemoveChips(_roundCost);
                _roundBalance += _roundCost;
            }
            List<int> playerValue = IngameCubeRoll(arrayPlayers);
            IngameRound(arrayPlayers, playerValue);
        }
        private List<int> IngameCubeRoll (CasinoPlayer[] arrayPlayers)
        {
            List<int> playerCubeValue = new List<int>();

            for (int i = 0; i < arrayPlayers.Length; i++)
            {
                int cubesValue = _firstCube.Roll() + _secondCube.Roll();
                playerCubeValue.Add(cubesValue);
                Console.WriteLine(cubesValue);
            }
            return playerCubeValue;
        }
        private void IngameRound(CasinoPlayer[] arrayPlayers, List<int> playerCubeValue) 
        { 
            int[] _drawPlayerIndex = DrawRound(playerCubeValue);

            if (_drawPlayerIndex.Length > 1)
            {
                Console.WriteLine("Draw!");
                for (int i = 0; i < _drawPlayerIndex.Length; i++)
                {
                    arrayPlayers[i].AddChips(_roundBalance / _drawPlayerIndex.Length);
                }
            }
            else
            {
                var winnerIndex = playerCubeValue.IndexOf(playerCubeValue.Max());
                arrayPlayers[winnerIndex].AddChips(_roundBalance);
            }

            for (int i = 0; i <= arrayPlayers.Length - 1; i++)
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
