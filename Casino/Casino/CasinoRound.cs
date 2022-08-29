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
        RollCube firstPlayerCube = new RollCube();
        RollCube secondPlayerCube = new RollCube();
        RoundWinner roundWinner = new RoundWinner();
        IsDraw isDraw = new IsDraw();
        private int _roundBalance;
        private int _roundAmount;

        //public void PlayerRoll(int cubesValue)
        //{
        //    //List<int> playerCubeValue = new List<int>();
        //    //playerCubeValue.Add(cubesValue);
        //    //var winnerValue = playerCubeValue.IndexOf(playerCubeValue.Max());
        //}
        public void Round(CasinoPlayer[] arrayPlayers)
        {
            _roundBalance = 0;
            _roundAmount = 10;

            for (int i = 0; i <= arrayPlayers.Length - 1; i++)
            {
                arrayPlayers[i].RemoveChips(_roundAmount);
            }

            _roundBalance += _roundAmount*arrayPlayers.Length;

            List<int> playerCubeValue = new List<int>();

            for (int i = 0; i <= arrayPlayers.Length-1; i++)
            {
                int cubesValue = firstPlayerCube.Roll() + secondPlayerCube.Roll();
                playerCubeValue.Add(cubesValue);
                Console.WriteLine(cubesValue);
            }

            if (IsDraw.DrawRound(playerCubeValue))
            {
                Console.WriteLine("Draw!");
                for (int i = 0; i <= arrayPlayers.Length - 1; i++)
                {
                    arrayPlayers[i].AddChips(_roundBalance / arrayPlayers.Length);
                }
            }
            else
            {
                var winnerValue = playerCubeValue.IndexOf(playerCubeValue.Max());
                int winner = roundWinner.IndexOfWinner(arrayPlayers, winnerValue);
                arrayPlayers[winner].AddChips(_roundBalance);
            }

            for (int i = 0; i <= arrayPlayers.Length - 1; i++)
            {
                arrayPlayers[i].PlayerBalance();
            }

        }

    }
}
