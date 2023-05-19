
namespace ObserverPattern;

public sealed class VehicleCustomerA : ISubscriber
{
    public void Update(bool status, IPublisher publisher)
    {
        if (status)
            PlaceOrderAndUnsub(publisher);
    }

    private void PlaceOrderAndUnsub(IPublisher publisher)
    {
        publisher.RemoveSub(this);
        System.Console.WriteLine(GetType().Name + " unsubbed.");
    }
}
