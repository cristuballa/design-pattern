namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class ButtonMac : IButton
    {
        public void Create()
        {
            Console.WriteLine("Mac button created");
        }
    }
}
