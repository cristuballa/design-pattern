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

            // ICheckBox winCheckBox=winControl.CreateCheckBox();
            // winCheckBox.Create();

            ITextBox winTextBox=winControl.CreateTextBox();
            winTextBox.Create();

            IButton macButton=macControl.CreateButton();
            winButton.Create();

            // ICheckBox macCheckBox=macControl.CreateCheckBox();
            // winCheckBox.Create();

            ITextBox macTextBox=macControl.CreateTextBox();
            winTextBox.Create();

        }
    }
}
