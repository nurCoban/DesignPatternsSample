using System;

namespace Decorator
{
    public class HoneyDecorator : FlavourDecorator
    {
        public HoneyDecorator(IIceCream decorated) : base(decorated)
        {
        }

        public override void Make()
        {
            Console.Write("Honey, ");
            this.Decorated.Make();
        }
    }
}
