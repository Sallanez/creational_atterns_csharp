namespace creational.patterns.SingletonPattern;

public class ThreadSafeSingleton : SingletonBase
{
    private static readonly object threadSafeLock = new object();
    private static ThreadSafeSingleton _instance;
    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton GetInstance()
    {
        if (_instance == null)
        {
            lock (threadSafeLock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
            }
            _instance = new ThreadSafeSingleton();
        }
        return _instance;
    }
}
