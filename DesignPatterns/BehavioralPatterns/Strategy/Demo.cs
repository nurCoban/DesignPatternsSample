using System;

namespace Strategy
{
    class Demo
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var context = new Context();

            var amount = random.Next(10000);
            Console.WriteLine("Your debt is {0}$", amount);
            Console.WriteLine("How would you like to pay");
            Console.WriteLine("1.Cash\n2.PayPal\n3.CreditCard");

            var answer = Console.ReadLine();

            if (answer == "1")
            {
                context.SetPaymentMethod(new Cash());
            }
            else if (answer == "2")
            {
                context.SetPaymentMethod(new PayPal());
            }
            else if (answer == "3")
            {
                context.SetPaymentMethod(new CreditCard());
            }
            else
            {
                throw new Exception("Wrong payment type");
            }

            context.MakePayment(amount);
        }
    }
}
