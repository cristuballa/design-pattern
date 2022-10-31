// See https://aka.ms/new-console-template for more information




// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.

// Concrete Decorators call the wrapped object and alter its result in some
// way.
// Decorators can execute their behavior either before or after the call to
// a wrapped object.
class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}
