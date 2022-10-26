namespace DesignPatterns.Creational.abstractfactorymethod
{
    public interface ICreator
    {
        public IProductA CreateProductA();
        public IProductB CreateProductB();
    }
}
