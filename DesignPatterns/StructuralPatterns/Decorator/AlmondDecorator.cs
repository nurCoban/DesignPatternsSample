using System;

namespace Decorator
{
    public class AlmondDecorator : FlavourDecorator
    {
        public AlmondDecorator(IIceCream decorated) : base(decorated)
        {
        }

        public override void Make()
        {
            Console.Write("Almond, ");
            this.Decorated.Make();
        }
    }
}
