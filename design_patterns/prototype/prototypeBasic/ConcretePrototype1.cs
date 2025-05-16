public class ConcretePrototype1 : IPrototype, IConcretePrototype1
{
    public IPrototype Clone()
    {
        return new ConcretePrototype1();
    }
}
