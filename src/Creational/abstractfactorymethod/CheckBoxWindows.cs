namespace DesignPatterns.Creational.abstractfactorymethod;
public class ProductA : ICheckBox
{
    public void Create()
    {
        Console.WriteLine("CheckBox created.");
    }
}