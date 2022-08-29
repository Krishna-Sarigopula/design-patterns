public class LazyLoadingSingleTonClass
{
    private static int count = 0;
    private static readonly Lazy<LazyLoadingSingleTonClass> instance = new Lazy<LazyLoadingSingleTonClass>(
        () => new LazyLoadingSingleTonClass());
    public static LazyLoadingSingleTonClass GetInstance
    {
        get
        {
            return instance.Value;
        }
    }

    private LazyLoadingSingleTonClass()
    {
        count++;
        Console.WriteLine($"{count} Object created");
    }

    public void print(string msg)
    {
        Console.WriteLine(msg);
    }
}