namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("permanant");

            BaseEmployeeFactory employeeFactory = new FactoryMethod().GetFactory(employee);
            Employee permanantEmployee = employeeFactory.GetEmployee();
            EmployeeSystemManager systemManager = new EmployeeSystemManager(new EmployeeSystemFactory().Create(permanantEmployee));
            Console.WriteLine("permanant");
            Console.WriteLine(permanantEmployee.Bonus);
            Console.WriteLine(permanantEmployee.Pay);
            System.Console.WriteLine(systemManager.GetSystemDetails());
            Console.WriteLine("HouseAllowance " + permanantEmployee.HouseAllowance);

            Employee contractEmployee = new Employee("contract");
            BaseEmployeeFactory contractemployeeFactory = new FactoryMethod().GetFactory(contractEmployee);
            systemManager = new EmployeeSystemManager(new EmployeeSystemFactory().Create(contractEmployee));
            permanantEmployee = contractemployeeFactory.GetEmployee();
            Console.WriteLine("contract");
            Console.WriteLine(permanantEmployee.Bonus);
            Console.WriteLine(permanantEmployee.Pay);
            System.Console.WriteLine(systemManager.GetSystemDetails());
            Console.WriteLine("medialAllowance " + permanantEmployee.MedicalAllowance);

            Console.ReadKey();
        }
    }
}
