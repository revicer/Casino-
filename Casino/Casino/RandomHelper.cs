using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class RandomHelper
    {
         public bool Roll(int rollChanse)
         {
                Random randomNumber = new Random();
                int chanceСheck = randomNumber.Next(1, 100);
                if (chanceСheck <= rollChanse)
                {
                    return true;
                }
                return false;
         }
        public int RollCube()
        {
            Random randomCube = new Random();
            int cubeValue = randomCube.Next(1, 6);
            return cubeValue;
        }
    }
}
