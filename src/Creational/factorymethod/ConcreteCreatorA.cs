public class ConcreteCreatorA : Creator
{
    public override IProduct CreateProduct()
    {
        return new ProductA();
    }
}