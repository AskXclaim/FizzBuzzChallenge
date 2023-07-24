namespace Game;

/// <summary>
/// A FizzBuzz Game class that uses reflection to run.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="U"></typeparam>
public class ReflectionGame<T, U> where T : struct where U : IEnumerable
{
    private readonly IProcessor<T, U> _processor;
    private readonly IDisplay<U> _display;

    public ReflectionGame()
    {
        // This can be modified to allow reflection call from a different assembly.

        var processorType = typeof(FizzBuzzProcessor);
        var fizzBuzzProcessor = (FizzBuzzProcessor) Activator.CreateInstance(processorType);
        if (fizzBuzzProcessor != null)
            _processor = fizzBuzzProcessor as IProcessor<T, U>;

        var displayType = typeof(FizzBuzzDisplay);
        var fizzBuzzDisplay = (FizzBuzzDisplay) Activator.CreateInstance(displayType);
        if (fizzBuzzDisplay != null)
            _display = fizzBuzzDisplay as IDisplay<U>;
    }

    /// <summary>
    /// A method to process and display the result of the game.
    /// </summary>
    /// <param name="lowerLimit"></param>
    /// <param name="upperLimit"></param>
    public void Run(T lowerLimit, T upperLimit)
    {
        var result = _processor.Process(lowerLimit, upperLimit);
        _display.Display(result);
    }
}