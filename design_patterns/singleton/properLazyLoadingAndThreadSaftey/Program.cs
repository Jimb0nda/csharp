ParallelEnumerable.Range(0, 1000).ForAll(_ =>
        {
            Singleton singleton1 = Singleton.newInstance;
        });

Singleton singleton2 = Singleton.newInstance;

sealed class Singleton
{
    //Lazy is the built in functionality of locking and letting the first thread to create the instance
    private static readonly Lazy<Singleton> lazyInstance = new(() => new Singleton());

    //Global way for anything to access the single instance
    public static Singleton newInstance => lazyInstance.Value;

    //Private constructor so that no one can just create an instance of the singleton class
    private Singleton()
    {
        Console.WriteLine("Instantiating Instance");
    }
}
