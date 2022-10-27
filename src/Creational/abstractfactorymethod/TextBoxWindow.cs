namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class TextBoxWindow : ITextBox
    {
        public void Create()
        {
            Console.WriteLine("Windows textbox created");
        }
    }
}
