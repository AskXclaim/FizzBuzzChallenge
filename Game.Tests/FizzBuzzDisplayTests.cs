namespace FizzBuzzChallenge.Tests;

public class FizzBuzzDisplayTests
{
    [Fact]
    public void Display_WhenCalledWithNoneEmptyResult_ExpectedContentIsDisplayedInOutput()
    {
        var stringWriter = GetConsoleStringWriter();
        var sut = new FizzBuzzDisplay();

        sut.Display(Data.Data.GetResult());

        stringWriter.ToString().Should().Be("1\n2\nFizz\n");
    }

    [Fact]
    public void Display_WhenCalledWithEmptyResult_ExpectedContentIsDisplayedInOutput()
    {
        var stringWriter = GetConsoleStringWriter();
        var sut = new FizzBuzzDisplay();

        sut.Display(new List<string>());

        stringWriter.ToString().Should().Be("");
    }

    private StringWriter GetConsoleStringWriter()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        return stringWriter;
    }
}