namespace Game.Instances;

/// <summary>
/// A class to use to workout the conventional FizzBuzz game result.
/// </summary>
public class FizzBuzzProcessor : IProcessor<ulong, IEnumerable<string>>
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";


    /// <summary>
    ///  A method for working out the result of the conventional FizzBuzz game.
    /// </summary>
    /// <param name="lowerLimit"></param>
    /// <param name="upperLimit"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public IEnumerable<string> Process(ulong lowerLimit, ulong upperLimit)
    {
        if (lowerLimit <= 0 || upperLimit <= 0)
            throw new ArgumentException($"Invalid argument(s)." +
                                        $"{nameof(lowerLimit)} and/or {nameof(upperLimit)} must be greater than zero");

        var result = new List<string>();
        for (var i = lowerLimit; i <= upperLimit; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add($"{Fizz}{Buzz.ToLower()}");
                continue;
            }

            if (i % 3 == 0)
            {
                result.Add(Fizz);
                continue;
            }

            if (i % 5 == 0)
            {
                result.Add(Buzz);
                continue;
            }

            result.Add($"{i}");
        }

        return result;
    }
}