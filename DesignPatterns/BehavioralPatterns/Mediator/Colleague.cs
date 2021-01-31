namespace Mediator
{
    public abstract class Colleague
    {
        public IMediator Mediator { get; private set; }

        public Colleague(IMediator mediator)
        {
            this.Mediator = mediator;
            this.Mediator.AddColleague(this);
        }

        public void TriggerEvent(string eventMessage)
        {
            this.Mediator.Send(eventMessage, this);
        }

        public abstract void HandleEvent(string message);
    }
}
