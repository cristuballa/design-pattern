namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class TextBoxMac : ITextBox
    {
        public void Create()
        {
            Console.WriteLine("Mac textbox created");
        }
    }
}
