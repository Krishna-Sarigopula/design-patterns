public class EagerLoadingSingleTonClass
{
    private static int count = 0;
    private static readonly EagerLoadingSingleTonClass instance = new EagerLoadingSingleTonClass();
    public static EagerLoadingSingleTonClass GetInstance
    {
        get
        {
            return instance;
        }
    }

    private EagerLoadingSingleTonClass()
    {
        count++;
        Console.WriteLine($"{count} Object created");
    }

    public void print(string msg)
    {
        Console.WriteLine(msg);
    }
}