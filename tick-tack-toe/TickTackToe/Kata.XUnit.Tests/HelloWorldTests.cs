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
            Assert.True(board.positions.All(x => x == null));
        }
    }

    public class Board
    {
        public string[] positions = new string[9];


    }
}
