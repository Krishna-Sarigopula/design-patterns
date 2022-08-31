namespace FactoryMethodPattern
{
    public class PermanantEmployeeFactory : BaseEmployeeFactory
    {
        public PermanantEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployee Create()
        {
            PermanantEmployee peremployee = new PermanantEmployee();
            _employee.HouseAllowance = peremployee.GetHouseAllowance();
            return peremployee;
        }
    }
}