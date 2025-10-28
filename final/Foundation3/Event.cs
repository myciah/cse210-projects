public abstract class Event
{
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _addr;
    protected string _eventType;
    public Event(string title, string desc, string date, string time, Address addr)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _addr = addr;
    }
    public string GStandard()
    {
        return ($"Title: {_title} \nDescription: {_desc} \nDate: {_date} \nTime: {_time} \nAddress: {_addr.GFullAddr()}");
    }
    public abstract string GFull();
    public string GShort()
    {
        return ($"Type: {_eventType} \nTitle: {_title} \nDate: {_date}");
    }
}