using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoRound
    {
        CasinoPlayer firstPlayer = new CasinoPlayer();
        CasinoPlayer secondPlayer = new CasinoPlayer();
        RollCube firstPlayerCube = new RollCube();
        RollCube secondPlayerCube = new RollCube();

        public void Round(CasinoPlayer firstPlayer, CasinoPlayer secondPlayer)
        {
            firstPlayer.PlayerBalance();
            secondPlayer.PlayerBalance();
            firstPlayer.RoundChips();
            secondPlayer.RoundChips();
            firstPlayer.PlayerBalance();
            secondPlayer.PlayerBalance();
            if (firstPlayerCube.Roll() == secondPlayerCube.Roll())
            {
                firstPlayer.DrawChips(secondPlayer.pokerChips);
                Console.WriteLine("Draw!");
                firstPlayer.PlayerBalance();
                secondPlayer.PlayerBalance();

                return;
            }
            else if (firstPlayerCube.Roll() >= secondPlayerCube.Roll())
            {
                firstPlayer.WinChips(secondPlayer.pokerChips);
                Console.WriteLine("Win!");
                firstPlayer.PlayerBalance();
                secondPlayer.PlayerBalance();

                return;
            }
            else if (firstPlayerCube.Roll() <= secondPlayerCube.Roll())
            {
                firstPlayer.LoseChips(secondPlayer.pokerChips);
                Console.WriteLine("Lose!");
                firstPlayer.PlayerBalance();
                secondPlayer.PlayerBalance();

                return;
            }


        }


    }
}
