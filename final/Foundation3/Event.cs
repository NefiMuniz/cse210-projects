public class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{title}\n{description}\n{date} {time}\n{address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {GetType().Name}";
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date}";
    }
}