public sealed class Singleton
{
    private static Singleton instance=default!;
    public static Singleton GetInstance()
    {
        return instance ??= new Singleton();
    }
}