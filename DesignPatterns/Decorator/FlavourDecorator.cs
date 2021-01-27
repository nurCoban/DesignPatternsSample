namespace Decorator
{
    public abstract class FlavourDecorator : IIceCream
    {
        protected IIceCream Decorated;

        public FlavourDecorator(IIceCream decorated)
        {
            this.Decorated = decorated;
        }

        public abstract void Make();
    }
}
