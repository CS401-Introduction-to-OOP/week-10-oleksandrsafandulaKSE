using System.Collections;

namespace week_10_oleksandrsafandulaKSE;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events;

    public EventLog()
    {
        _events = new List<Event>();
    }
    
    public void AddEvent(Event evenT)
    {
        _events.Add(evenT);
    }
    
    public IEnumerable<Event> GetInChrono()
    {
        foreach (var evenT in _events.OrderBy(x => x.Step))
        {
            yield return evenT;
        }
    }

    public IEnumerable<Event> GetAllEvents()
    {
        foreach (var evenT  in _events)
        {
            yield return evenT;
        }
    }
    
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var evenT in _events)
        {
            yield return evenT;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}