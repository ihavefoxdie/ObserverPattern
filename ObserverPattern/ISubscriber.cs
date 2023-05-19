
namespace ObserverPattern;

public interface ISubscriber
{
    public void Update(bool status, IPublisher publisher);
}
