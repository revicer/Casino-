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
        CasinoRound casinoTableRound = new CasinoRound();
        ChipsExist ChipsExist = new ChipsExist(); //TODO: rename to PlayerBalanaceHelper

        public void StartGame(CasinoPlayer[] arrayPlayers)
        {
            UserInputHelper userInputHelper = new UserInputHelper();

            Console.WriteLine("Welcome to casino!");

            while (ChipsExist.isChipsExist(arrayPlayers))
            {
                Console.WriteLine("Enter Spacebar to start a casino entertainment!");
                ConsoleKey key = userInputHelper.GetButton();
                if (key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    casinoTableRound.StartRound(arrayPlayers);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the Spacebar!");
                }

            }

            Console.WriteLine("Game is over");
        }
    }
}
