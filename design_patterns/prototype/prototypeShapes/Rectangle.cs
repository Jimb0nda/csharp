public class Rectangle(int width, int height, Colour colour) : IShape
{
    public IShape Clone()
    {
        return new Rectangle(width, height, colour.Clone());
    }
}

