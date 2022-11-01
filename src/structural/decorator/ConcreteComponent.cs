// See https://aka.ms/new-console-template for more information




// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
// Concrete Components provide default implementations of the operations.
// There might be several variations of these classes.
class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}
