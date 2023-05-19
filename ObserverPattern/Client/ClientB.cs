namespace ObserverPattern;

public sealed class ClientB
{
    private Newspaper _newYork = new();
    public void DoSomething()
    {
        Console.WriteLine("Subscribing customers to the newspaper - New York\n");
        for (int i = 0; i < 20; i++)
        {
            _newYork.AddSub(new NewspaperSubA());
        }
        Console.WriteLine("Current subs: " + _newYork.Subscribers.Count);

        Console.WriteLine("\nNotifying subs.");
        _newYork.IssueNewspaper();

        Console.WriteLine("\nCurrent subs: " + _newYork.Subscribers.Count);
    }
}