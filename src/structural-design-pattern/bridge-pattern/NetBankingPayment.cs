class NetbankingPayment : Payment
{
    public override void Makepayment()
    {
        payment?.ProcessPayment("Net banking payment");
    }
}