using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoPlayer
    {
        private int BalanceChips = 100;

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
    }
}
