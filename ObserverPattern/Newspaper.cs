namespace ObserverPattern;

public sealed class Newspaper : Publisher
{
    public int Endorsments
    {
        get
        {
            return _subs.Count * 10;
        }
    }
    public Newspaper()
    {
        State = true;
    }
    public void IssueNewspaper()
    {
        Notify();
    }
}
