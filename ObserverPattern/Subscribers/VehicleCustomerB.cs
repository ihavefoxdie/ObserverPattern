namespace ObserverPattern;

public sealed class VehicleCustomerB : ISubscriber
{
    public void Update(bool status, IPublisher publisher)
    {
        if (status)
            PlaceOrderAndSay(publisher);
    }

    private void PlaceOrderAndSay(IPublisher publisher)
    {
        Console.WriteLine(GetType().Name + ": I want this car!!!");
    }
}
