namespace FizzBuzzChallenge.Tests;

public class GameTests
{
    [Fact]
    public void Run_WhenCalledWithValidValues_DoesNotThrowAnException()
    {
        var processor = GetMockProcessor();
        var display = GetMockDisplay();

        var sut = new Game<ulong, IEnumerable<string>>(processor.Object, display.Object);

        var exception = Record.Exception(() => sut.Run(1, 3));

        processor.Verify(p =>
            p.Process(It.IsAny<ulong>(), It.IsAny<ulong>()), Times.Once);
        display.Verify(d =>
            d.Display(It.IsAny<IEnumerable<string>>()), Times.Once);
        exception.Should().BeNull();
    }

    private Mock<IProcessor<ulong, IEnumerable<string>>> GetMockProcessor()
    {
        var processor = new Mock<IProcessor<ulong, IEnumerable<string>>>();
        processor.Setup(p =>
                p.Process(It.IsAny<ulong>(), It.IsAny<ulong>()))
            .Returns(Data.Data.GetResult);
        return processor;
    }

    private Mock<IDisplay<IEnumerable<string>>> GetMockDisplay()
    {
        var display = new Mock<IDisplay<IEnumerable<string>>>();
        display.Setup(d =>
            d.Display(It.IsAny<IEnumerable<string>>()));
        return display;
    }
}