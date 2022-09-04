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
        private ChipsExist _playerBalanaceHelper = new ChipsExist();
        private PlayerCount _count = new PlayerCount();
        List<CasinoPlayer> arrayPlayers = new List<CasinoPlayer>(7);

        public void Awake()
        {
            arrayPlayers.Add(PlayerFactory.Create());
            arrayPlayers.Add(PlayerFactory.Create());
        }
        public void StartGame()
        {
            UserInputHelper userInputHelper = new UserInputHelper();

            Console.WriteLine("Welcome to casino!");

            while (_playerBalanaceHelper.isChipsExist(arrayPlayers))
            {
                _count.PlayerDeleteZeroChips(arrayPlayers);
                _count.PlayerPerRound(arrayPlayers);
                Console.WriteLine("Enter Spacebar to start a casino entertainment!");
                ConsoleKey key = userInputHelper.GetButton();
                if (key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    _casinoRoundTurn.StartRound(arrayPlayers);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the Spacebar!");
                }

            }

            Console.WriteLine("Game is over");
        }
        private void SetUp()
        {

        }
    }
}
