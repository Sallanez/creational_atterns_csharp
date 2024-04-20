namespace creational.patterns.SingletonPattern;

public class LazySingletonLogger : SingletonBase
{
    private static readonly Lazy<LazySingletonLogger> _instance = new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());
    private LazySingletonLogger() { }
    public static LazySingletonLogger GetInstance()
    {
        return _instance.Value;
    }
}
