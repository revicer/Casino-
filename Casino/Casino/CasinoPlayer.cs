using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class CasinoPlayer
    {
        public int pokerChips = 100;
        public void RoundChips()
        {
            pokerChips -= 10;
        }
        public void LoseChips(int pokerChips=10)
        {
            this.pokerChips -= pokerChips;  
        }
        public void WinChips(int pokerChips=10)
        {
            this.pokerChips += pokerChips;
        }
        public void DrawChips(int pokerChips)
        {
            this.pokerChips = pokerChips;
        }
        public void PlayerBalance()
        {
            Console.WriteLine($"Player balance: {pokerChips}");
        }
    }
}
