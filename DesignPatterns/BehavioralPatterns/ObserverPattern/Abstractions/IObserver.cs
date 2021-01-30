namespace Observer.Abstractions
{
    public interface IObserver
    {
        public void Update(string eventData);
    }
}
