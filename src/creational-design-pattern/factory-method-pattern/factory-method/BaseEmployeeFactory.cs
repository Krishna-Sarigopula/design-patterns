namespace FactoryMethodPattern
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;

        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;
        }

        public Employee GetEmployee()
        {
            IEmployee employee = this.Create();
            _employee.Bonus = employee.GetBonus();
            _employee.Pay = employee.GetPay();
            return _employee;
        }

        public abstract IEmployee Create();
    }
}