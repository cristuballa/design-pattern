namespace DesignPatterns.Creational.abstractfactorymethod
{
    public class CheckBoxMac : ICheckBox
    {
        public void Create()
        {
            Console.WriteLine("Mac checkbox created");
        }
    }
}
