namespace ObserverPattern;

public sealed class ClientA
{
    private CarManufacturer _mercedes = new();
    public void DoSomething()
    {
        Console.WriteLine("Subscribing customers to Cars Manufacturer - Mercedes\n");
        for (int i = 0; i < 3; i++)
        {
            _mercedes.AddSub(new VehicleCustomerA());
        }

        for (int i = 0; i < 6; i++)
        {
            _mercedes.AddSub(new VehicleCustomerB());
        }
        Console.WriteLine("Current subs: " + _mercedes.Subscribers.Count);

        Console.WriteLine("\nNotifying subs:");
        _mercedes.ManufactureCars();

        Console.WriteLine("\nCurrent subs: " + _mercedes.Subscribers.Count);
        foreach (ISubscriber sub in _mercedes.Subscribers)
        {
            Console.WriteLine(sub.GetType().Name);
        }
    }
}