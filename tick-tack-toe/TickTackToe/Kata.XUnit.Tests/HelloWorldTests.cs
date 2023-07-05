using System;
using System.Linq;
using FluentAssertions;
using Kata;
using Xunit;

namespace Kata.XUnit.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void AnEmptyBoard_HasNineEmptyPositions()
        {
            var board = new Board();

            Assert.Equal(board.positions.Length, 9);
            Assert.True(board.positions.All(x => x == " "));
        }

        [Fact]
        public void FirstPlayerMoveToZeroZero()
        {
            var board = new Board();
            board.XPlayerMakesMove(0, 0);

            Assert.Equal("X", board.positions[0]);
            Assert.All(board.positions.Skip(1), x => Assert.Equal(" ", x));
        }

        [Fact]
        public void FirstPlayerMoveToOneTwo()
        {
            var board = new Board();
            board.XPlayerMakesMove(1, 2);

            Assert.Equal(
                "   " + "\n" +
                "  X" + "\n" +
                "   ",

                board.ToString());
        }

    }

    public class Board
    {
        public string[] positions = { 
            " ", " ", " ", 
            " ", " ", " ", 
            " ", " ", " "
        };

        public void XPlayerMakesMove(int row, int column)
        {
            positions[0] = "X";
        }

        public override string ToString()
        {
            var result = positions[0] + positions[1] + positions[2] + "\n" +
                         positions[3] + positions[4] + positions[5] + "\n" +
                         positions[6] + positions[7] + positions[8];

            return result;

        }
    }
}
