using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ChessGameboard : Gameboard
    {
        public override string placeBoard()
        {
            return "Chess board is placed!";
        }
    }
}
