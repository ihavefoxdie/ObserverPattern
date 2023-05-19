namespace ObserverPattern;

public abstract class Publisher : IPublisher
{
    protected List<ISubscriber> _subs = new List<ISubscriber>();
    public IReadOnlyList<ISubscriber> Subscribers
    {
        get
        {
            return _subs;
        }
    }
    public bool State { get; set; }
    public void AddSub(ISubscriber sub)
    {
        _subs.Add(sub);
    }

    public void RemoveSub(ISubscriber sub)
    {
        _subs.Remove(sub);
    }

    public void Notify()
    {
        int initCount = _subs.Count;
        for (int i = 0; i < _subs.Count; i++)
        {
            _subs[i].Update(State, this);
            if (_subs.Count < initCount)
            {
                i--;
                initCount = _subs.Count;
            }
        }
    }
}
