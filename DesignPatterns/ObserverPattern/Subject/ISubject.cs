
namespace DesignPatterns.ObserverPattern
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void DeregisterObserver(IObserver observer);
        void NotifyObservers();

    }
}
