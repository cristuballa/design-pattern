// See https://aka.ms/new-console-template for more information




// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.

// Concrete Decorators call the wrapped object and alter its result in some
// way.
public class Client
{
    // The client code works with all objects using the Component interface.
    // This way it can stay independent of the concrete classes of
    // components it works with.
    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}
