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
        PlayerHelper playerHelper = new PlayerHelper();
        private string _playerName;
        public int GetBalance()
        {
            return _balanceChips;
        }
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
            Console.WriteLine($"{_playerName} balance: {_balanceChips}");
        }
        public bool ChipsNotZero()
        {
            if (_balanceChips<=0)
            {
                return false;
            }
            return true;    
        }
    }
}
