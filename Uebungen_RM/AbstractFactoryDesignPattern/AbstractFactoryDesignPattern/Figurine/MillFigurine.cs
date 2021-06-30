using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class MillFigurine : Figurine
    {
        public override string makeMove()
        {
            return "MillFigurine made a move!";
        }
    }
}
