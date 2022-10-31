// See https://aka.ms/new-console-template for more information




// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
// Concrete Decorators call the wrapped object and alter its result in some
// way.
class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp) : base(comp)
    {
    }

    // Decorators may call parent implementation of the operation, instead
    // of calling the wrapped object directly. This approach simplifies
    // extension of decorator classes.
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}