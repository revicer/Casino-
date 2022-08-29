using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class RollCube
    {
        public int Roll()
        {
            Random randomCube = new Random();
            int cubeValue = randomCube.Next(1,6);
            return cubeValue;   
        }
    }
}
