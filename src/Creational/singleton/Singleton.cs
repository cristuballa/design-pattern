public class Singleton
{
    private Singleton instance=default!;
    public Singleton GetInstance()
    {
        return new Singleton();
    }
}