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
            Balance();
            firstPlayer.RoundChips();
            secondPlayer.RoundChips();
            Balance();
            if (firstPlayerCube.Roll() == secondPlayerCube.Roll())
            {
                firstPlayer.DrawChips(secondPlayer.pokerChips);
                Balance();
                return;
            }
            else if (firstPlayerCube.Roll() >= secondPlayerCube.Roll())
            {
                firstPlayer.WinChips(secondPlayer.pokerChips);
                Balance();
                return;
            }
            else if (firstPlayerCube.Roll() <= secondPlayerCube.Roll())
            {
                firstPlayer.LoseChips(secondPlayer.pokerChips);
                Balance();
                return;
            }


        }
        private void Balance()
        {
            Console.WriteLine($"First player balance: {firstPlayer.pokerChips}");
            Console.WriteLine($"Second player balance: {secondPlayer.pokerChips}");
        }

    }
}
