using System;

namespace Strategy
{
    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + "$ payed with PayPal");
        }
    }
}
