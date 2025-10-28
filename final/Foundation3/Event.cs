public abstract class Event
{
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _addr;
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
        return ($"Title: {_title} - Description: {_desc} - Date: {_date} - Time: {_time} - Address: {_addr.GFullAddr()}");
    }
}