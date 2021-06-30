using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class MillGameboard : Gameboard
    {
        public override string placeBoard()
        {
            return "Mill board is placed!";
        }
    }
}
