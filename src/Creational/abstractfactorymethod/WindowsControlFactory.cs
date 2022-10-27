namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class WindowsControlFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new ButtonWindow();
        }

        public ICheckBox CreateCheckbox()
        {
            return new CheckBoxWindow();
        }

        public ITextBox CreateTextBox()
        {
            return new TextBoxWindow();
        }
    }
}