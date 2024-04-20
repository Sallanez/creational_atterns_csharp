namespace creational.patterns.SingletonPattern;

public class StaticSingletonLogger : SingletonBase
{
    private static readonly StaticSingletonLogger _instance = new();
    private StaticSingletonLogger() { }
    public static StaticSingletonLogger GetInstance()
    {
        return _instance;
    }
}
