class IDBIPayment : IPayment
{
    public void ProcessPayment(string paymentSystem)
    {
        System.Console.WriteLine("IDBI Payment");
    }
}