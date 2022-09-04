
public class DellFactory : IComputerFactory
{
    public IBrand GetBrand()
    {
        return new DELL();
    }
    public IProcessor GetProcessor()
    {
        return new I5();
    }
    public virtual ISystemType GetSystemType()
    {
        return new Desktop();
    }
}

public class DellLaptopFactory : DellFactory
{
    public override ISystemType GetSystemType()
    {
        return new Laptop();
    }
}