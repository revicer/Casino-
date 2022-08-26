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

            Console.WriteLine("Welcome to casino!");


            while (firstPlayer.pokerChips>=0 || secondPlayer.pokerChips >= 0)
            {
                Console.WriteLine("Enter Spacebar to start a casino entertainment!");
                ConsoleKey key = userInputHelper.GetButton();
                if (key == ConsoleKey.Spacebar)
                {
                    casino.Round(firstPlayer, secondPlayer);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the Spacebar!");
                }

            }


        }
    }
}
