namespace FactoryMethodPattern
{
    public class FactoryMethod
    {
        public BaseEmployeeFactory GetFactory(Employee employee)
        {
            BaseEmployeeFactory? factory = null;

            if (employee.EmployeeType.Equals("permanant"))
            {
                factory = new PermanantEmployeeFactory(employee);
            }

            if (employee.EmployeeType.Equals("contract"))
            {
                factory = new ContractEmployeeFactory(employee);
            }

            if (factory is null)
            {
                throw new NullReferenceException();
            }

            return factory;
        }
    }
}