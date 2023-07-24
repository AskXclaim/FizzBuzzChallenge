namespace Game.Interfaces;

public interface IProcessor<T, U> where T:struct where U:IEnumerable
{
    U Process( T lowerLimit, T upperLim);
}