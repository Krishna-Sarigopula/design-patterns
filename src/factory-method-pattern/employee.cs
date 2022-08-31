namespace FactoryMethodPattern
{
    public class Employee
    {
        public Employee(string type)
        {
            EmployeeType = type;
        }

        public int Id { get; set; }

        public string EmployeeType { get; set; }

        public int Bonus { get; set; }

        public int Pay { get; set; }

        public int HouseAllowance { get; set; }

        public int MedicalAllowance { get; set; }

    }
}