namespace DesignPatterns.Creational.abstractfactorymethod;
public class ConcreteProductCreator1 : AbstractCreator
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