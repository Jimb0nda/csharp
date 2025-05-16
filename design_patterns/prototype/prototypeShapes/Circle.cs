public class Circle(int radius, Colour colour) : IShape
{
    public IShape Clone()
    {
        return new Circle(radius, colour.Clone());
    }
}
