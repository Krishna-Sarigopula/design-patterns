namespace AbstractFactoryPattern
{
    public class ContractEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 5;
        }

        public int GetPay()
        {
            return 4;
        }

        public int GetMedicalAllowance()
        {
            return 100;
        }
    }
}
