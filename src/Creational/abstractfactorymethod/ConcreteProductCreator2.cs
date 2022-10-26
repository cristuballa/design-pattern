namespace DesignPatterns.Creational.abstractfactorymethod;
public class ConcreteProductCreator2 : ICreator
{
    public override IProductA CreateProductA()
    {
        return new ProductA();
    }

    public override IProductB CreateProductB()
    {
        return new ProductB();
    }
}