using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class IsDraw
    {
        public static bool DrawRound(List<int> playerCubeValue)
        {
            if (playerCubeValue[0] == playerCubeValue[1])
            {
                return true;
            }
            return false;
        }
    }
}
