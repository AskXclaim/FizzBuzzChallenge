namespace FizzBuzzChallenge.Tests;

public class ReflectionGameTests
{
    [Fact]
    public void Run_WhenCalledWithValidValues_DoesNotThrowAnException()
    {
        var sut = new ReflectionGame<ulong, IEnumerable<string>>();

        var exception = Record.Exception(() => sut.Run(1, 3));

        exception.Should().BeNull();
    }
}