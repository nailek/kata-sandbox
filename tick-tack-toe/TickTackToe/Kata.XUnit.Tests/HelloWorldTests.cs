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
            Assert.Equals(board.positions, 9);
            Assert.True(board.positions.All(x => x == null)));
        }
    }
}
