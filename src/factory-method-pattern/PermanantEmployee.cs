namespace FactoryMethodPattern
{
    public class PermanantEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 10;
        }

        public int GetPay()
        {
            return 8;
        }

        public int GetHouseAllowance()
        {
            return 100;
        }
    }
}