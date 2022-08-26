using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class UserInputHelper
    {
        public ConsoleKey GetButton()
        {
            var button = Console.ReadKey().Key;
            return button;
        }
    }
}
