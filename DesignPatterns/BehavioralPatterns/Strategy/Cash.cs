using System;

namespace Strategy
{
    public class Cash : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + "$ payed with cash");
        }
    }
}
