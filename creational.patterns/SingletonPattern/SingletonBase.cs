namespace creational.patterns.SingletonPattern;

public abstract class SingletonBase
{
    public void Log(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
