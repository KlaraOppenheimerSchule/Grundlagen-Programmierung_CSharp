using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    abstract class Gameboard
    {
        int size;
        string color;

        abstract public string placeBoard();
    }
}
