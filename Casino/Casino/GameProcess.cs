using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Casino
{
    internal class GameProcess
    {
        CasinoPlayer firstPlayer = new CasinoPlayer();
        CasinoPlayer secondPlayer = new CasinoPlayer();
        CasinoRound casino = new CasinoRound(); 

        public void StartGame(CasinoPlayer firstPlayer, CasinoPlayer secondPlayer)
        {
            UserInputHelper userInputHelper = new UserInputHelper();
            ConsoleKey key = userInputHelper.GetButton();

            Console.WriteLine("Enter Spacebar to start a casino entertainment!");
            while (firstPlayer.pokerChips>=0)
            {
                if (key == ConsoleKey.Spacebar)
                {
                    casino.Round(firstPlayer, secondPlayer);
                }

            }


        }
    }
}
