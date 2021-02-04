using System;

namespace Strategy
{
    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + "$ payed with credit card");
        }
    }
}
