using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoRound
    {
        RollCube firstPlayerCube = new RollCube();
        RollCube secondPlayerCube = new RollCube();
        private int _roundBalance;
        private int _roundAmount;
        
        private void PlayerRoll(int cubesValue)
        {
            List<int> playerCubeValue = new List<int>();
            playerCubeValue.Add(cubesValue);

        }

        private void RoundPlayers(CasinoPlayer firstPlayer, CasinoPlayer secondPlayer)
        {
            CasinoPlayer[] players = new CasinoPlayer[] {firstPlayer, secondPlayer};

        }

        public void Round(CasinoPlayer[] players)
        {
            _roundBalance = 0;
            _roundAmount = 10;
            players.firstPlayer.PlayerBalance();
            secondPlayer.PlayerBalance();
            firstPlayer.RemoveChips(_roundAmount);
            secondPlayer.RemoveChips(_roundAmount);

            _roundBalance += _roundAmount* players.Length;

            for (int i = 0; i <= players.Length; i++)
            {
                int cubesValue = firstPlayerCube.Roll() + secondPlayerCube.Roll();
                PlayerRoll(cubesValue);
            }







            //if (firstPlayerCube.Roll() == secondPlayerCube.Roll())
            //{
            //    firstPlayer.DrawChips(secondPlayer.pokerChips);
            //    Console.WriteLine("Draw!");
            //    firstPlayer.PlayerBalance();
            //    secondPlayer.PlayerBalance();

            //    return;
            //}
            //else if (firstPlayerCube.Roll() >= secondPlayerCube.Roll())
            //{
            //    firstPlayer.WinChips(secondPlayer.pokerChips);
            //    Console.WriteLine("Win!");
            //    firstPlayer.PlayerBalance();
            //    secondPlayer.PlayerBalance();

            //    return;
            //}
            //else if (firstPlayerCube.Roll() <= secondPlayerCube.Roll())
            //{
            //    firstPlayer.LoseChips(secondPlayer.pokerChips);
            //    Console.WriteLine("Lose!");
            //    firstPlayer.PlayerBalance();
            //    secondPlayer.PlayerBalance();

            //    return;
            //}


        }


    }
}
