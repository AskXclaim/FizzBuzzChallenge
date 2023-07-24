namespace Game.Instances;

/// <summary>
/// A class to use to display content to the console window.
/// </summary>
public class FizzBuzzDisplay : IDisplay<IEnumerable<string>>
{
    /// <summary>
    ///  A method for writing out the content of the passed in <c>IEnumerable<string></c>
    /// to the console window.
    /// </summary>
    /// <param name="value"></param>
    public void Display(IEnumerable<string> value)
    {
        foreach (var item in value)
            Console.WriteLine(item);
    }
}