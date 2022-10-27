namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class CheckBoxWindow : ICheckBox
    {
        public void Create()
        {
            Console.WriteLine("Windows checkbox created");
        }
    }
}
