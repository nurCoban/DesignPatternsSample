namespace Mediator
{
    public interface IMediator
    {
        public void Send(string eventMessage, Colleague originator);
        public void AddColleague(Colleague colleague);
    }
}
