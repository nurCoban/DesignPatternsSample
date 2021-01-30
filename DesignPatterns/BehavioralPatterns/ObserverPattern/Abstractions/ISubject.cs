namespace Observer.Abstractions
{
    public interface ISubject
    {
        public void Register(IObserver observer);
        public void UnRegister(IObserver observer);
        public void Notify(string eventData);
    }
}
