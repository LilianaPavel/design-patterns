
namespace DesignPatterns.ObserverPattern
{
    interface IObserver
    {
        // update with Push
        void Update(float temp, float humidity, float pressure);
        // update with Pull
        // void Update();
    }
}
