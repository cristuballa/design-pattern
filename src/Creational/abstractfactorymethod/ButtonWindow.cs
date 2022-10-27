namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class ButtonWindow : IButton
    {
        public void Create()
        {
            Console.WriteLine("Windows button created");
        }
    }
}
