namespace Strategy
{
    public class Context
    {
        private IPaymentMethod PaymentMethod;

        public void SetPaymentMethod(IPaymentMethod paymentMethod)
        {
            this.PaymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            this.PaymentMethod.Pay(amount);
        }
    }
}
