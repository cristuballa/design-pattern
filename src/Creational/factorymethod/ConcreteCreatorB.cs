namespace DesignPatterns.Creational.factorymethod;

public class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ProductB();
    }
}