// See https://aka.ms/new-console-template for more information
namespace DesignPatterns.Creational.abstractfactorymethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Method");
            IGuiFactory winControl=new WindowsControlFactory();
            IGuiFactory macControl=new MacControlFactory();
            
            IButton winButton=winControl.CreateButton();
            winButton.Create();

            ICheckBox winCheckBox=winControl.CreateCheckbox();
            winCheckBox.Create();

            ITextBox winTextBox=winControl.CreateTextBox();
            winTextBox.Create();

            IButton macButton=macControl.CreateButton();
            macButton.Create();

            ICheckBox macCheckBox=macControl.CreateCheckbox();
            macCheckBox.Create();

            ITextBox macTextBox=macControl.CreateTextBox();
            macTextBox.Create();

        }
    }
}
