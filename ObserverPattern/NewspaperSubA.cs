namespace ObserverPattern;

public sealed class NewspaperSubA : ISubscriber
{
    public void Update(bool status, IPublisher publisher)
    {
        if (!Survey())
        {
            publisher.RemoveSub(this);
            Console.WriteLine(GetType().Name + " unsubbed.");
        }
        else
            Console.WriteLine(GetType().Name + " does not wish to be unsubbed.");
    }
    
    private bool Survey()
    {
        Random rand = new Random();
        return Convert.ToBoolean(rand.Next(2));
    }
}
