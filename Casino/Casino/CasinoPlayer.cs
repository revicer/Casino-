using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoPlayer
    {
        private int BalanceChips = 20;
        public int GetBalance()
        {
            return BalanceChips;
        }
        public void RemoveChips(int roundChips)
        {
            this.BalanceChips -= roundChips; 
        }
        public void AddChips(int roundChips)
        {
            this.BalanceChips += roundChips;
        }
        public void PlayerBalance()
        {
            Console.WriteLine($"Player balance: {BalanceChips}");
        }
        public bool ChipsNotNull()
        {
            if (BalanceChips<=0)
            {
                return false;
            }
            return true;    
        }
    }
}
