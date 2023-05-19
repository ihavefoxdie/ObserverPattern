
namespace ObserverPattern;

public interface IPublisher
{
    public void AddSub(ISubscriber sub);
    public void RemoveSub(ISubscriber sub);
    public void Notify();
}
