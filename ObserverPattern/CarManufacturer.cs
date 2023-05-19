namespace ObserverPattern;

public sealed class CarManufacturer : Publisher
{
    public void ManufactureCars()
    {
        State = true;
        Notify();
    }
}
