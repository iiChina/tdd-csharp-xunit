using MyProject;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example1
    {
        ITestOutputHelper _output;
        public Example1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldReturnTrueWhenUserForAdult()
        {   
            var user = new User("José", 50);
            //Arrange
            var expected = true;
            //Act
            var result = user.ForAdult();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnTrueWhenUserIsMinor()
        {   
            //Arrange
            var user = new User("José", 13);
            var expected = false;
            //Act
            var result = user.ForAdult();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        [Trait("Category", "Sums")]
        public void SumFivePlusTwoIsEqualSeven()
        {
            /*Arrange*/
            var first = 5;
            var second = 2;
            var expected = 7;
            /*Act*/
            var result = first + second;
            /*Assert*/
            _output.WriteLine($"SumFivePluTwoIsEqualSeven: {first} + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Theories")]
        [Trait("Category", "Sums")]
        [InlineData(1, 1, 2)]
        [InlineData(14, 78, 92)]
        [InlineData(30, 45, 75)]
        [InlineData(7, 12, 19)]
        public void SumFirstPlusSecondIsEqualThird(int first, int second, int expected)
        {
            //Arrange
            //Act
            var result = first + second;
            //Assert
            _output.WriteLine($"SumFirstPlusSecondEqualThird: {first}  + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "DivisionByZero not implement", Skip = "Not implemented")]
        public void DivisionByZero()
        {
            //TODO: Needs to do implemented
            //HACK:
            //UNDONE:
        }
    }
}