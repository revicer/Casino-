using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoPlayer
    {
        private int _balanceChips = 100;
        public string playerName;
        CasinoRound casinoRound = new CasinoRound();

        public void RemoveChips(int roundChips)
        {
            _balanceChips -= roundChips; 
        }
        public void AddChips(int roundChips)
        {
            _balanceChips += roundChips;
        }
        public void PlayerBalance()
        {
            Console.WriteLine($"{playerName} balance: {_balanceChips}");
        }
        public bool ChipsNotZero()
        {
            if (_balanceChips<casinoRound.GetBetValue())
            {
                return false;
            }
            return true;    
        }
    }
}
