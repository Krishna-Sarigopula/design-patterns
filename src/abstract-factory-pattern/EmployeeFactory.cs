namespace AbstractFactoryPattern
{
    public class EmployeeFactory
    {
        public static IEmployee GetEmployee(string type)
        {
            IEmployee? employee = null;

            if (type.Equals("permanant"))
            {
                employee = new PermanantEmployee();
            }

            if (type.Equals("contract"))
            {
                employee = new ContractEmployee();
            }

            if (employee is null)
            {
                throw new NullReferenceException();
            }

            return employee;
        }
    }
}