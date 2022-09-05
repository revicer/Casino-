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
        private CasinoRound _casinoRoundTurn = new CasinoRound();
        private PlayerCount _count = new PlayerCount();
        private List<CasinoPlayer> _arrayPlayers = new List<CasinoPlayer>();

        public void Awake()
        {
            _arrayPlayers.Add(PlayerFactory.Create());
            _arrayPlayers.Add(PlayerFactory.Create());
        }

        public void StartGame()
        {
            UserInputHelper userInputHelper = new UserInputHelper();

            Console.WriteLine("Welcome to casino!");

            while (_arrayPlayers.Count!=1)
            {
                _count.PlayerDeleteZeroChips(_arrayPlayers);
                _count.PlayerPerRound(_arrayPlayers);
                Console.WriteLine("Enter Spacebar to start a casino entertainment!");
                ConsoleKey key = userInputHelper.GetButton();
                if (key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    _casinoRoundTurn.StartRound(_arrayPlayers);
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
