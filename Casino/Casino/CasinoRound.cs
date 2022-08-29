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
        
        public void PlayerRoll(int cubesValue)
        {
            List<int> playerCubeValue = new List<int>();
            playerCubeValue.Add(cubesValue);

        }
        public void Round(CasinoPlayer[] arrayPlayers)
        {
            _roundBalance = 0;
            _roundAmount = 10;

            arrayPlayers[0].RemoveChips(_roundAmount);
            arrayPlayers[1].RemoveChips(_roundAmount);
            
            _roundBalance += _roundAmount*arrayPlayers.Length;

            for (int i = 0; i <= arrayPlayers.Length-1; i++)
            {
                int cubesValue = firstPlayerCube.Roll() + secondPlayerCube.Roll();
                PlayerRoll(cubesValue);
                Console.WriteLine(cubesValue);
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
