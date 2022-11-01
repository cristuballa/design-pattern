namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class ButtonWindow : IButton
    {
        public void Create()
        {
            System.Console.WriteLine("Windows button created");
        }
    }
}