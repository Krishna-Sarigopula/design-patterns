public class Program
{
    static void Main(string[] args)
    {
        IEmployee permanantEmployee = EmployeeFactory.GetEmployee("permanant");
        Console.WriteLine("permanant");
        Console.WriteLine(permanantEmployee.GetPay());
        Console.WriteLine(permanantEmployee.GetBonus());

        IEmployee contractEmployee = EmployeeFactory.GetEmployee("contract");
        Console.WriteLine("contract");
        Console.WriteLine(contractEmployee.GetPay());
        Console.WriteLine(contractEmployee.GetBonus());


        Console.ReadKey();
    }
}
