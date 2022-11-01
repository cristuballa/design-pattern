namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class ButtonMac : IButton
    {
        public void Create()
        {
            System.Console.WriteLine("Mac button created");
        }
    }
}