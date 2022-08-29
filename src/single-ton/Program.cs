public class Program
{
    static void Main(string[] args)
    {
        Parallel.Invoke(
            () => firstObjectMethod(),
            () => secondObjectMethod()
        );

        Parallel.Invoke(
            () => firstLazyObjectMethod(),
            () => secondLazyObjectMethod()
        );

        Parallel.Invoke(
            () => firstEagerObjectMethod(),
            () => secondEagerObjectMethod()
        );

        Console.ReadKey();
    }

    static void firstObjectMethod()
    {
        SingleTon first = SingleTon.GetInstance;
        first.print("I am first object");
    }

    static void secondObjectMethod()
    {
        SingleTon second = SingleTon.GetInstance;
        second.print("I am second object");
    }

    static void firstLazyObjectMethod()
    {
        var first = LazyLoadingSingleTonClass.GetInstance;
        first.print("I am first lazy object");
    }

    static void secondLazyObjectMethod()
    {
        var second = LazyLoadingSingleTonClass.GetInstance;
        second.print("I am second eager object");
    }

    static void firstEagerObjectMethod()
    {
        var first = EagerLoadingSingleTonClass.GetInstance;
        first.print("I am first eager object");
    }

    static void secondEagerObjectMethod()
    {
        var second = EagerLoadingSingleTonClass.GetInstance;
        second.print("I am second lazy object");
    }
}

