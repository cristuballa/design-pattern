public class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
          return new ProductB();
    }
}