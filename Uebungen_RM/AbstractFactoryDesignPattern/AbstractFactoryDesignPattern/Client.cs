using System;

namespace AbstractFactoryDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            //Creating the Abstract Factories
            var chessFactory = new ChessFactory();
            var millFactory = new MillFactory();


            var chessBoard = chessFactory.createGameboard();
            Console.WriteLine(chessBoard.placeBoard());

            var chessFigurine = chessFactory.createFigurine();
            Console.WriteLine(chessFigurine.makeMove());

            Console.WriteLine("-----------------------------");

            var millBoard = millFactory.createGameboard();
            Console.WriteLine(millBoard.placeBoard());

            var millFigurine = millFactory.createFigurine();
            Console.WriteLine(millFigurine.makeMove());
        }
    }
}
