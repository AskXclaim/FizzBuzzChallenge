namespace Game.Interfaces;

public interface IDisplay<T> where T :  IEnumerable
{   
    void Display(T value);
}