using System;

namespace Decorator
{
    class VanillaIceCream : IIceCream
    {
        public void Make()
        {
            Console.WriteLine("Vanilla ice cream!");
        }
    }
}
