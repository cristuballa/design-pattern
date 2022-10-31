// See https://aka.ms/new-console-template for more information


// The client code should be able to work with any pre-configured
// abstraction-implementation combination.


class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform B.\n";
    }
}
