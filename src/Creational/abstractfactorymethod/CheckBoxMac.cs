namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class CheckBox : ICheckBox
    {
        public void Create()
        {
            Console.WriteLine("Windows checkbox created");
        }
    }

    public class Button : IButton
    {
        public void Create()
        {
            Console.WriteLine("Windows button created");
        }
    }

    public class TextBox : ITextBox
    {
        public void Create()
        {
            Console.WriteLine("Windows button created");
        }
    }
}
