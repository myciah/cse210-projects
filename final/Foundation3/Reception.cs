public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string desc, string date, string time, Address addr, string rsvpEmail)
        : base(title, desc, date, time, addr)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }
    public string GFullReception()
    {
        ($"{GStandard()} - Type: {_eventType} - RSVP Email: {_rsvpEmail}");
    }
}