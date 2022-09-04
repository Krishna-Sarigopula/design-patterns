using AbstractFactoryPattern;

public class EmployeeSystemManager
{
    private readonly IComputerFactory _computerFactory;
    public EmployeeSystemManager(IComputerFactory computerFactory)
    {
        _computerFactory = computerFactory;
    }

    public string GetSystemDetails()
    {
        return string.Format(" {0} {1} {2}",
        _computerFactory.GetBrand().GetBrand(),
        _computerFactory.GetProcessor().GetProcessor(),
        _computerFactory.GetSystemType().GetSystemType());
    }
}
