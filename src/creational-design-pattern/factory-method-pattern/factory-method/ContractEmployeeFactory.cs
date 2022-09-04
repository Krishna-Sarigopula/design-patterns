namespace FactoryMethodPattern
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployee Create()
        {
            ContractEmployee peremployee = new ContractEmployee();
            _employee.MedicalAllowance = peremployee.GetMedicalAllowance();
            return peremployee;
        }
    }
}