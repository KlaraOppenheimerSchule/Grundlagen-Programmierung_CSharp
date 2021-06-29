using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    abstract class ToyFactory
    {
        public abstract Gameboard createGameboard();

        public abstract Figurine createFigurine();
    }
}
