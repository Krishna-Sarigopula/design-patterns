public sealed class SingleTon
{
    private static int count = 0;
    private static SingleTon? instance;
    private static readonly object obj = new Object();

    public static SingleTon GetInstance
    {
        get
        {
            if (instance is null)
            {
                lock (obj)
                {
                    if (instance is null)
                    {
                        count++;
                        instance = new SingleTon();
                    }
                }
            }

            return instance;
        }
    }

    private SingleTon()
    {
        Console.WriteLine($"{count} Object created");
    }

    public void print(string msg)
    {
        Console.WriteLine(msg);

    }
}