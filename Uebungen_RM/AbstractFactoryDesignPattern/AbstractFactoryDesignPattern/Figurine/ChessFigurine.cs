using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ChessFigurine : Figurine
    {
        public override string makeMove()
        {
            return "ChessFigurine made a move!";
        }
    }
}
