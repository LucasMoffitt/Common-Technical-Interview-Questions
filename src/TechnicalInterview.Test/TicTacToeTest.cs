using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void BoardIsFullReturnsTrueWhenBoardIsFull()
        {
            var instance = new TicTacToe();
            FillBoard(instance);
            
            Assert.IsTrue(instance.BoardIsFull());
        }

        [TestMethod]
        public void WinConditionsCanBeAchievedOnHorizontals()
        {
            for (uint i = 0; i == 1; i++)
            {
                var instance = new TicTacToe();

                instance.MakeMove(i, 0, 'x');
                instance.MakeMove(i, 1, 'x');
                instance.MakeMove(i, 2, 'x');

                //Moves have been played, board should now be clear.
                for (var x = 0; x < 3; x++)
                {
                    for (var y = 0; y < 3; y++)
                    {
                        Assert.IsTrue(instance.Board[x, y] == 0);
                    }
                }
            }
        }

        [TestMethod]
        public void WinConditionCanBeAchievedOnDiagonals()
        {
            var instance = new TicTacToe();

            instance.MakeMove(0, 0, 'x');
            instance.MakeMove(1, 1, 'x');
            instance.MakeMove(2, 2, 'x');

            //Moves have been played, board should now be clear.
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    Assert.IsTrue(instance.Board[x, y] == 0);
                }
            }

            instance.MakeMove(0, 2, 'x');
            instance.MakeMove(1, 1, 'x');
            instance.MakeMove(2, 0, 'x');

            //Moves have been played, board should now be clear.
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    Assert.IsTrue(instance.Board[x, y] == 0);
                }
            }
        }

        [TestMethod]
        public void CleanBoardClearsTheGameBoard()
        {
            var instance = new TicTacToe();
            FillBoard(instance);

            instance.CleanBoard();

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    Assert.IsTrue(instance.Board[x, y] == 0);
                }
            }
        }

        [TestMethod]
        public void TryingToMoveOverAlreadySetTileThrowsInvalidOperation()
        {
            var gameInstance = new TicTacToe();

            try
            {
                gameInstance.MakeMove(1, 1, 'x');
                gameInstance.MakeMove(1, 1, 'x');
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(InvalidOperationException));
            }
        }

        [TestMethod]
        public void MakeMoveReturnsThrowsArgumentExceptionWhenOutOfXIndexRange()
        {
            var gameInstance = new TicTacToe();

            try
            {
                gameInstance.MakeMove(3, 1, 'x');
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void MakeMoveThrowsArgumentExceptionWhenOutOfYIndexRange()
        {
            var gameInstance = new TicTacToe();

            try
            {
                gameInstance.MakeMove(0, 3, 'x');
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof (ArgumentException));
            }
        }

        [TestMethod]
        public void MovingWithABadTileThrowsArgumentException()
        {
            var gameInstance = new TicTacToe();

            try
            {
                gameInstance.MakeMove(0, 0, 'a');
            }
            catch (Exception exception)
            {
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof (ArgumentException));
            }
        }

        private void FillBoard(TicTacToe instance)
        {
            instance.Board[0, 0] = 'x';
            instance.Board[0, 1] = 'o';
            instance.Board[0, 2] = 'x';

            instance.Board[1, 0] = 'o';
            instance.Board[1, 1] = 'o';
            instance.Board[1, 2] = 'x';

            instance.Board[2, 0] = 'o';
            instance.Board[2, 1] = 'x';
            instance.Board[2, 2] = 'o';
        }
        
    }
}