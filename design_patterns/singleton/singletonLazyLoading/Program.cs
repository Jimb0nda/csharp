ParallelEnumerable.Range(0, 1000).ForAll(_ =>
        {
            Singleton singleton1 = Singleton.newInstance;
        });

Singleton singleton2 = Singleton.newInstance;

sealed class Singleton
{
    private static Singleton instance = default!;
    private static object _lock = new();

    //Global way for anything to access the single instance
    public static Singleton newInstance
    {
        get
        {
            //Double check locking so that only the first thread can create the instance of Singleton
            if (instance == null)
            {
                Console.WriteLine("Locking");
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    //Private constructor so that no one can just create an instance of the singleton class
    private Singleton()
    {
        Console.WriteLine("Instantiating Instance");
    }
}
