using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ChessFactory : ToyFactory
    {
        public override Figurine createFigurine()
        {
            return new ChessFigurine();
        }

        public override Gameboard createGameboard()
        {
            return new ChessGameboard();
        }
    }
}
