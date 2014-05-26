using System;

namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * Implement a basic game of Tic Tac Toe.
     * Store game data in a multidimensional array
     * Ensure you can test for Win or Draw
     */

    public class TicTacToe
    {
        public char[,] Board { get; set; }

        public TicTacToe()
        {
            Board = new char[3, 3];
        }

        public void MakeMove(uint x, uint y, char tile)
        {
            if (x > 2 || y > 2)
                throw new ArgumentException("Input x and y must be =< 2");

            if (tile != 'x' && tile != 'o')
                throw new ArgumentException("You need to use the character 'x' or 'o' as a tile");

            if (Board[x, y] != 0)
                throw new InvalidOperationException("You can't  place over an already set position");

            Board[x, y] = tile;

            char winner;
            if (HasWinner(out winner))
            {
                Console.WriteLine("{0} is the Winner", winner);
                CleanBoard();
                return;
            }

            if (BoardIsFull())
            {
                Console.WriteLine("Draw");
                CleanBoard();
            }
        }

        public void CleanBoard()
        {
            Board = new char[3, 3];
        }

        public bool HasWinner(out char winner)
        {
            //Top to Bottom, Left To Right
            for (var i = 0; i < 3; i++)
            {
                if (Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2])
                {
                    if (Board[1, i] == 0)
                        continue;
                    
                    winner = Board[i, 1];
                    return true;
                }

                if (Board[0, i] == Board[1, i] && Board[1, i] == Board[2, i])
                {
                    if (Board[1, i] == 0)
                        continue;

                    winner = Board[1, i];
                    return true;
                }
            }

            //Diagonal
            if (Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2])
            {
                if (Board[0, 0] != 0)
                {
                    winner = Board[0, 0];
                    return true;
                }
            }

            if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0])
            {
                if (Board[0, 2] != 0)
                {
                    winner = Board[0, 2];
                    return true;
                }
            }

            winner = ' ';
            return false;
        }

        public bool BoardIsFull()
        {
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    if (Board[x, y] == 0)
                        return false;
                }
            }
            return true;
        }
    }
}