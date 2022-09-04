namespace FactoryMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("permanant");

            BaseEmployeeFactory employeeFactory = new FactoryMethod().GetFactory(employee);
            Employee permanantEmployee = employeeFactory.GetEmployee();
            Console.WriteLine("permanant");
            Console.WriteLine(permanantEmployee.Bonus);
            Console.WriteLine(permanantEmployee.Pay);
            Console.WriteLine("HouseAllowance " + permanantEmployee.HouseAllowance);

            Employee contractEmployee = new Employee("contract");
            BaseEmployeeFactory contractemployeeFactory = new FactoryMethod().GetFactory(contractEmployee);
            permanantEmployee = contractemployeeFactory.GetEmployee();
            Console.WriteLine("contract");
            Console.WriteLine(permanantEmployee.Bonus);
            Console.WriteLine(permanantEmployee.Pay);
            Console.WriteLine("medialAllowance " + permanantEmployee.MedicalAllowance);

            Console.ReadKey();
        }
    }
}