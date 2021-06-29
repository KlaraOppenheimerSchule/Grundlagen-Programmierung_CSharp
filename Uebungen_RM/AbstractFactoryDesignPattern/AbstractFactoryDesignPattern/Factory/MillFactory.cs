using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class MillFactory : ToyFactory
    {
        public override Figurine createFigurine()
        {
            return new MillFigurine();
        }

        public override Gameboard createGameboard()
        {
            return new MillGameboard();
        }
    }
}
