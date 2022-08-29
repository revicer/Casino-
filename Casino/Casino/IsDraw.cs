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
            int[] drawValueArray = playerCubeValue.ToArray();
            for (int i = 0; i <= drawValueArray.Length; i++)
            {
                if (drawValueArray.Max<int>() == drawValueArray[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool DrawRound1(List<int> playerCubeValue)
        {
            foreach (int i in playerCubeValue)   
            {
                int maxValue = playerCubeValue.Max();
                playerCubeValue.RemoveAt(playerCubeValue.IndexOf(playerCubeValue.Max()));
                if (maxValue == playerCubeValue[i])
                {
                    return true;

                    //if (playerCubeValue.Max() == playerCubeValue[i])
                    //{
                    //    return false;
                    //}
                }
            }
            return false;
        }
    }
}
