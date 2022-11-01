namespace DesignPatterns.Creational.abstractfactorymethod;

    public interface IGuiFactory
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckbox();
        public ITextBox CreateTextBox();
    }
