class CardPayment : Payment
{
    public override void Makepayment()
    {
        payment?.ProcessPayment("card payment");
    }
}