internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var concreteCreator = new ConcreteCreatorA();
        var productA=  concreteCreator.CreateProduct();

        productA.DoStuff();
    }
}