namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class MacControlFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new ButtonMac();
        }

        public ICheckBox CreateCheckbox()
        {
            return new CheckBoxMac();
        }

        public ITextBox CreateTextBox()
        {
            return new TextBoxMac();
        }
    }
}