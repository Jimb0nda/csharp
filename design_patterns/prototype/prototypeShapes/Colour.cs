public class Colour(ushort red, ushort green, ushort blue) : IPrototype<Colour>
{
    public static readonly Colour LightGrey = new (217, 217, 217);

    public Colour Clone()
    {
        return new Colour(red, green, blue);
    }
}
