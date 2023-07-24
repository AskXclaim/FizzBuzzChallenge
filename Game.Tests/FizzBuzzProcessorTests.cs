namespace FizzBuzzChallenge.Tests;

public class FizzBuzzProcessorTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [InlineData(0, 0)]
    public void Process_WhenCalledWithInValidValues_ThrowsArgumentException(ulong lowerLimit, ulong upperLimit)
    {
        var sut = new FizzBuzzProcessor();

        Assert.Throws<ArgumentException>(() => sut.Process(lowerLimit, upperLimit));
    }

    [Theory]
    [InlineData(1, 100)]
    public void Process_WhenCalledWithValidValues_ReturnsExpectedResult(ulong lowerLimit, ulong upperLimit)
    {
        var sut = new FizzBuzzProcessor();

        var result = sut.Process(lowerLimit, upperLimit).ToList();
        
        result.Should().BeAssignableTo<IEnumerable<string>>();
        result.Count(r => r == "Fizz").Should().Be(27);
        result.Count(r => r == "Buzz").Should().Be(14);
        result.Count(r => r == "Fizzbuzz").Should().Be(6);
    }
}