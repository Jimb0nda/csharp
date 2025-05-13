Singleton singleton1 = Singleton.instance;
Singleton singleton2 = Singleton.instance;

sealed class Singleton
{
    public static Singleton instance {get;} = new();

    private Singleton()
    {
    }
}
