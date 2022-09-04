using AbstractFactoryPattern;
public class EmployeeSystemFactory
{
    public IComputerFactory Create(Employee employee)
    {
        if (employee.EmployeeType == "permanant")
        {
            if (employee.Role == "Manager")
            {
                return new MACLaptopFactory();
            }

            return new MACFactory();
        }
        else
        {
            if (employee.Role == "Manager")
            {
                return new DellLaptopFactory();
            }

            return new DellFactory();
        }
    }
}