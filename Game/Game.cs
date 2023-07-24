namespace Game;

/// <summary>
/// A Game Class that can be used to run different variations of the FizzBuzz game. 
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="U"></typeparam>
public class Game<T, U> where T : struct where U : IEnumerable
{
    private readonly IProcessor<T, U> _processor;
    private readonly IDisplay<U> _display;

    public Game(IProcessor<T, U> processor, IDisplay<U> display)
    {
        _processor = processor;
        _display = display;
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