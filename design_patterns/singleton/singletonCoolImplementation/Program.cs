var singleton1 = Singleton.className;
var singleton2 = Singleton.instance;

Console.WriteLine(singleton1);
Console.WriteLine(singleton2);


/*
 * Using a static constructor takes out an underlying flag that allows properties in a class 
 * to be used before first initialisation. Using the Nested class, allows the delaying of the instance
 * initialisation until directly called for. Without this, calling className would then instantiate
 * the singleton instance.
 * */


sealed class Singleton
{
    public static string className;
    public static Singleton instance => Nested.instance;

    private class Nested
    {
        public static Singleton instance { get; } = new();
        static Nested()
        {

        }
    }

    private Singleton()
    {
    }

    static Singleton()
    {
        className = "Singleton";
    }
}
