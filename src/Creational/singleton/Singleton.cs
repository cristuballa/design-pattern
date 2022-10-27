public sealed class Singleton
{
    private static Singleton instance=default!;
    public static Singleton GetInstance()
    {
        if(instance is null)
            instance= new Singleton();

        return instance;

    }
}