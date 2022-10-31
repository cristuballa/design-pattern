// See https://aka.ms/new-console-template for more information
class Abstraction
{
    protected IImplementation _implementation;
    public Abstraction(IImplementation implementation)
    {
        this._implementation = implementation;
    }
    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" +
            _implementation.OperationImplementation();
    }
}
